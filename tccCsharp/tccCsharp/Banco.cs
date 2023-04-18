using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Npgsql;


namespace tccCsharp
{
    internal class Banco
    {
        static string stringConexao = "Server = pgsql.projetoscti.com.br; " +
                                      "Database = projetoscti9; Port=5432;" +
                                      "User ID= projetoscti9; password = eq273b294;";
        static NpgsqlConnection cn;

        public static void conectar()
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
        public static void desconectar()
        {
            cn.Close();// fecha a conexão com o banco de dados
            cn.Dispose(); // libera os recursos utilizados
            cn = null;
        }

        //Select com parametros retornando um DataReader
        public static NpgsqlDataReader selecionar(string sql, List<object> parametros)
        {
            try
            {
                conectar();
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
                desconectar();
                throw new ApplicationException(ex.Message);
            }
        }

        public static int logar(string email, string senha)
        {
            string sql;
            try
            {
                sql = "select id_usuario,nome from gp2_usuarios ";
                sql += " where email = @1 and senha = @2 and excluido = false";

                List<object> param = new List<object>();
                param.Add(email);
                param.Add(senha);

                NpgsqlDataReader dr = Banco.selecionar(sql, param);
                if (dr.Read())
                {
                    MessageBox.Show("Bom dia " + dr["nome"].ToString() + " !!! Acesso autorizado ao sistema !!!");
                    int id = Convert.ToInt32(dr["id_usuario"]);
                    dr.Close();
                    return id;                   
                }
                else
                {
                    MessageBox.Show("E-mail ou Senha Incorreto(s), verifique !!!","Login do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dr.Close();
                    return 0;
                    
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao logar no sistema !!!" + "\n\nMais detalhes: " + ex.Message,"Login do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
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


                NpgsqlDataReader dr = Banco.selecionar(sql, param);
                dr.Read();
                usuario.nome = dr["nome"].ToString();
                usuario.bio = dr["bio"].ToString();
                usuario.avatar = Convert.ToInt32(dr["avatar"]);
                usuario.naturalidade = dr["naturalidade"].ToString();
                usuario.nascimento = Convert.ToDateTime(dr["nascimento"]);
                usuario.inscricao = Convert.ToDateTime(dr["inscricao"]);
                usuario.email = dr["email"].ToString();
                usuario.telefone = dr["telefone"].ToString();
                usuario.commits = Convert.ToInt32(dr["commits"]);
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar as informações do usuário !!!" + "\n\nMais detalhes: " + ex.Message, "Login do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return usuario;
        }

        public static List<Project> CarregarProjetos(List<Project> projetos)
        {
            string sql;
            try
            {
                sql = "select id_projeto, id_criador, autores, email_contato, nome_projeto, palavras_chave, publico, descricao_breve, descricao_detalhada, link_site, link_youtube, status, porcentagem, imagem, data_criacao, data_atualizacao, atualizador, excluido, linguagem, previsao from gp2_projetos where id_criador = @1 and excluido = false order by data_criacao ASC";

                
                List<object> param = new List<object>();
                param.Add(Program.id_usuario);
               
                NpgsqlDataReader dr = Banco.selecionar(sql, param);
                
              
                    while(dr.Read())
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
                            
                        if (dr["imagem"] != DBNull.Value)
                            linha.imagem = dr["imagem"].ToString();
                        
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

                        projetos.Add(linha);
                    };
                    dr.Close();
                    return projetos;       
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar seus projetos!!!" + "\n\nMais detalhes: " + ex.Message, "Erro ao carregar projetos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return projetos;
            }
        }














        /*COISAS DO BICUDO
         * 
        //Executa uma query no banco de dados. (Sem retorno)
        // insert - update - delete
        public static void executar(string sql)
        {
            try
            {
                conectar();
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                cmd.ExecuteNonQuery();
            }
            catch (NpgsqlException ex)
            {
                throw new ApplicationException(ex.Message);
            }
            finally
            {
                desconectar();
            }
        }
        //Executa uma query no banco de dados com parametros
        public static void executar(string sql, List<object> parametros)
        {
            try
            {
                conectar();
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
                desconectar();
            }
        }


        //Select simples retornando um DataReader
        public static NpgsqlDataReader selecionar(string sql)
        {
            try
            {
                conectar();
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (NpgsqlException ex)
            {
                desconectar();
                throw new ApplicationException(ex.Message);
            }
        }
        //
        // Select retornando os dados em um DataTable
        public static DataTable selecionarDataTable(string sql)
        {
            try
            {
                conectar();
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
                desconectar();
            }
        }
        public static DataSet selecionarDataSet(string sql)
        {
            try
            {
                conectar();
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
                desconectar();
            }
        }
        public static DataSet selecionarDataSet(string tabela, string campos, string where = "", string orderBy = "")
        {
            try
            {
                conectar();
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
                desconectar();
            }
        }
        */
    }
}
