using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaContatos_CRUD_
{
    public partial class FormConsulta : Form
    {
        public string nome;
        public string email;
        public int senha;
        public string telefone;

        public FormConsulta()
        {
           
            InitializeComponent();
        }

        private void BTTcancelar_Click(object sender, EventArgs e)
        {
            TXTemailCad.Clear();
            TXTnomeCad.Clear();
            TXTsenhaCad.Clear();
            TXTtelCad.Clear();
            TXTbuscar.Clear();
        }

        private void BTTlogout_Click(object sender, EventArgs e)
        {
            TXTemailCad.Clear();
            TXTnomeCad.Clear();
            TXTsenhaCad.Clear();
            TXTtelCad.Clear();
            TXTbuscar.Clear();           
            FormInicio login = new FormInicio();
            login.Show();
            this.Close();
        }

        private void FormConsulta_Load(object sender, EventArgs e)
        {
            TXTemailCad.Text = Globais.usuarioBD;
            TXTnomeCad.Text = Globais.nomeBD;
            TXTsenhaCad.Text = Convert.ToString(Globais.senhaBD);
            TXTtelCad.Text = Globais.telBD;

        }

        private void BTTatualizar_Click(object sender, EventArgs e)
        {
            if ((TXTemailCad.Text == "") || (TXTsenhaCad.Text == ""))
            {
                MessageBox.Show("Campos não podem ficar em BRANCO");
            }
            else
            {
                nome = TXTnomeCad.Text;
                email = TXTemailCad.Text;
                senha = Convert.ToInt32(TXTsenhaCad.Text);
                telefone = TXTtelCad.Text;
                ClassComandos cc = new ClassComandos();
                cc.ataualiza(email, senha, nome, telefone);
                if (Globais.update_ok == true)
                {
                    MessageBox.Show("Cadastro atualizado");
                    TXTemailCad.Clear();
                    TXTnomeCad.Clear();
                    TXTsenhaCad.Clear();
                    TXTtelCad.Clear();


                }
                else
                {
                    MessageBox.Show("Usuario incorreto");
                }
            }
        }

        private void BTTbuscar_Click(object sender, EventArgs e)
        {
            if (TXTbuscar.Text == "")
            {
                MessageBox.Show("Campo de busca em BRANCO");
            }
            else
            {                
                email = TXTbuscar.Text;                
                ClassComandos cc = new ClassComandos();
                cc.BuscaUsuario(email);
                if (Globais.consulta_ok == true)
                {
                    //Limpa textbox
                    TXTemailCad.Text = "";
                    TXTnomeCad.Text = "";
                    TXTsenhaCad.Text = "";
                    TXTtelCad.Text = "";
                    TXTbuscar.Text = "";
                    //Escreve textbox
                    TXTemailCad.Text = Globais.usuarioBD;
                    TXTnomeCad.Text = Globais.nomeBD;
                    TXTsenhaCad.Text = Convert.ToString(Globais.senhaBD);
                    TXTtelCad.Text = Globais.telBD;                  

                }
                else
                {
                    MessageBox.Show("Email não encontrado");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Globais.idBD == 0 )
            {
                MessageBox.Show("Id do usuario não encontrado");
            }
            else if ((TXTemailCad.Text == "") || (TXTsenhaCad.Text == ""))
            {
                MessageBox.Show("Campos não podem ficar em BRANCO");
            }
            
            else
            {
                nome = TXTnomeCad.Text;
                email = TXTemailCad.Text;
                senha = Convert.ToInt32(TXTsenhaCad.Text);
                telefone = TXTtelCad.Text;
                ClassComandos cc = new ClassComandos();
                cc.deletaUsuario();
                if (Globais.deleta_ok == true)
                {
                    MessageBox.Show("Cadastro DELETADO com sucesso!");
                    TXTemailCad.Clear();
                    TXTnomeCad.Clear();
                    TXTsenhaCad.Clear();
                    TXTtelCad.Clear();
                }
                else
                {
                    MessageBox.Show("Usuario incorreto");
                }
            }
        }

        private void BTTinfor_Click(object sender, EventArgs e)
        {
            String VersaoDessePrograma = Application.ProductVersion;
            MessageBox.Show("Versão do sistema: " + VersaoDessePrograma + "\n\n Developed by Jeremias", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
