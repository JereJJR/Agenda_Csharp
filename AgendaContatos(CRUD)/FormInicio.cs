using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgendaContatos_CRUD_.Properties;


namespace AgendaContatos_CRUD_
{
    
    public partial class FormInicio : Form
    {
        public string nome;
        public string email;
        public int senha;
        public string telefone;
        public bool login_ok;

        //public bool login_ok { get; private set; }

        //public bool Login_ok ;

        public FormInicio()           
        {
            InitializeComponent();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LKcadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GBcadastro.Visible = true;

            TXTemailCad.Text = TXTemail.Text;
            TXTsenhaCad.Text = TXTsenha.Text;

            Text = "Cadastre-se";

            GBlogin.Visible = false;
            LKcadastro.Visible = false;

            TXTemail.Clear();
            TXTsenha.Clear();

            //Declara string
            
    }

        private void button3_Click(object sender, EventArgs e)
        {
            GBcadastro.Visible = false;
            TXTemailCad.Clear();
            TXTnomeCad.Clear();
            TXTsenhaCad.Clear();
            TXTtelCad.Clear();

            GBlogin.Visible = true;
            LKcadastro.Visible = true;

            Text = "Faça seu Login";
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if ((TXTemailCad.Text == "") || (TXTsenhaCad.Text == ""))
            {
                MessageBox.Show("Campos não podem ficar em BRANCO");
            }
            else
            {
                ClassComandos cc = new ClassComandos();
                cc.BuscaUsuario(email);
                if (Globais.consulta_ok == true)
                {
                    MessageBox.Show("Email JÁ CADASTRADO");
                }
                else
                {
                    nome = TXTnomeCad.Text;
                    email = TXTemailCad.Text;
                    senha = Convert.ToInt32(TXTsenhaCad.Text);
                    telefone = TXTtelCad.Text;

                    cc.cadastra(email, senha, nome, telefone);
                    if (Globais.cad_ok == true)
                    {
                        MessageBox.Show("Cadastro REALIZADO");
                        GBcadastro.Visible = false;
                        TXTemailCad.Clear();
                        TXTnomeCad.Clear();
                        TXTsenhaCad.Clear();
                        TXTtelCad.Clear();

                        GBlogin.Visible = true;
                        LKcadastro.Visible = true;
                        Text = "Faça seu Login";
                    }
                    else
                    {
                        MessageBox.Show("Usuario incorreto");
                    }
                }
                

            }
        }

        private void BTTlogin_Click(object sender, EventArgs e)
        {
            if ((TXTemail.Text == "") || (TXTsenha.Text == ""))
            {
                MessageBox.Show("Campos não podem ficar em BRANCO");
            }
            else
            {
                email = TXTemail.Text;
                senha = Convert.ToInt32(TXTsenha.Text);
                ClassComandos cc = new ClassComandos();
                cc.entrar(email, senha);
                if (Globais.login_ok == true)
                {
                    this.Hide();
                    FormConsulta consulta = new FormConsulta();
                    consulta.Show();
                    
                }
                else
                {
                    MessageBox.Show("SENHA OU USUARIO INCORRETO");
                }
            }
           

            
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {           
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BTTinfor_Click(object sender, EventArgs e)
        {
            String VersaoDessePrograma = Application.ProductVersion;
            MessageBox.Show("Versão do sistema: " + VersaoDessePrograma + "\n\n Developed by Jeremias", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
