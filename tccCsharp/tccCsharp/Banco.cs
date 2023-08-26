using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Npgsql;
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

        //Select simples retornando um DataReader
        public static NpgsqlDataReader Selecionar(string sql)
        {
            try
            {
                Conectar();
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (NpgsqlException ex)
            {
                Desconectar();
                throw new ApplicationException(ex.Message);
            }
        }

        public static int Logar(string email, string senha)
        {
            string sql;
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
                    //MessageBox.Show("Bom dia " + dr["nome"].ToString() + " !!! Acesso autorizado ao sistema !!!");
                    int id = Convert.ToInt32(dr["id_usuario"]);
                    dr.Close();
                    return id;
                }
                else
                {
                    //MessageBox.Show("E-mail ou Senha Incorreto(s), verifique !!!", "Login do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dr.Close();
                    return 0;
                }
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
                sql = "select id_projeto, id_criador, autores, email_contato, nome_projeto, palavras_chave, publico, descricao_breve, descricao_detalhada, link_site, link_youtube, status, porcentagem, data_criacao, data_atualizacao, atualizador, excluido, linguagem, previsao, num_grupos from gp2_projetos where id_criador = @1 and excluido = false order by data_criacao ASC";
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

        public static void AtulizarProjeto(Project Atualizar)
        {
            try
            {
                Conectar();
                String sql = "UPDATE gp2_projetos SET autores = @1, email_contato = @2, nome_projeto = @3, ";
                sql += "palavras_chave = @4, publico = @5, descricao_breve = @6, descricao_detalhada = @7, link_site = @8, ";
                sql += "link_youtube = @9, status = @10, porcentagem = @11, data_atualizacao = @12, atualizador = @13, ";
                sql += "linguagem = @14, previsao = @15 WHERE id_projeto = @16 ";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@1", String.IsNullOrEmpty(Atualizar.autores) ? (object)DBNull.Value : (object)Atualizar.autores);
                cmd.Parameters.AddWithValue("@2", String.IsNullOrEmpty(Atualizar.email_contato) ? (object)DBNull.Value : (object)Atualizar.email_contato);
                cmd.Parameters.AddWithValue("@3", Atualizar.nome_projeto);
                cmd.Parameters.AddWithValue("@4", String.IsNullOrEmpty(Atualizar.palavras_chave) ? (object)DBNull.Value : (object)Atualizar.palavras_chave);
                cmd.Parameters.AddWithValue("@5", Atualizar.publico);
                cmd.Parameters.AddWithValue("@6", Atualizar.descricao_breve);
                cmd.Parameters.AddWithValue("@7", String.IsNullOrEmpty(Atualizar.descricao_detalhada) ? (object)DBNull.Value : (object)Atualizar.descricao_detalhada);
                cmd.Parameters.AddWithValue("@8", String.IsNullOrEmpty(Atualizar.link_site) ? (object)DBNull.Value : (object)Atualizar.link_site);
                cmd.Parameters.AddWithValue("@9", String.IsNullOrEmpty(Atualizar.link_youtube) ? (object)DBNull.Value : (object)Atualizar.link_youtube);
                cmd.Parameters.AddWithValue("@10", (Atualizar.status == 0 ? (object)DBNull.Value : (object)Atualizar.status));
                cmd.Parameters.AddWithValue("@11", Atualizar.porcentagem);
                cmd.Parameters.AddWithValue("@12", Atualizar.data_atualizacao);
                cmd.Parameters.AddWithValue("@13", Atualizar.atualizador);
                cmd.Parameters.AddWithValue("@14", String.IsNullOrEmpty(Atualizar.linguagem) ? (object)DBNull.Value : (object)Atualizar.linguagem);
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
                cmd.Parameters.AddWithValue("@2", String.IsNullOrEmpty(Novo.autores) ? (object)DBNull.Value : (object)Novo.autores);
                cmd.Parameters.AddWithValue("@3", String.IsNullOrEmpty(Novo.email_contato) ? (object)DBNull.Value : (object)Novo.email_contato);
                cmd.Parameters.AddWithValue("@4", Novo.nome_projeto);
                cmd.Parameters.AddWithValue("@5", String.IsNullOrEmpty(Novo.palavras_chave) ? (object)DBNull.Value : (object)Novo.palavras_chave);
                cmd.Parameters.AddWithValue("@6", Novo.publico);
                cmd.Parameters.AddWithValue("@7", Novo.descricao_breve);
                cmd.Parameters.AddWithValue("@8", String.IsNullOrEmpty(Novo.descricao_detalhada) ? (object)DBNull.Value : (object)Novo.descricao_detalhada);
                cmd.Parameters.AddWithValue("@9", String.IsNullOrEmpty(Novo.link_site) ? (object)DBNull.Value : (object)Novo.link_site);
                cmd.Parameters.AddWithValue("@10", String.IsNullOrEmpty(Novo.link_youtube) ? (object)DBNull.Value : (object)Novo.link_youtube);
                cmd.Parameters.AddWithValue("@11", (Novo.status == 0 ? (object)DBNull.Value : (object)Novo.status));
                cmd.Parameters.AddWithValue("@12", Novo.porcentagem);
                cmd.Parameters.AddWithValue("@13", Novo.data_criacao);
                cmd.Parameters.AddWithValue("@14", Novo.data_atualizacao);
                cmd.Parameters.AddWithValue("@15", Novo.atualizador);
                cmd.Parameters.AddWithValue("@16", Novo.excluido);
                cmd.Parameters.AddWithValue("@17", String.IsNullOrEmpty(Novo.linguagem) ? (object)DBNull.Value : (object)Novo.linguagem);
                cmd.Parameters.AddWithValue("@18", Novo.previsao == new DateTime(1, 1, 1) ? (object)DBNull.Value : (object)Novo.previsao);
                cmd.Parameters.AddWithValue("@19", Novo.numero_grupos);

                idInserido = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Ocorreu um erro ao criar o projeto !!!" + "\n\nMais detalhes: " + ex.Message, "Criar Projeto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                idInserido = 0;
            }
            finally
            {
                Desconectar();
            }
            return idInserido;
        }

        public static List<Status> CarregaStatus()
        {
            string sql = "SELECT id_status, status FROM gp2_status ORDER BY id_status ASC"; ;
            List<Status> list = new List<Status>();
            try
            {
                NpgsqlDataReader dr = Banco.Selecionar(sql);
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
                String sql = "UPDATE gp2_usuarios	SET  commits = commits + 1 WHERE id_usuario = @1;";
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
                    linha.mostrar_porcentagem = Convert.ToBoolean(dr["porcentagem"]);
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
            }
            return idInserido;
        }

        public static void DeleteImagem(int Idimagem)
        {
            try
            {
                Conectar();
                String sql = "DELETE FROM gp2_imagens WHERE id_imagem = @1";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@1",Idimagem);
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
            try
            {
                Conectar();
                String sql = "UPDATE  gp2_imagens SET nome = @1, descricao_imagem = @2, imagem_principal = @3 WHERE id_imagem = @4";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@1", nome);
                cmd.Parameters.AddWithValue("@2", descri);
                cmd.Parameters.AddWithValue("@3", principal);
                cmd.Parameters.AddWithValue("@4", IdImagem);
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

        public static List<GroupSteps> ConsultaGrupos()
        {
            List<GroupSteps> grupos = new List<GroupSteps>();
            try
            {
                string sql;
                sql = "SELECT * FROM gp2_grupos_etapas WHERE id_projeto = @1 ORDER BY ordenador ASC";
                List<object> param = new List<object>();
                param.Add(Program.id_projeto_atual);

                NpgsqlDataReader dr = Banco.Selecionar(sql, param);
                while (dr.Read())
                {
                    GroupSteps linha = new GroupSteps();
                    linha.ordenador = Convert.ToInt32(dr["ordenador"]);
                    linha.nome_grupo = Convert.ToString(dr["nome_grupo"]);
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


