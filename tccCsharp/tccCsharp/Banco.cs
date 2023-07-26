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

                if (dr["bio"] != DBNull.Value)
                    usuario.bio = dr["bio"].ToString();

                if (dr["avatar"] != DBNull.Value)
                    usuario.avatar = Convert.ToInt32(dr["avatar"]);

                if (dr["naturalidade"] != DBNull.Value)
                    usuario.naturalidade = dr["naturalidade"].ToString();

                if (dr["nascimento"] != DBNull.Value)
                    usuario.nascimento = Convert.ToDateTime(dr["nascimento"]);

                usuario.inscricao = Convert.ToDateTime(dr["inscricao"]);
                usuario.email = dr["email"].ToString();

                if (dr["telefone"] != DBNull.Value)
                    usuario.telefone = dr["telefone"].ToString();

                if (dr["commits"] != DBNull.Value)
                    usuario.commits = Convert.ToInt32(dr["commits"]);
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

                if (dr["autores"] != DBNull.Value)
                    selecionado.autores = dr["autores"].ToString();

                if (dr["email_contato"] != DBNull.Value)
                    selecionado.email_contato = dr["email_contato"].ToString();

                selecionado.nome_projeto = dr["nome_projeto"].ToString();

                if (dr["palavras_chave"] != DBNull.Value)
                    selecionado.palavras_chave = dr["palavras_chave"].ToString();

                if (dr["publico"] != DBNull.Value)
                    selecionado.publico = Convert.ToBoolean(dr["publico"]);
                else
                    selecionado.publico = false;

                selecionado.descricao_breve = dr["descricao_breve"].ToString();

                if (dr["descricao_detalhada"] != DBNull.Value)
                    selecionado.descricao_detalhada = dr["descricao_detalhada"].ToString();

                if (dr["link_site"] != DBNull.Value)
                    selecionado.link_site = dr["link_site"].ToString();

                if (dr["link_youtube"] != DBNull.Value)
                    selecionado.link_youtube = dr["link_youtube"].ToString();

                if (dr["status"] != DBNull.Value)
                    selecionado.status = Convert.ToInt32(dr["status"]);
                else
                    selecionado.status = 1;

                if (dr["porcentagem"] != DBNull.Value)
                    selecionado.porcentagem = Convert.ToDecimal(dr["porcentagem"]);
                else
                    selecionado.porcentagem = 0;

                selecionado.data_criacao = Convert.ToDateTime(dr["data_criacao"]);

                if (dr["data_atualizacao"] != DBNull.Value)
                    selecionado.data_atualizacao = Convert.ToDateTime(dr["data_atualizacao"]);

                if (dr["atualizador"] != DBNull.Value)
                    selecionado.atualizador = Convert.ToInt32(dr["atualizador"]);

                selecionado.excluido = Convert.ToBoolean(dr["excluido"]);

                if (dr["linguagem"] != DBNull.Value)
                    selecionado.linguagem = dr["linguagem"].ToString();

                if (dr["previsao"] != DBNull.Value)
                    selecionado.previsao = Convert.ToDateTime(dr["previsao"]);

                if (dr["num_grupos"] != DBNull.Value)
                    selecionado.numero_grupos = Convert.ToInt32(dr["num_grupos"]);

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

                    if (dr["autores"] != DBNull.Value)
                        linha.autores = dr["autores"].ToString();

                    if (dr["email_contato"] != DBNull.Value)
                        linha.email_contato = dr["email_contato"].ToString();

                    linha.nome_projeto = dr["nome_projeto"].ToString();

                    if (dr["palavras_chave"] != DBNull.Value)
                        linha.palavras_chave = dr["palavras_chave"].ToString();

                    if (dr["publico"] != DBNull.Value)
                        linha.publico = Convert.ToBoolean(dr["publico"]);
                    else
                        linha.publico = false;

                    linha.descricao_breve = dr["descricao_breve"].ToString();

                    if (dr["descricao_detalhada"] != DBNull.Value)
                        linha.descricao_detalhada = dr["descricao_detalhada"].ToString();

                    if (dr["link_site"] != DBNull.Value)
                        linha.link_site = dr["link_site"].ToString();

                    if (dr["link_youtube"] != DBNull.Value)
                        linha.link_youtube = dr["link_youtube"].ToString();

                    if (dr["status"] != DBNull.Value)
                        linha.status = Convert.ToInt32(dr["status"]);
                    else
                        linha.status = 1;

                    if (dr["porcentagem"] != DBNull.Value)
                        linha.porcentagem = Convert.ToDecimal(dr["porcentagem"]);
                    else
                        linha.porcentagem = 0;

                    linha.data_criacao = Convert.ToDateTime(dr["data_criacao"]);

                    if (dr["data_atualizacao"] != DBNull.Value)
                        linha.data_atualizacao = Convert.ToDateTime(dr["data_atualizacao"]);

                    if (dr["atualizador"] != DBNull.Value)
                        linha.atualizador = Convert.ToInt32(dr["atualizador"]);

                    linha.excluido = Convert.ToBoolean(dr["excluido"]);

                    if (dr["linguagem"] != DBNull.Value)
                        linha.linguagem = dr["linguagem"].ToString();

                    if (dr["previsao"] != DBNull.Value)
                        linha.previsao = Convert.ToDateTime(dr["previsao"]);

                    if (dr["num_grupos"] != DBNull.Value)
                        linha.numero_grupos = Convert.ToInt32(dr["num_grupos"]);

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
            string sql;

            List<Status> list = new List<Status>();

            try
            {
                sql = "SELECT id_status, status FROM gp2_status ORDER BY id_status ASC";

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
                sql = "SELECT G* FROM gp2_grupos_etapas G WHERE id_projeto = @1";
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
                    linha.numero_etapas = Convert.ToInt32(dr["numero_etapas"]);

                    string sql2;
                    sql2 = "SELECT E* FROM gp2_etapas E WHERE id_grupo = @1";
                    List<object> param2 = new List<object>();
                    param2.Add(linha.id_grupo);

                    NpgsqlDataReader dr2 = Banco.Selecionar(sql2, param2);
                    while (dr2.Read())
                    {
                        Step entrelinha = new Step();
                        entrelinha.id_etapa = Convert.ToInt32(dr2["id_etapa"]);
                        entrelinha.id_grupo = Convert.ToInt32(dr2["id_grupo"]);
                        entrelinha.nome_etapa = Convert.ToString(dr2["nome_etapa"]);
                        entrelinha.peso = Convert.ToInt32(dr2["peso"]);
                        entrelinha.porcentagem = Convert.ToDecimal(dr2["porcentagem"]);
                        
                        if (dr2["descricao_etapa"] != DBNull.Value)
                            entrelinha.descricao_etapa = Convert.ToString(dr2["descricao_etapa"]);

                        if (dr2["status"] != DBNull.Value)
                                entrelinha.status = Convert.ToInt32(dr2["status"]);




                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar esse projeto!!!" + "\n\nMais detalhes: " + ex.Message, "Erro ao carregar projetos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


