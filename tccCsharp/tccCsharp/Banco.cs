using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using System.Net.Configuration;
#pragma warning disable IDE0028
#pragma warning disable IDE0017

namespace tccCsharp
{
    internal class Banco
    {
        static readonly string stringConexao = "Server = pgsql.projetoscti.com.br; " +
                                      "Database = projetoscti9; Port=5432;" +
                                      "User ID= projetoscti9; password = eq273b294;";
        static NpgsqlConnection cn;

        public static void Conectar()
        {
            if (cn == null)
                cn = new NpgsqlConnection();
            try
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.ConnectionString = stringConexao;
                    cn.Open();
                }
            }
            catch (NpgsqlException ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }
        public static void Desconectar()
        {
            cn.Close();// fecha a conexão com o banco de dados
            cn.Dispose(); // libera os recursos utilizados
            cn = null;
        }

        //Select com parametros retornando um DataReader
        public static NpgsqlDataReader Selecionar(string sql, List<object> parametros)
        {
            try
            {
                Conectar();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = cn;
                int i = 1;
                foreach (object parametro in parametros)
                    cmd.Parameters.AddWithValue(i++.ToString(), parametro);
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (NpgsqlException ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }

        public static int Logar(string email, string senha)
        {
            string sql;
            int id = 0;
            try
            {
                sql = "select id_usuario,nome from gp2_usuarios ";
                sql += " where email = @1 and senha = @2 and excluido = false";
                List<object> param = new List<object>();
                param.Add(email);
                param.Add(senha);

                NpgsqlDataReader dr = Banco.Selecionar(sql, param);
                if (dr.Read())
                {
                    id = Convert.ToInt32(dr["id_usuario"]);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao logar no sistema !!!" + "\n\nMais detalhes: " + ex.Message, "Login do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                Desconectar();
            }
            return id;
        }

        public static User CarregaPerfil(User usuario)
        {
            string sql;
            try
            {
                sql = "select nome, bio, avatar, naturalidade, nascimento, inscricao, email, telefone, commits from gp2_usuarios";
                sql += " where id_usuario = @1 and excluido = false";

                List<object> param = new List<object>();
                param.Add(Program.id_usuario);

                NpgsqlDataReader dr = Banco.Selecionar(sql, param);
                dr.Read();
                usuario.nome = dr["nome"].ToString();
                usuario.bio = dr["bio"] != DBNull.Value ? dr["bio"].ToString() : null;
                usuario.avatar = dr["avatar"] != DBNull.Value ? Convert.ToInt32(dr["avatar"]) : 0;
                usuario.naturalidade = dr["naturalidade"] != DBNull.Value ? dr["naturalidade"].ToString() : null;
                usuario.inscricao = Convert.ToDateTime(dr["inscricao"]);
                usuario.email = dr["email"].ToString();
                usuario.telefone = dr["telefone"] != DBNull.Value ? dr["telefone"].ToString() : null;
                usuario.commits = dr["commits"] != DBNull.Value ? Convert.ToInt32(dr["commits"]) : 0;
                if (dr["nascimento"] != DBNull.Value)
                    usuario.nascimento = Convert.ToDateTime(dr["nascimento"]);
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar as informações do usuário !!!" + "\n\nMais detalhes: " + ex.Message, "Login do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
            }
            return usuario;
        }

        public static int[] seguimentos()
        {
            int seguidores = 0;
            int seguidos = 0;
            int[] seguimentos = new int[2] { 0, 0 };
            try
            {
                Conectar();
                string sql = "SELECT COUNT(*) AS seguidores FROM gp2_seguidores WHERE id_seguido = @1";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                List<object> param = new List<object>();
                param.Add(Program.id_usuario);
                NpgsqlDataReader dr = Banco.Selecionar(sql, param);
                if (dr.Read())
                {
                    seguidores = Convert.ToInt32(dr["seguidores"]);
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar as informações do usuário !!!" + "\n\nMais detalhes: " + ex.Message, "Login do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
            }

            try
            {
                Conectar();
                string sql = "SELECT COUNT(*) AS seguidos FROM gp2_seguidores WHERE id_seguidor = @1";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                List<object> param = new List<object>();
                param.Add(Program.id_usuario);
                NpgsqlDataReader dr = Banco.Selecionar(sql, param);
                if (dr.Read())
                {
                    seguidos = Convert.ToInt32(dr["seguidos"]);
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar as informações do usuário !!!" + "\n\nMais detalhes: " + ex.Message, "Login do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
            }

            seguimentos[0] = seguidores;
            seguimentos[1] = seguidos;
            return seguimentos;
        }

        public static Project RecarregaSelecionado()
        {
            Project selecionado = new Project();
            string sql;
            try
            {
                sql = "select id_projeto, id_criador, autores, email_contato, nome_projeto, palavras_chave, publico, descricao_breve, descricao_detalhada, link_site, link_youtube, status, porcentagem, data_criacao, data_atualizacao, atualizador, excluido, linguagem, previsao, num_grupos from gp2_projetos where id_projeto = @1 ";
                List<object> param = new List<object>();
                param.Add(Program.id_projeto_atual);

                NpgsqlDataReader dr = Banco.Selecionar(sql, param);
                dr.Read();
                selecionado.id_projeto = Convert.ToInt32(dr["id_projeto"]);
                selecionado.id_criador = Convert.ToInt32(dr["id_criador"]);
                selecionado.autores = dr["autores"] != DBNull.Value ? dr["autores"].ToString() : null;
                selecionado.email_contato = dr["email_contato"] != DBNull.Value ? dr["email_contato"].ToString() : null;
                selecionado.nome_projeto = dr["nome_projeto"].ToString();
                selecionado.palavras_chave = dr["palavras_chave"] != DBNull.Value ? dr["palavras_chave"].ToString() : null;
                selecionado.publico = dr["publico"] != DBNull.Value ? Convert.ToBoolean(dr["publico"]) : false;
                selecionado.descricao_breve = dr["descricao_breve"].ToString();
                selecionado.descricao_detalhada = dr["descricao_detalhada"] != DBNull.Value ? dr["descricao_detalhada"].ToString() : null;
                selecionado.link_site = dr["link_site"] != DBNull.Value ? dr["link_site"].ToString() : null;
                selecionado.link_youtube = dr["link_youtube"] != DBNull.Value ? dr["link_youtube"].ToString() : null;
                selecionado.status = dr["status"] != DBNull.Value ? Convert.ToInt32(dr["status"]) : 1;
                selecionado.porcentagem = dr["porcentagem"] != DBNull.Value ? Convert.ToDecimal(dr["porcentagem"]) : 0;
                selecionado.excluido = Convert.ToBoolean(dr["excluido"]);
                selecionado.linguagem = dr["linguagem"] != DBNull.Value ? dr["linguagem"].ToString() : null;
                selecionado.numero_grupos = dr["num_grupos"] != DBNull.Value ? Convert.ToInt32(dr["num_grupos"]) : 0;
                if (dr["previsao"] != DBNull.Value)
                    selecionado.previsao = Convert.ToDateTime(dr["previsao"]);
                if (dr["atualizador"] != DBNull.Value)
                    selecionado.atualizador = Convert.ToInt32(dr["atualizador"]);
                if (dr["data_atualizacao"] != DBNull.Value)
                    selecionado.data_atualizacao = Convert.ToDateTime(dr["data_atualizacao"]);

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar esse projeto!!!" + "\n\nMais detalhes: " + ex.Message, "Erro ao carregar projetos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
            }
            return selecionado;
        }

        public static List<Project> CarregarProjetos(List<Project> projetos)
        {
            Program.projetos.Clear();
            string sql;
            try
            {
                sql = "select T1.id_projeto, id_criador, autores, email_contato, nome_projeto, palavras_chave, publico, descricao_breve, descricao_detalhada, link_site, link_youtube, status, porcentagem, data_criacao, data_atualizacao, atualizador, excluido, linguagem, previsao, num_grupos " +
                    "from gp2_projetos T1 INNER JOIN gp2_colaboradores T2 ON T1.id_projeto = T2.id_projeto " +
                    "where id_colaborador = @1 and excluido = false order by data_criacao ASC";
                List<object> param = new List<object>();
                param.Add(Program.id_usuario);

                NpgsqlDataReader dr = Banco.Selecionar(sql, param);
                while (dr.Read())
                {
                    Project linha = new Project();
                    linha.id_projeto = Convert.ToInt32(dr["id_projeto"]);
                    linha.id_criador = Convert.ToInt32(dr["id_criador"]);
                    linha.autores = dr["autores"] != DBNull.Value ? dr["autores"].ToString() : null;
                    linha.email_contato = dr["email_contato"] != DBNull.Value ? dr["email_contato"].ToString() : null;
                    linha.nome_projeto = dr["nome_projeto"].ToString();
                    linha.palavras_chave = dr["palavras_chave"] != DBNull.Value ? dr["palavras_chave"].ToString() : null;
                    linha.publico = dr["publico"] != DBNull.Value ? Convert.ToBoolean(dr["publico"]) : false;
                    linha.descricao_breve = dr["descricao_breve"].ToString();
                    linha.descricao_detalhada = dr["descricao_detalhada"] != DBNull.Value ? dr["descricao_detalhada"].ToString() : null;
                    linha.link_site = dr["link_site"] != DBNull.Value ? dr["link_site"].ToString() : null;
                    linha.link_youtube = dr["link_youtube"] != DBNull.Value ? dr["link_youtube"].ToString() : null;
                    linha.status = dr["status"] != DBNull.Value ? Convert.ToInt32(dr["status"]) : 1;
                    linha.porcentagem = dr["porcentagem"] != DBNull.Value ? Convert.ToDecimal(dr["porcentagem"]) : 0;
                    linha.data_criacao = Convert.ToDateTime(dr["data_criacao"]);
                    linha.excluido = Convert.ToBoolean(dr["excluido"]);
                    linha.linguagem = dr["linguagem"] != DBNull.Value ? dr["linguagem"].ToString() : null;
                    linha.numero_grupos = dr["num_grupos"] != DBNull.Value ? Convert.ToInt32(dr["num_grupos"]) : 0;
                    if (dr["previsao"] != DBNull.Value)
                        linha.previsao = Convert.ToDateTime(dr["previsao"]);
                    if (dr["atualizador"] != DBNull.Value)
                        linha.atualizador = Convert.ToInt32(dr["atualizador"]);
                    if (dr["data_atualizacao"] != DBNull.Value)
                        linha.data_atualizacao = Convert.ToDateTime(dr["data_atualizacao"]);
                    projetos.Add(linha);
                };
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar seus projetos!!!" + "\n\nMais detalhes: " + ex.Message, "Erro ao carregar projetos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
            }
            return projetos;
        }

        public static void AtualizarProjeto(Project Atualizar)
        {
            try
            {
                Conectar();
                String sql = "UPDATE gp2_projetos SET autores = @1, email_contato = @2, nome_projeto = @3, ";
                sql += "palavras_chave = @4, publico = @5, descricao_breve = @6, descricao_detalhada = @7, link_site = @8, ";
                sql += "link_youtube = @9, status = @10, porcentagem = @11, data_atualizacao = @12, atualizador = @13, ";
                sql += "linguagem = @14, previsao = @15 WHERE id_projeto = @16 ";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@1", String.IsNullOrWhiteSpace(Atualizar.autores) ? (object)DBNull.Value : (object)Atualizar.autores);
                cmd.Parameters.AddWithValue("@2", String.IsNullOrWhiteSpace(Atualizar.email_contato) ? (object)DBNull.Value : (object)Atualizar.email_contato);
                cmd.Parameters.AddWithValue("@3", Atualizar.nome_projeto);
                cmd.Parameters.AddWithValue("@4", String.IsNullOrWhiteSpace(Atualizar.palavras_chave) ? (object)DBNull.Value : (object)Atualizar.palavras_chave);
                cmd.Parameters.AddWithValue("@5", Atualizar.publico);
                cmd.Parameters.AddWithValue("@6", Atualizar.descricao_breve);
                cmd.Parameters.AddWithValue("@7", String.IsNullOrWhiteSpace(Atualizar.descricao_detalhada) ? (object)DBNull.Value : (object)Atualizar.descricao_detalhada);
                cmd.Parameters.AddWithValue("@8", String.IsNullOrWhiteSpace(Atualizar.link_site) ? (object)DBNull.Value : (object)Atualizar.link_site);
                cmd.Parameters.AddWithValue("@9", String.IsNullOrWhiteSpace(Atualizar.link_youtube) ? (object)DBNull.Value : (object)Atualizar.link_youtube);
                cmd.Parameters.AddWithValue("@10", (Atualizar.status == 0 ? (object)DBNull.Value : (object)Atualizar.status));
                cmd.Parameters.AddWithValue("@11", Atualizar.porcentagem);
                cmd.Parameters.AddWithValue("@12", Atualizar.data_atualizacao);
                cmd.Parameters.AddWithValue("@13", Atualizar.atualizador);
                cmd.Parameters.AddWithValue("@14", String.IsNullOrWhiteSpace(Atualizar.linguagem) ? (object)DBNull.Value : (object)Atualizar.linguagem);
                cmd.Parameters.AddWithValue("@15", Atualizar.previsao == new DateTime(1, 1, 1) ? (object)DBNull.Value : (object)Atualizar.previsao);
                cmd.Parameters.AddWithValue("@16", Program.id_projeto_atual);

                cmd.ExecuteNonQuery();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar o projeto !!!" + "\n\nMais detalhes: " + ex.Message, "Criar Projeto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
                Banco.NewCommit();
            }
        }

        public static int InserirProjeto(Project Novo)
        {
            int idInserido;
            try
            {
                Conectar();
                String sql = "INSERT INTO gp2_projetos (id_criador, autores, email_contato, nome_projeto, ";
                sql += "palavras_chave, publico, descricao_breve, descricao_detalhada, link_site, ";
                sql += "link_youtube, status, porcentagem, data_criacao, data_atualizacao, atualizador, ";
                sql += "excluido, linguagem, previsao, num_grupos) VALUES ";
                sql += "(@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18, @19) RETURNING id_projeto";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@1", Novo.id_criador);
                cmd.Parameters.AddWithValue("@2", String.IsNullOrWhiteSpace(Novo.autores) ? (object)DBNull.Value : (object)Novo.autores);
                cmd.Parameters.AddWithValue("@3", String.IsNullOrWhiteSpace(Novo.email_contato) ? (object)DBNull.Value : (object)Novo.email_contato);
                cmd.Parameters.AddWithValue("@4", Novo.nome_projeto);
                cmd.Parameters.AddWithValue("@5", String.IsNullOrWhiteSpace(Novo.palavras_chave) ? (object)DBNull.Value : (object)Novo.palavras_chave);
                cmd.Parameters.AddWithValue("@6", Novo.publico);
                cmd.Parameters.AddWithValue("@7", Novo.descricao_breve);
                cmd.Parameters.AddWithValue("@8", String.IsNullOrWhiteSpace(Novo.descricao_detalhada) ? (object)DBNull.Value : (object)Novo.descricao_detalhada);
                cmd.Parameters.AddWithValue("@9", String.IsNullOrWhiteSpace(Novo.link_site) ? (object)DBNull.Value : (object)Novo.link_site);
                cmd.Parameters.AddWithValue("@10", String.IsNullOrWhiteSpace(Novo.link_youtube) ? (object)DBNull.Value : (object)Novo.link_youtube);
                cmd.Parameters.AddWithValue("@11", (Novo.status == 0 ? (object)DBNull.Value : (object)Novo.status));
                cmd.Parameters.AddWithValue("@12", Novo.porcentagem);
                cmd.Parameters.AddWithValue("@13", Novo.data_criacao);
                cmd.Parameters.AddWithValue("@14", Novo.data_atualizacao);
                cmd.Parameters.AddWithValue("@15", Novo.atualizador);
                cmd.Parameters.AddWithValue("@16", Novo.excluido);
                cmd.Parameters.AddWithValue("@17", String.IsNullOrWhiteSpace(Novo.linguagem) ? (object)DBNull.Value : (object)Novo.linguagem);
                cmd.Parameters.AddWithValue("@18", Novo.previsao == new DateTime(1, 1, 1) ? (object)DBNull.Value : (object)Novo.previsao);
                cmd.Parameters.AddWithValue("@19", Novo.numero_grupos);

                idInserido = Convert.ToInt32(cmd.ExecuteScalar());
                Program.id_projeto_atual = idInserido;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Ocorreu um erro ao criar o projeto !!!" + "\n\nMais detalhes: " + ex.Message, "Criar Projeto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                idInserido = 0;
            }
            finally
            {
                Desconectar();
                Banco.NewCommit();
            }
            return idInserido;
        }

        public static List<Status> CarregaStatus()
        {
            string sql = "SELECT id_status, status FROM gp2_status ORDER BY id_status ASC"; ;
            List<Status> list = new List<Status>();
            try
            {
                Conectar();
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Status linha = new Status();
                    linha.id_status = Convert.ToInt32(dr["id_status"]);
                    linha.status = dr["status"].ToString();
                    list.Add(linha);
                };
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar informações essenciais!!!" + "\n\nMais detalhes: " + ex.Message, "Projeto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
            }
            return list;
        }
        public static void InserirMultiplo(List<GroupSteps> Inserir)
        {
            try
            {
                Conectar();
                for (int i = 0; i < Inserir.Count; i++)
                {
                    String sql = "INSERT INTO gp2_grupos_etapas (id_projeto, nome_grupo, porcentagem, mostrar_porcentagem, ordenador, excluido, num_etapas) VALUES( @1, @2, @3, @4, @5, @6, @7)";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                    GroupSteps grupo = new GroupSteps();
                    grupo = Inserir[i];
                    cmd.Parameters.AddWithValue("@1", grupo.id_projeto);
                    cmd.Parameters.AddWithValue("@2", grupo.nome_grupo);
                    cmd.Parameters.AddWithValue("@3", grupo.porcentagem);
                    cmd.Parameters.AddWithValue("@4", grupo.mostrar_porcentagem);
                    cmd.Parameters.AddWithValue("@5", grupo.ordenador);
                    cmd.Parameters.AddWithValue("@6", grupo.excluido);
                    cmd.Parameters.AddWithValue("@7", grupo.numero_etapas);
                    cmd.ExecuteNonQuery();
                }
                String sql2 = "UPDATE gp2_projetos SET num_grupos = num_grupos + @1 WHERE id_projeto = @2;";
                NpgsqlCommand cmd2 = new NpgsqlCommand(sql2, cn);
                cmd2.Parameters.AddWithValue("@1", Inserir.Count);
                cmd2.Parameters.AddWithValue("@2", Program.id_projeto_atual);
                cmd2.ExecuteNonQuery();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Ocorreu um erro ao criar o projeto !!!" + "\n\nMais detalhes: " + ex.Message, "Criar Projeto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
                Banco.NewCommit();
            }
        }
        public static void NewCommit()
        {
            try
            {
                Conectar();
                String sql = "UPDATE gp2_usuarios   SET  commits = commits + 1 WHERE id_usuario = @1;";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@1", Program.id_usuario);
                cmd.ExecuteNonQuery();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar suas informações !!!" + "\n\nMais detalhes: " + ex.Message, "Criar Projeto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
            }

            try
            {
                Conectar();
                String sql = "UPDATE gp2_projetos SET  data_atualizacao = NOW(), atualizador = @1 WHERE id_projeto = @2;";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@1", Program.id_usuario);
                cmd.Parameters.AddWithValue("@2", Program.id_projeto_atual);
                cmd.ExecuteNonQuery();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar suas informações !!!" + "\n\nMais detalhes: " + ex.Message, "Criar Projeto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
            }
        }

        public static void ExcluirProjeto()
        {
            try
            {
                Conectar();
                String sql = "UPDATE gp2_projetos SET excluido = true WHERE id_projeto = @1;";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@1", Program.id_projeto_atual);
                cmd.ExecuteNonQuery();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Ocorreu um erro ao excluir o projeto !!!" + "\n\nMais detalhes: " + ex.Message, "Criar Projeto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
                Banco.NewCommit();
            }
        }

        public static Head CabecalhoProjeto()
        {
            Head selecionado = new Head();
            string sql;
            try
            {
                sql = "SELECT T1.data_criacao, T2.nome AS \"criador\", CAST(T1.data_atualizacao AS DATE), T3.nome AS \"atualizador\", CAST(T1.porcentagem AS INT) ";
                sql += "FROM gp2_projetos T1 INNER JOIN gp2_usuarios T2 ON T1.id_criador = T2.id_usuario INNER JOIN gp2_usuarios T3 ON T1.atualizador = T3.id_usuario ";
                sql += "WHERE T1.id_projeto = @1 ";

                List<object> param = new List<object>();
                param.Add(Program.id_projeto_atual);

                NpgsqlDataReader dr = Banco.Selecionar(sql, param);
                dr.Read();
                selecionado.criacao = Convert.ToDateTime(dr["data_criacao"]);
                selecionado.criador_nome = Convert.ToString(dr["criador"]);
                selecionado.atualizacao = Convert.ToDateTime(dr["data_atualizacao"]);
                selecionado.atualizador_nome = Convert.ToString(dr["atualizador"]);
                selecionado.porcentagem_int = Convert.ToInt32(dr["porcentagem"]);
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar esse projeto!!!" + "\n\nMais detalhes: " + ex.Message, "Erro ao carregar projetos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
            }
            return selecionado;
        }

        public static List<GroupSteps> CarregarEtapas(List<GroupSteps> grupos)
        {
            try
            {
                string sql;
                sql = "SELECT G.* FROM gp2_grupos_etapas G WHERE id_projeto = @1 AND excluido = FALSE ORDER BY ordenador";
                List<object> param = new List<object>();
                param.Add(Program.id_projeto_atual);

                NpgsqlDataReader dr = Banco.Selecionar(sql, param);
                while (dr.Read())
                {
                    GroupSteps linha = new GroupSteps();
                    linha.id_grupo = Convert.ToInt32(dr["id_grupo"]);
                    linha.id_projeto = Convert.ToInt32(dr["id_projeto"]);
                    linha.nome_grupo = Convert.ToString(dr["nome_grupo"]);
                    linha.porcentagem = Convert.ToDecimal(dr["porcentagem"]);
                    linha.mostrar_porcentagem = Convert.ToBoolean(dr["mostrar_porcentagem"]);
                    linha.ordenador = Convert.ToInt32(dr["ordenador"]);
                    linha.excluido = Convert.ToBoolean(dr["excluido"]);
                    linha.numero_etapas = Convert.ToInt32(dr["num_etapas"]);
                    grupos.Add(linha);
                }
                dr.Close();

                for (int i = 0; i < grupos.Count; i++)
                {
                    string sql2;
                    sql2 = "SELECT E.* FROM gp2_etapas E WHERE id_grupo = @1 AND excluido = FALSE ORDER BY ordenador";
                    List<object> param2 = new List<object>();
                    param2.Add(grupos[i].id_grupo);

                    grupos[i].etapas = new List<Step>();
                    NpgsqlDataReader dr2 = Banco.Selecionar(sql2, param2);
                    while (dr2.Read())
                    {
                        Step entrelinha = new Step();
                        entrelinha.id_etapa = Convert.ToInt32(dr2["id_etapa"]);
                        entrelinha.id_grupo = Convert.ToInt32(dr2["id_grupo"]);
                        entrelinha.nome_etapa = Convert.ToString(dr2["nome_etapa"]);
                        entrelinha.peso = Convert.ToInt32(dr2["peso"]);
                        entrelinha.porcentagem = Convert.ToDecimal(dr2["porcentagem"]);
                        entrelinha.data_criacao = Convert.ToDateTime(dr2["data_criacao"]);
                        entrelinha.descricao_etapa = dr2["descricao_etapa"] != DBNull.Value ? Convert.ToString(dr2["descricao_etapa"]) : null;
                        entrelinha.status = dr2["status"] != DBNull.Value ? Convert.ToInt32(dr2["status"]) : 1;
                        entrelinha.prioridade = dr2["prioridade"] != DBNull.Value ? Convert.ToInt32(dr2["prioridade"]) : 1;
                        entrelinha.ordenador = dr2["ordenador"] != DBNull.Value ? Convert.ToInt32(dr2["ordenador"]) : 1;
                        entrelinha.responsavel = dr2["responsavel"] != DBNull.Value ? Convert.ToString(dr2["responsavel"]) : null;
                        entrelinha.email_responsavel = dr2["email_responsavel"] != DBNull.Value ? Convert.ToString(dr2["email_responsavel"]) : null;
                        entrelinha.impedimento = dr2["impedimento"] != DBNull.Value ? Convert.ToBoolean(dr2["impedimento"]) : false;
                        entrelinha.descricao_impedimento = dr2["descricao_impedimento"] != DBNull.Value ? Convert.ToString(dr2["descricao_impedimento"]) : null;
                        entrelinha.excluido = dr2["excluido"] != DBNull.Value ? Convert.ToBoolean(dr2["excluido"]) : false;
                        if (dr2["data_atualizacao"] != DBNull.Value)
                            entrelinha.data_atualizacao = Convert.ToDateTime(dr2["data_atualizacao"]);

                        if (dr2["atualizador"] != DBNull.Value)
                            entrelinha.atualizador = Convert.ToInt32(dr2["atualizador"]);
                        grupos[i].etapas.Add(entrelinha);
                    }
                    dr2.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar esse projeto!!!" + "\n\nMais detalhes: " + ex.Message, "Erro ao carregar projeto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
            }
            return grupos;
        }

        public static List<Photo> CarregaImagens(List<Photo> imagens)
        {
            try
            {
                string sql;
                sql = "SELECT * FROM gp2_imagens WHERE id_projeto = @1 ORDER BY id_imagem ASC";
                List<object> param = new List<object>();
                param.Add(Program.id_projeto_atual);

                NpgsqlDataReader dr = Banco.Selecionar(sql, param);
                while (dr.Read())
                {
                    Photo linha = new Photo();
                    linha.id_projeto = Convert.ToInt32(dr["id_projeto"]);
                    linha.id_imagem = Convert.ToInt32(dr["id_imagem"]);
                    linha.nome = Convert.ToString(dr["nome"]);
                    linha.descricao_imagem = Convert.ToString(dr["descricao_imagem"]);
                    linha.diretorio = Convert.ToString(dr["diretorio"]);
                    linha.imagem_principal = Convert.ToBoolean(dr["imagem_principal"]);
                    imagens.Add(linha);
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar as imagens desse projeto!!!" + "\n\nMais detalhes: " + ex.Message, "Erro ao carregar imagens", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
            }
            return imagens;
        }

        public static int InsereImagem(Photo foto)
        {
            int idInserido = 0;
            try 
            {
                Conectar();
                String sql = "INSERT INTO gp2_imagens (id_projeto, diretorio, nome, descricao_imagem, imagem_principal) VALUES ";
                sql += "(@1, @2, @3, @4, @5) RETURNING id_imagem";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@1", Program.id_projeto_atual);
                cmd.Parameters.AddWithValue("@2", foto.diretorio);
                cmd.Parameters.AddWithValue("@3", foto.nome);
                cmd.Parameters.AddWithValue("@4", foto.descricao_imagem);
                cmd.Parameters.AddWithValue("@5", foto.imagem_principal);

                idInserido = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception  ex)
            {
                MessageBox.Show("Ocorreu um erro ao inserir a imagem desse projeto!!!" + "\n\nMais detalhes: " + ex.Message, "Erro ao inserir imagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
                Banco.NewCommit();
                VerificaImagemPrincipal(foto.id_projeto);
            }
            return idInserido;
        }

        public static void DeleteImagem(int Idimagem)
        {
            int idProjeto = 0;
            try
            {
                Conectar();
                String selectProjetoSql = "SELECT id_projeto FROM gp2_imagens WHERE id_imagem = @1";
                NpgsqlCommand selectProjetoCmd = new NpgsqlCommand(selectProjetoSql, cn);
                selectProjetoCmd.Parameters.AddWithValue("@1", Idimagem);
                idProjeto = Convert.ToInt32(selectProjetoCmd.ExecuteScalar());


                String deleteSql = "DELETE FROM gp2_imagens WHERE id_imagem = @1";
                NpgsqlCommand deleteCmd = new NpgsqlCommand(deleteSql, cn);
                deleteCmd.Parameters.AddWithValue("@1", Idimagem);
                deleteCmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao excluir a imagem!!!" + "\n\nMais detalhes: " + ex.Message, "Erro ao excluir imagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
                Banco.NewCommit();
                VerificaImagemPrincipal(idProjeto);
            }
        }

        public static void AlteraDiretorio(int Idimagem, string diretorio)
        {
            try
            {
                Conectar();
                String sql = "UPDATE  gp2_imagens SET diretorio = @1 WHERE id_imagem = @2";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@1", diretorio);
                cmd.Parameters.AddWithValue("@2", Idimagem);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao inserir a imagem desse projeto!!!" + "\n\nMais detalhes: " + ex.Message, "Erro ao inserir imagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
            }
        }

        public static void AlteraPrincipal()
        {
            try
            {
                Conectar();
                String sql = "UPDATE  gp2_imagens SET imagem_principal = FALSE WHERE id_projeto = @1";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@1", Program.id_projeto_atual);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao inserir a imagem desse projeto!!!" + "\n\nMais detalhes: " + ex.Message, "Erro ao inserir imagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
            }
        }

        public static void UpdateImagem(string nome, string descri, bool principal, int IdImagem)
        {
            int idProjeto = 0;
            try
            {
                Conectar();
                String sql = "UPDATE  gp2_imagens SET nome = @1, descricao_imagem = @2, imagem_principal = @3 WHERE id_imagem = @4 RETURNING id_projeto";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@1", nome);
                cmd.Parameters.AddWithValue("@2", descri);
                cmd.Parameters.AddWithValue("@3", principal);
                cmd.Parameters.AddWithValue("@4", IdImagem);
                idProjeto = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao inserir a imagem desse projeto!!!" + "\n\nMais detalhes: " + ex.Message, "Erro ao inserir imagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
                Banco.NewCommit();
                VerificaImagemPrincipal(idProjeto);
            }
        }

        public static List<GroupSteps> ConsultaGrupos(int except)
        {
            List<GroupSteps> grupos = new List<GroupSteps>();
            try
            {
                string sql;
                sql = "SELECT * FROM gp2_grupos_etapas WHERE id_projeto = @1 AND id_grupo != @2 ORDER BY ordenador ASC";
                List<object> param = new List<object>();
                param.Add(Program.id_projeto_atual);
                param.Add(except);

                NpgsqlDataReader dr = Banco.Selecionar(sql, param);
                while (dr.Read())
                {
                    GroupSteps linha = new GroupSteps();
                    linha.ordenador = Convert.ToInt32(dr["ordenador"]);
                    linha.nome_grupo = Convert.ToString(dr["nome_grupo"]);
                    linha.id_grupo = Convert.ToInt32(dr["id_grupo"]);
                    grupos.Add(linha);
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os grupos desse projeto!!!" + "\n\nMais detalhes: " + ex.Message, "Erro ao carregar imagens", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
            }
            return grupos;
        }

        public static void AlteraOrdenadorGrupo(int id_projeto, int ordenadorAcima, int quant)
        {
            try
            {
                Conectar();
                String sql = "UPDATE gp2_grupos_etapas	SET  ordenador = ordenador + @1 WHERE id_projeto = @2 AND ordenador >= @3;";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@1", quant);
                cmd.Parameters.AddWithValue("@2", id_projeto);
                cmd.Parameters.AddWithValue("@3", ordenadorAcima);
                cmd.ExecuteNonQuery();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar suas informações !!!" + "\n\nMais detalhes: " + ex.Message, "Criar Projeto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
            }
        }

        public static int InsereGrupo(GroupSteps grupo)
        {
            int idInserido = 0;
            try
            {
                Conectar();
                String sql = "INSERT INTO gp2_grupos_etapas (id_projeto, nome_grupo, porcentagem, mostrar_porcentagem, ordenador, excluido, num_etapas) VALUES ";
                sql += "(@1, @2, @3, @4, @5, @6, @7) RETURNING id_grupo";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@1", Program.id_projeto_atual);
                cmd.Parameters.AddWithValue("@2", grupo.nome_grupo);
                cmd.Parameters.AddWithValue("@3", grupo.porcentagem);
                cmd.Parameters.AddWithValue("@4", grupo.mostrar_porcentagem);
                cmd.Parameters.AddWithValue("@5", grupo.ordenador);
                cmd.Parameters.AddWithValue("@6", grupo.excluido);
                cmd.Parameters.AddWithValue("@7", grupo.numero_etapas);

                idInserido = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao inserir a imagem desse projeto!!!" + "\n\nMais detalhes: " + ex.Message, "Erro ao inserir imagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
                Banco.NewCommit();
                Banco.GroupNumAlt(Program.id_projeto_atual, 1);
            }
            return idInserido;
        }

        public static GroupSteps RecarregaGrupo(int IdGrupo)
        {
            GroupSteps selecionado = new GroupSteps();
            string sql;
            try
            {
                sql = "SELECT * FROM gp2_grupos_etapas WHERE id_grupo = @1";
                List<object> param = new List<object>();
                param.Add(IdGrupo);

                NpgsqlDataReader dr = Banco.Selecionar(sql, param);
                dr.Read();
                selecionado.id_projeto = Convert.ToInt32(dr["id_projeto"]);
                selecionado.id_grupo = Convert.ToInt32(dr["id_grupo"]);
                selecionado.nome_grupo = Convert.ToString(dr["nome_grupo"]);
                selecionado.porcentagem = Convert.ToDecimal(dr["porcentagem"]);
                selecionado.mostrar_porcentagem = Convert.ToBoolean(dr["mostrar_porcentagem"]);
                selecionado.ordenador = Convert.ToInt32(dr["ordenador"]);
                selecionado.excluido = Convert.ToBoolean(dr["excluido"]);
                selecionado.numero_etapas = Convert.ToInt32(dr["num_etapas"]);

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar esse projeto!!!" + "\n\nMais detalhes: " + ex.Message, "Erro ao carregar projetos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
            }
            return selecionado;
        }

        public static void GroupNumAlt(int IdProjeto, int quant)
        {
            try
            {
                Conectar();
                String sql = "UPDATE gp2_projetos SET  num_grupos = num_grupos + @1 WHERE id_projeto = @2;";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@1", quant);
                cmd.Parameters.AddWithValue("@2", IdProjeto);
                cmd.ExecuteNonQuery();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar suas informações !!!" + "\n\nMais detalhes: " + ex.Message, "Criar Projeto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
            }
        }

        public static void DeleteGroup(int IdGrupo)
        {
            try
            {
                Conectar();
                String sql = "DELETE FROM gp2_grupos_etapas WHERE id_grupo = @1";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@1", IdGrupo);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu ao excluir!!!" + "\n\nMais detalhes: " + ex.Message, "Erro ao inserir imagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
                Banco.NewCommit();
                Banco.GroupNumAlt(Program.id_projeto_atual, -1);
            }
        }

        public static void AtualizaGrupo(GroupSteps Atualizar)
        {
            try
            {
                Conectar();
                String sql = "UPDATE gp2_grupos_etapas SET nome_grupo = @1, mostrar_porcentagem = @2, ordenador = @3 WHERE id_grupo = @4 ";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@1", Atualizar.nome_grupo);
                cmd.Parameters.AddWithValue("@2", Atualizar.mostrar_porcentagem);
                cmd.Parameters.AddWithValue("@3", Atualizar.ordenador);
                cmd.Parameters.AddWithValue("@4", Atualizar.id_grupo);
                cmd.ExecuteNonQuery();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar o grupo !!!" + "\n\nMais detalhes: " + ex.Message, "Criar Projeto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
                Banco.NewCommit();
            }
        }

        public static List<Step> ConsultaEtapas(int grupo, int except)
        {
            List<Step> etapas = new List<Step>();
            try
            {
                string sql;
                sql = "SELECT * FROM gp2_etapas WHERE id_grupo = @1 AND id_etapa != @2 ORDER BY ordenador ASC";
                List<object> param = new List<object>();
                param.Add(grupo);
                param.Add(except);

                NpgsqlDataReader dr = Banco.Selecionar(sql, param);
                while (dr.Read())
                {
                    Step linha = new Step();
                    linha.ordenador = Convert.ToInt32(dr["ordenador"]);
                    linha.nome_etapa = Convert.ToString(dr["nome_etapa"]);
                    etapas.Add(linha);
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar as etapas desse projeto!!!" + "\n\nMais detalhes: " + ex.Message, "Erro ao carregar imagens", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
            }
            return etapas;
        }

        public static void AlteraOrdenadorEtapa(int id_grupo, int ordenadorAcima, int quant)
        {
            try
            {
                Conectar();
                String sql = "UPDATE gp2_etapas	SET  ordenador = ordenador + @1 WHERE id_grupo = @2 AND ordenador >= @3;";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@1", quant);
                cmd.Parameters.AddWithValue("@2", id_grupo);
                cmd.Parameters.AddWithValue("@3", ordenadorAcima);
                cmd.ExecuteNonQuery();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar suas informações !!!" + "\n\nMais detalhes: " + ex.Message, "Criar Projeto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
            }
        }

        public static int InsereEtapa(Step etapa)
        {
            int idInserido = 0;
            try
            {
                Conectar();
                String sql = "INSERT INTO gp2_etapas (id_grupo, nome_etapa, peso, porcentagem, descricao_etapa, status, prioridade, ordenador, " +
                "responsavel, email_responsavel, impedimento, descricao_impedimento, data_criacao, data_atualizacao, atualizador, excluido) VALUES ";
                sql += "(@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16) RETURNING id_etapa";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@1", etapa.id_grupo);
                cmd.Parameters.AddWithValue("@2", etapa.nome_etapa);
                cmd.Parameters.AddWithValue("@3", etapa.peso);
                cmd.Parameters.AddWithValue("@4", etapa.porcentagem);
                cmd.Parameters.AddWithValue("@5", etapa.descricao_etapa);
                cmd.Parameters.AddWithValue("@6", etapa.status);
                cmd.Parameters.AddWithValue("@7", etapa.prioridade);
                cmd.Parameters.AddWithValue("@8", etapa.ordenador);
                cmd.Parameters.AddWithValue("@9", etapa.responsavel);
                cmd.Parameters.AddWithValue("@10", etapa.email_responsavel);
                cmd.Parameters.AddWithValue("@11", etapa.impedimento);
                cmd.Parameters.AddWithValue("@12", etapa.descricao_impedimento);
                cmd.Parameters.AddWithValue("@13", etapa.data_criacao);
                cmd.Parameters.AddWithValue("@14", etapa.data_atualizacao);
                cmd.Parameters.AddWithValue("@15", etapa.atualizador);
                cmd.Parameters.AddWithValue("@16", etapa.excluido);
                

                idInserido = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao inserir a imagem desse projeto!!!" + "\n\nMais detalhes: " + ex.Message, "Erro ao inserir imagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
                Banco.NewCommit();
                Banco.StepNumAlt(etapa.id_grupo, 1);
                Banco.AtualizaPorcentagem(etapa.id_grupo);
            }
            return idInserido;
        }

        public static void StepNumAlt(int IdGrupo, int quant)
        {
            try
            {
                Conectar();
                String sql = "UPDATE gp2_grupos_etapas SET num_etapas = num_etapas + @1 WHERE id_grupo = @2;";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@1", quant);
                cmd.Parameters.AddWithValue("@2", IdGrupo);
                cmd.ExecuteNonQuery();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar suas informações !!!" + "\n\nMais detalhes: " + ex.Message, "Criar Projeto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
            }
        }

        public static void AtualizaPorcentagem(int idGrupo)
        {
            int porcentagemProjeto = 0;
            int porcentagemGrupo = 0;
            try
            {
                Conectar();
                String sql = "SELECT T2.id_projeto, CAST(SUM(T1.porcentagem * T1.peso) * 100/ SUM (T1.peso * 100) AS DECIMAL (10,2)) AS \"MEDIA\" " +
                    "FROM gp2_etapas T1 INNER JOIN gp2_grupos_etapas T2 ON T1.id_grupo = T2.id_grupo " +
                    "WHERE T2.id_projeto = @1 GROUP BY T2.id_projeto";
                List<object> param = new List<object>();
                param.Add(Program.id_projeto_atual);
                NpgsqlDataReader dr = Banco.Selecionar(sql, param);

                if (dr.Read())
                    porcentagemProjeto = Convert.ToInt32(dr["MEDIA"]);
                else
                    porcentagemProjeto = 0;
                dr.Close(); 
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar as informações do projeto do porjeto !!!" + "\n\nMais detalhes: " + ex.Message, "Criar Projeto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
            }

            try
            {
                Conectar();
                String sql = "SELECT T2.id_grupo, CAST(SUM(T1.porcentagem * T1.peso) * 100/ SUM (T1.peso * 100) AS DECIMAL (10,2)) AS \"MEDIA\" " +
                    "FROM gp2_etapas T1 INNER JOIN gp2_grupos_etapas T2 ON T1.id_grupo = T2.id_grupo " +
                    "WHERE T2.id_grupo = @1 GROUP BY T2.id_grupo";
                List<object> param = new List<object>();
                param.Add(idGrupo);
                NpgsqlDataReader dr = Banco.Selecionar(sql, param);

                if (dr.Read())
                    porcentagemGrupo = Convert.ToInt32(dr["MEDIA"]);
                else
                    porcentagemGrupo = 0;
                dr.Close();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar as informações do projeto do porjeto !!!" + "\n\nMais detalhes: " + ex.Message, "Criar Projeto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
            }

            try
            {
                Conectar();
                String sql = "UPDATE gp2_projetos SET porcentagem = @1 where id_projeto = @2";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@1", porcentagemProjeto);
                cmd.Parameters.AddWithValue("@2", Program.id_projeto_atual);
                cmd.ExecuteNonQuery();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar as informações do projeto do porjeto !!!" + "\n\nMais detalhes: " + ex.Message, "Criar Projeto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
            }

            try
            {
                Conectar();
                String sql = "UPDATE gp2_grupos_etapas SET porcentagem = @1 where id_grupo = @2";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@1", porcentagemGrupo);
                cmd.Parameters.AddWithValue("@2", idGrupo);
                cmd.ExecuteNonQuery();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar as informações do projeto do porjeto !!!" + "\n\nMais detalhes: " + ex.Message, "Criar Projeto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
            }
        }
        public static Step RecarregaEtapa(int IdEtapa)
        {
            Step selecionado = new Step();
            string sql;
            try
            {
                sql = "SELECT * FROM gp2_etapas WHERE id_etapa = @1";
                List<object> param = new List<object>();
                param.Add(IdEtapa);

                NpgsqlDataReader dr = Banco.Selecionar(sql, param);
                dr.Read();
                selecionado.id_etapa = Convert.ToInt32(dr["id_etapa"]);
                selecionado.id_grupo = Convert.ToInt32(dr["id_grupo"]);
                selecionado.nome_etapa = Convert.ToString(dr["nome_etapa"]);
                selecionado.peso = Convert.ToInt32(dr["peso"]);
                selecionado.porcentagem = Convert.ToDecimal(dr["porcentagem"]);
                selecionado.descricao_etapa = Convert.ToString(dr["descricao_etapa"]);
                selecionado.status = Convert.ToInt32(dr["status"]);
                selecionado.prioridade = Convert.ToInt32(dr["prioridade"]);
                selecionado.ordenador = Convert.ToInt32(dr["ordenador"]);
                selecionado.responsavel = Convert.ToString(dr["responsavel"]);
                selecionado.email_responsavel = Convert.ToString(dr["email_responsavel"]);
                selecionado.impedimento = Convert.ToBoolean(dr["impedimento"]);
                selecionado.descricao_impedimento = Convert.ToString(dr["descricao_impedimento"]);
                selecionado.data_criacao = Convert.ToDateTime(dr["data_criacao"]);
                selecionado.data_atualizacao = Convert.ToDateTime(dr["data_atualizacao"]);
                selecionado.atualizador = Convert.ToInt32(dr["atualizador"]);
                selecionado.excluido = Convert.ToBoolean(dr["excluido"]);
                
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar esse projeto!!!" + "\n\nMais detalhes: " + ex.Message, "Erro ao carregar projetos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
            }
            return selecionado;
        }

        public static void DeleteStep(int IdEtapa, int IdGrupo)
        {
            try
            {
                Conectar();
                String sql = "DELETE FROM gp2_etapas WHERE id_etapa= @1";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@1", IdEtapa);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu ao excluir!!!" + "\n\nMais detalhes: " + ex.Message, "Erro ao inserir imagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
                Banco.NewCommit();
                Banco.StepNumAlt(IdGrupo, -1);
                Banco.AtualizaPorcentagem(IdGrupo);
            }
        }

        public static void AtualizaEtapa (Step etapa)
        {
            try
            {
                Conectar();
                String sql = "UPDATE gp2_etapas SET id_grupo = @1, nome_etapa = @2, peso = @3, porcentagem = @4, descricao_etapa = @5, status = @6, prioridade = @7, ordenador = @8, " +
                "responsavel = @9, email_responsavel = @10, impedimento = @11, descricao_impedimento = @12, data_atualizacao = @14, atualizador = @15, excluido = @16 ";
                sql += "WHERE id_etapa = @17";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@1", etapa.id_grupo);
                cmd.Parameters.AddWithValue("@2", etapa.nome_etapa);
                cmd.Parameters.AddWithValue("@3", etapa.peso);
                cmd.Parameters.AddWithValue("@4", etapa.porcentagem);
                cmd.Parameters.AddWithValue("@5", etapa.descricao_etapa);
                cmd.Parameters.AddWithValue("@6", etapa.status);
                cmd.Parameters.AddWithValue("@7", etapa.prioridade);
                cmd.Parameters.AddWithValue("@8", etapa.ordenador);
                cmd.Parameters.AddWithValue("@9", etapa.responsavel);
                cmd.Parameters.AddWithValue("@10", etapa.email_responsavel);
                cmd.Parameters.AddWithValue("@11", etapa.impedimento);
                cmd.Parameters.AddWithValue("@12", etapa.descricao_impedimento);
                cmd.Parameters.AddWithValue("@14", etapa.data_atualizacao);
                cmd.Parameters.AddWithValue("@15", etapa.atualizador);
                cmd.Parameters.AddWithValue("@16", etapa.excluido);
                cmd.Parameters.AddWithValue("@17", etapa.id_etapa);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a Etapa!!!" + "\n\nMais detalhes: " + ex.Message, "Erro ao inserir imagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
                Banco.NewCommit();
                Banco.AtualizaPorcentagem(etapa.id_grupo);
            }
        }

        public static List<Collaborators> CarrregaColaboradores()
        {
            List<Collaborators> Colaboradores = new List<Collaborators>();
            try
            {
                Conectar();
                String sql = "SELECT id_colaborador, nome, email, telefone, avatar, colaborador_adm from gp2_colaboradores T1 " +
                    "INNER JOIN gp2_usuarios T2 on T1.id_colaborador = T2.id_usuario " +
                    "INNER JOIN gp2_projetos T3 ON T1.id_projeto = T3.id_projeto AND T1.id_colaborador != T3.id_criador " +
                    "WHERE T1.id_projeto = @1 ORDER BY nome";
                List<object> param = new List<object>();
                param.Add(Program.id_projeto_atual);
                NpgsqlDataReader dr = Banco.Selecionar(sql, param);
                while (dr.Read())
                {
                    Collaborators linha = new Collaborators();
                    linha.nome = Convert.ToString(dr["nome"]);
                    linha.email = Convert.ToString(dr["email"]);
                    linha.telefone = Convert.ToString(dr["telefone"]);
                    linha.isAdmin = Convert.ToBoolean(dr["colaborador_adm"]);
                    linha.avatar = dr["avatar"] != DBNull.Value ? Convert.ToInt32(dr["avatar"]) : 0;
                    linha.idColaborador = Convert.ToInt32(dr["id_colaborador"]);
                    Colaboradores.Add(linha);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os Colaboradores!!!" + "\n\nMais detalhes: " + ex.Message, "Erro ao inserir imagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
            }
            return Colaboradores;
        }

        public static Collaborators CarregaCriador()
        {
            Collaborators Criador = new Collaborators();
            try
            {
                Conectar();
                String sql = "SELECT id_usuario, nome, email, telefone, avatar from gp2_usuarios T1 " +
                    "INNER JOIN gp2_projetos T2 on T1.id_usuario = T2.id_criador " +
                    "WHERE T2.id_projeto = @1";
                List<object> param = new List<object>();
                param.Add(Program.id_projeto_atual);
                NpgsqlDataReader dr = Banco.Selecionar(sql, param);
                dr.Read();
                Criador.nome = Convert.ToString(dr["nome"]);
                Criador.email = Convert.ToString(dr["email"]);
                Criador.telefone = Convert.ToString(dr["telefone"]);
                Criador.isAdmin = true;
                Criador.avatar = dr["avatar"] != DBNull.Value ? Convert.ToInt32(dr["avatar"]) : 0;
                Criador.idColaborador = Convert.ToInt32(dr["id_usuario"]);
                
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os Colaboradores!!!" + "\n\nMais detalhes: " + ex.Message, "Erro ao inserir imagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
            }
            return Criador;
        }

        public static List<Collaborators> CarrregaOutrosUser()
        {
            List<Collaborators> Outros = new List<Collaborators>();
            try
            {
                Conectar();
                String sql = "SELECT T1.id_usuario, nome, email, telefone, avatar FROM gp2_usuarios T1 LEFT JOIN gp2_colaboradores T2 ON T1.id_usuario = T2.id_colaborador AND T2.id_Projeto = @1 where id_colaborador IS NULL ORDER BY nome";
                List<object> param = new List<object>();
                param.Add(Program.id_projeto_atual);
                NpgsqlDataReader dr = Banco.Selecionar(sql, param);
                while (dr.Read())
                {
                    Collaborators linha = new Collaborators();
                    linha.nome = Convert.ToString(dr["nome"]);
                    linha.email = Convert.ToString(dr["email"]);
                    linha.telefone = dr["telefone"] != DBNull.Value ? Convert.ToString(dr["telefone"]): "Sem Telefone";
                    linha.avatar = dr["avatar"] != DBNull.Value ? Convert.ToInt32(dr["avatar"]) : 0;
                    linha.idColaborador = Convert.ToInt32(dr["id_usuario"]);
                    Outros.Add(linha);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os Colaboradores!!!" + "\n\nMais detalhes: " + ex.Message, "Erro ao inserir imagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
            }
            return Outros;
        }

        public static void DeleteCollaborator(int IdColaborador)
        {
            try
            {
                Conectar();
                String sql = "DELETE FROM gp2_colaboradores WHERE id_projeto = @1 AND id_colaborador = @2";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@1", Program.id_projeto_atual);
                cmd.Parameters.AddWithValue("@2", IdColaborador);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu ao excluir!!!" + "\n\nMais detalhes: " + ex.Message, "Erro ao inserir imagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
                Banco.NewCommit();
            }
        }

        public static void InsereColaborador(int IdColoborador, int IdProjeto, bool IsAdm)
        {
            try
            {
                Conectar();
                String sql = "INSERT INTO gp2_colaboradores VALUES (@1, @2, @3)";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@1", IdColoborador);
                cmd.Parameters.AddWithValue("@2", IdProjeto);
                cmd.Parameters.AddWithValue("@3", IsAdm);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao adicionar!!!" + "\n\nMais detalhes: " + ex.Message, "Erro ao inserir imagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
                Banco.NewCommit();
            }
        }

        public static void AlteraColaborador(int IdColoborador, int IdProjeto, bool IsAdm)
        {
            try
            {
                Conectar();
                String sql = "UPDATE gp2_colaboradores SET colaborador_adm = @1 WHERE id_colaborador = @2 AND id_projeto = @3";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@1", IsAdm);
                cmd.Parameters.AddWithValue("@2", IdColoborador);
                cmd.Parameters.AddWithValue("@3", IdProjeto);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar!!!" + "\n\nMais detalhes: " + ex.Message, "Erro ao inserir imagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
                Banco.NewCommit();
            }
        }

        public static bool PodeGerenciar()
        {
            bool permissao = false;
            try
            {
                Conectar();
                String sql = "SELECT * FROM gp2_colaboradores WHERE id_projeto = @1 AND id_colaborador = @2 AND colaborador_ADM = TRUE ";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                List<object> param = new List<object>();
                param.Add(Program.id_projeto_atual);
                param.Add(Program.id_usuario);

                NpgsqlDataReader dr = Banco.Selecionar(sql, param);
                if (dr.Read())
                {
                    permissao = true;
                }
                else
                {
                    permissao = false;
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao iniciar gerenciamento!!!" + "\n\nMais detalhes: " + ex.Message, "Erro ao inserir imagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar(); 
            }
            return permissao;
        }
        public static void VerificaImagemPrincipal(int IdProjeto)
        {
            try
            {
                Conectar(); // Estabelece a conexão com o banco de dados

                // Verifica se há imagens com o IdProjeto especificado
                string sql = "SELECT COUNT(*) FROM gp2_imagens WHERE id_projeto = @IdProjeto";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@IdProjeto", IdProjeto);
                int countImagens = Convert.ToInt32(cmd.ExecuteScalar());

                if (countImagens == 0)
                {
                    // Não há imagens com esse IdProjeto, retorna
                    return;
                }

                // Verifica se há imagens com o IdProjeto e Imagem_principal = true
                sql = "SELECT COUNT(*) FROM gp2_imagens WHERE id_projeto = @IdProjeto AND imagem_principal = true";
                cmd.CommandText = sql;
                int countImagensPrincipais = Convert.ToInt32(cmd.ExecuteScalar());

                if (countImagensPrincipais == 0)
                {
                    // Não há imagens principais com esse IdProjeto, selecione a imagem com o menor Id_Imagem e atualize Imagem_principal para true
                    sql = "UPDATE gp2_imagens SET imagem_principal = true WHERE id_imagem = (SELECT id_imagem FROM gp2_imagens WHERE id_projeto = @IdProjeto ORDER BY id_imagem ASC LIMIT 1)";
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a imagem principal: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar(); // Fecha a conexão com o banco de dados
            }
        }
    } 
}


/*SELECT T1.data_criacao, T2.nome AS "criador", CAST(T1.data_atualizacao AS DATE), T3.nome AS "atualizador",
CAST(T1.porcentagem AS INT)
FROM gp2_projetos T1
INNER JOIN gp2_usuarios T2 ON T1.id_criador = T2.id_usuario
INNER JOIN gp2_usuarios T3 ON T1.atualizador = T3.id_usuario*/






        /*COISAS DO BICUDO
         * 
        //Executa uma query no banco de dados. (Sem retorno)
        // insert - update - delete

        //Executa uma query no banco de dados com parametros
        public static void executar(string sql, List<object> parametros)
        {
            try
            {
                //Conectar();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = cn;
                int i = 1;
                foreach (object parametro in parametros)
                    cmd.Parameters.AddWithValue(i++.ToString(), parametro);
                cmd.ExecuteNonQuery();
            }
            catch (NpgsqlException ex)
            {
                throw new ApplicationException(ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }



        //
        // Select retornando os dados em um DataTable
        public static DataTable SelecionarDataTable(string sql)
        {
            try
            {
                //Conectar();
                // Cria o objeto DataTable
                DataTable dt = new DataTable();
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (NpgsqlException ex)
            {
                throw new ApplicationException(ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }
        public static DataSet SelecionarDataSet(string sql)
        {
            try
            {
                //Conectar();
                // Cria o objeto DataSet
                DataSet ds = new DataSet();
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                da.Fill(ds);
                return ds;
            }
            catch (NpgsqlException ex)
            {
                throw new ApplicationException(ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }
        public static DataSet SelecionarDataSet(string tabela, string campos, string where = "", string orderBy = "")
        {
            try
            {
                //Conectar();
                // Cria o objeto DataSet
                DataSet ds = new DataSet();
                string sql = @"select " + campos + " from " + tabela;
                if (where != "")
                    sql += @" where " + where + " ";
                if (orderBy != "")
                    sql += @" order by " + orderBy + " ";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                da.Fill(ds, tabela);
                return ds;
            }
            catch (NpgsqlException ex)
            {
                throw new ApplicationException(ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }
        */


