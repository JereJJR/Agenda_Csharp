namespace AgendaContatos_CRUD_
{
    partial class FormInicio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            this.BTTlogin = new System.Windows.Forms.Button();
            this.LKcadastro = new System.Windows.Forms.LinkLabel();
            this.TXTsenha = new System.Windows.Forms.TextBox();
            this.TXTemail = new System.Windows.Forms.TextBox();
            this.LBemail = new System.Windows.Forms.Label();
            this.LBsenha = new System.Windows.Forms.Label();
            this.GBlogin = new System.Windows.Forms.GroupBox();
            this.GBcadastro = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTnomeCad = new System.Windows.Forms.TextBox();
            this.TXTtelCad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BTTcancelar = new System.Windows.Forms.Button();
            this.TXTemailCad = new System.Windows.Forms.TextBox();
            this.LBsenhaCad = new System.Windows.Forms.Label();
            this.TXTsenhaCad = new System.Windows.Forms.TextBox();
            this.BTTcadastro = new System.Windows.Forms.Button();
            this.LBemailCad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTTinfor = new System.Windows.Forms.PictureBox();
            this.GBlogin.SuspendLayout();
            this.GBcadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BTTinfor)).BeginInit();
            this.SuspendLayout();
            // 
            // BTTlogin
            // 
            this.BTTlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTTlogin.Location = new System.Drawing.Point(34, 180);
            this.BTTlogin.Name = "BTTlogin";
            this.BTTlogin.Size = new System.Drawing.Size(186, 32);
            this.BTTlogin.TabIndex = 0;
            this.BTTlogin.Text = "Login";
            this.BTTlogin.UseVisualStyleBackColor = true;
            this.BTTlogin.Click += new System.EventHandler(this.BTTlogin_Click);
            // 
            // LKcadastro
            // 
            this.LKcadastro.AutoSize = true;
            this.LKcadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LKcadastro.Location = new System.Drawing.Point(12, 287);
            this.LKcadastro.Name = "LKcadastro";
            this.LKcadastro.Size = new System.Drawing.Size(197, 15);
            this.LKcadastro.TabIndex = 1;
            this.LKcadastro.TabStop = true;
            this.LKcadastro.Text = "Não tem cadastro? CADASTRE-SE";
            this.LKcadastro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LKcadastro_LinkClicked);
            // 
            // TXTsenha
            // 
            this.TXTsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTsenha.Location = new System.Drawing.Point(83, 145);
            this.TXTsenha.Name = "TXTsenha";
            this.TXTsenha.PasswordChar = '*';
            this.TXTsenha.Size = new System.Drawing.Size(100, 26);
            this.TXTsenha.TabIndex = 2;
            // 
            // TXTemail
            // 
            this.TXTemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTemail.Location = new System.Drawing.Point(20, 84);
            this.TXTemail.Name = "TXTemail";
            this.TXTemail.Size = new System.Drawing.Size(217, 24);
            this.TXTemail.TabIndex = 3;
            // 
            // LBemail
            // 
            this.LBemail.AutoSize = true;
            this.LBemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBemail.Location = new System.Drawing.Point(105, 58);
            this.LBemail.Name = "LBemail";
            this.LBemail.Size = new System.Drawing.Size(48, 20);
            this.LBemail.TabIndex = 5;
            this.LBemail.Text = "Email";
            // 
            // LBsenha
            // 
            this.LBsenha.AutoSize = true;
            this.LBsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBsenha.Location = new System.Drawing.Point(102, 122);
            this.LBsenha.Name = "LBsenha";
            this.LBsenha.Size = new System.Drawing.Size(56, 20);
            this.LBsenha.TabIndex = 6;
            this.LBsenha.Text = "Senha";
            // 
            // GBlogin
            // 
            this.GBlogin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.GBlogin.Controls.Add(this.label2);
            this.GBlogin.Controls.Add(this.TXTemail);
            this.GBlogin.Controls.Add(this.LBsenha);
            this.GBlogin.Controls.Add(this.TXTsenha);
            this.GBlogin.Controls.Add(this.BTTlogin);
            this.GBlogin.Controls.Add(this.LBemail);
            this.GBlogin.Location = new System.Drawing.Point(128, 12);
            this.GBlogin.Name = "GBlogin";
            this.GBlogin.Size = new System.Drawing.Size(256, 223);
            this.GBlogin.TabIndex = 7;
            this.GBlogin.TabStop = false;
            this.GBlogin.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // GBcadastro
            // 
            this.GBcadastro.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.GBcadastro.Controls.Add(this.label1);
            this.GBcadastro.Controls.Add(this.label3);
            this.GBcadastro.Controls.Add(this.TXTnomeCad);
            this.GBcadastro.Controls.Add(this.TXTtelCad);
            this.GBcadastro.Controls.Add(this.label4);
            this.GBcadastro.Controls.Add(this.BTTcancelar);
            this.GBcadastro.Controls.Add(this.TXTemailCad);
            this.GBcadastro.Controls.Add(this.LBsenhaCad);
            this.GBcadastro.Controls.Add(this.TXTsenhaCad);
            this.GBcadastro.Controls.Add(this.BTTcadastro);
            this.GBcadastro.Controls.Add(this.LBemailCad);
            this.GBcadastro.Location = new System.Drawing.Point(15, 12);
            this.GBcadastro.Name = "GBcadastro";
            this.GBcadastro.Size = new System.Drawing.Size(500, 223);
            this.GBcadastro.TabIndex = 8;
            this.GBcadastro.TabStop = false;
            this.GBcadastro.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nome";
            // 
            // TXTnomeCad
            // 
            this.TXTnomeCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTnomeCad.Location = new System.Drawing.Point(124, 52);
            this.TXTnomeCad.Name = "TXTnomeCad";
            this.TXTnomeCad.Size = new System.Drawing.Size(308, 26);
            this.TXTnomeCad.TabIndex = 16;
            // 
            // TXTtelCad
            // 
            this.TXTtelCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTtelCad.Location = new System.Drawing.Point(332, 87);
            this.TXTtelCad.Name = "TXTtelCad";
            this.TXTtelCad.Size = new System.Drawing.Size(100, 26);
            this.TXTtelCad.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(255, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Telefone";
            // 
            // BTTcancelar
            // 
            this.BTTcancelar.BackColor = System.Drawing.Color.Red;
            this.BTTcancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTTcancelar.Location = new System.Drawing.Point(324, 180);
            this.BTTcancelar.Name = "BTTcancelar";
            this.BTTcancelar.Size = new System.Drawing.Size(75, 26);
            this.BTTcancelar.TabIndex = 11;
            this.BTTcancelar.Text = "Cancelar";
            this.BTTcancelar.UseVisualStyleBackColor = false;
            this.BTTcancelar.Click += new System.EventHandler(this.button3_Click);
            // 
            // TXTemailCad
            // 
            this.TXTemailCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTemailCad.Location = new System.Drawing.Point(124, 136);
            this.TXTemailCad.Name = "TXTemailCad";
            this.TXTemailCad.Size = new System.Drawing.Size(308, 26);
            this.TXTemailCad.TabIndex = 3;
            // 
            // LBsenhaCad
            // 
            this.LBsenhaCad.AutoSize = true;
            this.LBsenhaCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBsenhaCad.Location = new System.Drawing.Point(54, 93);
            this.LBsenhaCad.Name = "LBsenhaCad";
            this.LBsenhaCad.Size = new System.Drawing.Size(56, 20);
            this.LBsenhaCad.TabIndex = 6;
            this.LBsenhaCad.Text = "Senha";
            // 
            // TXTsenhaCad
            // 
            this.TXTsenhaCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTsenhaCad.Location = new System.Drawing.Point(124, 90);
            this.TXTsenhaCad.Name = "TXTsenhaCad";
            this.TXTsenhaCad.PasswordChar = '*';
            this.TXTsenhaCad.Size = new System.Drawing.Size(100, 26);
            this.TXTsenhaCad.TabIndex = 2;
            // 
            // BTTcadastro
            // 
            this.BTTcadastro.Location = new System.Drawing.Point(130, 175);
            this.BTTcadastro.Name = "BTTcadastro";
            this.BTTcadastro.Size = new System.Drawing.Size(75, 37);
            this.BTTcadastro.TabIndex = 0;
            this.BTTcadastro.Text = "Cadastre-se";
            this.BTTcadastro.UseVisualStyleBackColor = true;
            this.BTTcadastro.Click += new System.EventHandler(this.button2_Click);
            // 
            // LBemailCad
            // 
            this.LBemailCad.AutoSize = true;
            this.LBemailCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBemailCad.Location = new System.Drawing.Point(62, 139);
            this.LBemailCad.Name = "LBemailCad";
            this.LBemailCad.Size = new System.Drawing.Size(48, 20);
            this.LBemailCad.TabIndex = 5;
            this.LBemailCad.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Cadastre-se";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Faça seu acesso aqui!!";
            // 
            // BTTinfor
            // 
            this.BTTinfor.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BTTinfor.Image = ((System.Drawing.Image)(resources.GetObject("BTTinfor.Image")));
            this.BTTinfor.Location = new System.Drawing.Point(481, 265);
            this.BTTinfor.Name = "BTTinfor";
            this.BTTinfor.Size = new System.Drawing.Size(34, 34);
            this.BTTinfor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BTTinfor.TabIndex = 11;
            this.BTTinfor.TabStop = false;
            this.BTTinfor.Click += new System.EventHandler(this.BTTinfor_Click);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(527, 311);
            this.Controls.Add(this.BTTinfor);
            this.Controls.Add(this.LKcadastro);
            this.Controls.Add(this.GBlogin);
            this.Controls.Add(this.GBcadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faça seu Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLogin_FormClosed);
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.GBlogin.ResumeLayout(false);
            this.GBlogin.PerformLayout();
            this.GBcadastro.ResumeLayout(false);
            this.GBcadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BTTinfor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTTlogin;
        private System.Windows.Forms.LinkLabel LKcadastro;
        private System.Windows.Forms.TextBox TXTsenha;
        private System.Windows.Forms.TextBox TXTemail;
        private System.Windows.Forms.Label LBemail;
        private System.Windows.Forms.Label LBsenha;
        private System.Windows.Forms.GroupBox GBlogin;
        private System.Windows.Forms.GroupBox GBcadastro;
        private System.Windows.Forms.Button BTTcancelar;
        private System.Windows.Forms.TextBox TXTemailCad;
        private System.Windows.Forms.Label LBsenhaCad;
        private System.Windows.Forms.TextBox TXTsenhaCad;
        private System.Windows.Forms.Button BTTcadastro;
        private System.Windows.Forms.Label LBemailCad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTnomeCad;
        private System.Windows.Forms.TextBox TXTtelCad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.PictureBox BTTinfor;
    }
}

