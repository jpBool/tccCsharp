﻿using System;
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