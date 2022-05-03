using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
   

namespace AgendaContatos_CRUD_
{
    class ClassComandos
    {
        public string nome;
        public string email;
        public string senha;
        public string telefone;
        public string usuarioBD;
        public int senhaBD;
        public string nomeBD;
        public string telBD;
        public int idBD;


        public void entrar(string email, int senha)
        {
            Globais.login_ok = true;

            Conexao cx = new Conexao();
            cx.conecta();
            
            SqlDataReader dr = null;
            SqlCommand cmd = new SqlCommand("SELECT * FROM TB_agenda WHERE email = '"+email+"' and senha = "+senha , cx.conn);
            try
            {
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())

                    {
                        usuarioBD = (string)dr["email"];
                        senhaBD = (int)dr["senha"];
                        nomeBD = (string)dr["nome"];
                        telBD = (string)dr["telefone"];
                        idBD = (int)dr["id"];

                        if ((email == usuarioBD) && (senha == senhaBD))
                        {
                            Globais.login_ok = true;
                            Globais.usuarioBD = usuarioBD;
                            Globais.nomeBD = nomeBD;
                            Globais.senhaBD  = senhaBD;
                            Globais.telBD = telBD;
                            Globais.idBD = idBD;
                        }
                    }
                }
                else
                {
                    Globais.login_ok = false;               
                }               
            }
            catch (Exception ex)
            {                
                Console.WriteLine("ERROR" + ex);
            }
               
        }


        public void cadastra(string email, int senha, string nome, string telefone)
        {

            Conexao cx = new Conexao();

            SqlDataReader dr = null;
            SqlCommand cmd = new SqlCommand("INSERT INTO TB_agenda(nome,email,senha,telefone) VALUES ('" + nome + "', '" + email + "', '" + senha + "', '" + telefone + "')", cx.conn);
            try
            {
                cx.conecta();
                dr = cmd.ExecuteReader();
                Globais.cad_ok = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR" + ex);
            }
        }

        public void ataualiza(string email, int senha, string nome, string telefone)
        {
            Conexao cx = new Conexao();
            string sql = "";

            SqlDataReader dr = null;
            SqlCommand cmd = new SqlCommand("UPDATE TB_agenda SET nome = '" + nome + "',email = '" + email + "',senha ='" + senha + "',telefone = '" + telefone + "' WHERE id = '" + Globais.idBD +"'", cx.conn);

            try
            {
                cx.conecta();
                dr = cmd.ExecuteReader();
                Globais.update_ok = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR" + ex);
            }
        }


        public void deletaUsuario()
        {
            Conexao cx = new Conexao();
            SqlDataReader dr = null;
            SqlCommand cmd = new SqlCommand("DELETE TB_agenda WHERE id = '" + Globais.idBD + "'", cx.conn);

            try
            {
                cx.conecta();
                dr = cmd.ExecuteReader();
                Globais.deleta_ok = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR" + ex);
            }
        }



        public void BuscaUsuario(string email)
        {
            
            Conexao cx = new Conexao();
            cx.conecta();

            SqlDataReader dr = null;
            SqlCommand cmd = new SqlCommand("SELECT * FROM TB_agenda WHERE email = '" + email+"'" , cx.conn);
            try
            {
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())

                    {
                        usuarioBD = (string)dr["email"];
                        senhaBD = (int)dr["senha"];
                        nomeBD = (string)dr["nome"];
                        telBD = (string)dr["telefone"];
                        idBD = (int)dr["id"];

                        if (email == usuarioBD)
                        {
                            Globais.consulta_ok = true;
                            Globais.usuarioBD = usuarioBD;
                            Globais.nomeBD = nomeBD;
                            Globais.senhaBD = senhaBD;
                            Globais.telBD = telBD;
                            Globais.idBD = idBD;
                        }
                    }
                }
                else
                {
                    Globais.consulta_ok = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR" + ex);
            }

        }
        
    }
}
