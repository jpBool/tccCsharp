using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
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
    }
}
