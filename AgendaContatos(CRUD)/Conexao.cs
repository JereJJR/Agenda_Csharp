using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace AgendaContatos_CRUD_
{
    class Conexao
    {
        public SqlConnection conn = new SqlConnection();     
        private static string database = "TesteJeremias";
        private static string server = @"NT-TI-03\SQLEXPRESS";     
        private string sql_conexao;
        private string status = "";

        public void conecta()
        {
            try
            {
                //sql_conexao = ("Server=" + server + ";Port=" + port + ";UserId=" + user + ";Password=" + password + ";Database=" + database + "");
                //sql_conexao = ("Server=" + server + ";Database=" + database + "; Integrated Security = True;");
                sql_conexao = (@"Data Source="+server+" ; Initial Catalog=" + database + ";Integrated Security = True");
               conn.ConnectionString = sql_conexao;
                conn.Open();
            }
            catch           
            {
                Console.Write("ERROR");
            }
          
        }
        public void desconecta()
        {
            try
            {
                conn.Close();
            status = ("Conexão fechada");
            }         
            catch
            {
                
            }
            
        }
       
       

    }
}
