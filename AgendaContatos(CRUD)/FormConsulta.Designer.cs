namespace AgendaContatos_CRUD_
{
    partial class FormConsulta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsulta));
            this.TXTbuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTTbuscar = new System.Windows.Forms.Button();
            this.GBatualiza = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTnomeCad = new System.Windows.Forms.TextBox();
            this.TXTtelCad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BTTcancelar = new System.Windows.Forms.Button();
            this.TXTemailCad = new System.Windows.Forms.TextBox();
            this.LBsenhaCad = new System.Windows.Forms.Label();
            this.TXTsenhaCad = new System.Windows.Forms.TextBox();
            this.BTTatualizar = new System.Windows.Forms.Button();
            this.LBemailCad = new System.Windows.Forms.Label();
            this.BTTlogout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BTTinfor = new System.Windows.Forms.PictureBox();
            this.GBatualiza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BTTinfor)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTbuscar
            // 
            this.TXTbuscar.Location = new System.Drawing.Point(96, 14);
            this.TXTbuscar.Name = "TXTbuscar";
            this.TXTbuscar.Size = new System.Drawing.Size(322, 20);
            this.TXTbuscar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar por email";
            // 
            // BTTbuscar
            // 
            this.BTTbuscar.Location = new System.Drawing.Point(424, 12);
            this.BTTbuscar.Name = "BTTbuscar";
            this.BTTbuscar.Size = new System.Drawing.Size(75, 23);
            this.BTTbuscar.TabIndex = 2;
            this.BTTbuscar.Text = "Buscar ";
            this.BTTbuscar.UseVisualStyleBackColor = true;
            this.BTTbuscar.Click += new System.EventHandler(this.BTTbuscar_Click);
            // 
            // GBatualiza
            // 
            this.GBatualiza.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.GBatualiza.Controls.Add(this.label2);
            this.GBatualiza.Controls.Add(this.button1);
            this.GBatualiza.Controls.Add(this.label3);
            this.GBatualiza.Controls.Add(this.TXTnomeCad);
            this.GBatualiza.Controls.Add(this.TXTtelCad);
            this.GBatualiza.Controls.Add(this.label4);
            this.GBatualiza.Controls.Add(this.BTTcancelar);
            this.GBatualiza.Controls.Add(this.TXTemailCad);
            this.GBatualiza.Controls.Add(this.LBsenhaCad);
            this.GBatualiza.Controls.Add(this.TXTsenhaCad);
            this.GBatualiza.Controls.Add(this.BTTatualizar);
            this.GBatualiza.Controls.Add(this.LBemailCad);
            this.GBatualiza.Location = new System.Drawing.Point(16, 60);
            this.GBatualiza.Name = "GBatualiza";
            this.GBatualiza.Size = new System.Drawing.Size(476, 204);
            this.GBatualiza.TabIndex = 3;
            this.GBatualiza.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "Nome";
            // 
            // TXTnomeCad
            // 
            this.TXTnomeCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTnomeCad.Location = new System.Drawing.Point(112, 60);
            this.TXTnomeCad.Name = "TXTnomeCad";
            this.TXTnomeCad.Size = new System.Drawing.Size(100, 24);
            this.TXTnomeCad.TabIndex = 26;
            // 
            // TXTtelCad
            // 
            this.TXTtelCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTtelCad.Location = new System.Drawing.Point(112, 109);
            this.TXTtelCad.Name = "TXTtelCad";
            this.TXTtelCad.Size = new System.Drawing.Size(100, 24);
            this.TXTtelCad.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "Telefone";
            // 
            // BTTcancelar
            // 
            this.BTTcancelar.BackColor = System.Drawing.Color.Red;
            this.BTTcancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTTcancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTTcancelar.Location = new System.Drawing.Point(442, 17);
            this.BTTcancelar.Name = "BTTcancelar";
            this.BTTcancelar.Size = new System.Drawing.Size(26, 181);
            this.BTTcancelar.TabIndex = 23;
            this.BTTcancelar.Text = "Cancelar";
            this.BTTcancelar.UseVisualStyleBackColor = false;
            this.BTTcancelar.Click += new System.EventHandler(this.BTTcancelar_Click);
            // 
            // TXTemailCad
            // 
            this.TXTemailCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTemailCad.Location = new System.Drawing.Point(302, 57);
            this.TXTemailCad.Name = "TXTemailCad";
            this.TXTemailCad.Size = new System.Drawing.Size(100, 24);
            this.TXTemailCad.TabIndex = 20;
            // 
            // LBsenhaCad
            // 
            this.LBsenhaCad.AutoSize = true;
            this.LBsenhaCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBsenhaCad.Location = new System.Drawing.Point(246, 109);
            this.LBsenhaCad.Name = "LBsenhaCad";
            this.LBsenhaCad.Size = new System.Drawing.Size(50, 18);
            this.LBsenhaCad.TabIndex = 22;
            this.LBsenhaCad.Text = "Senha";
            // 
            // TXTsenhaCad
            // 
            this.TXTsenhaCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTsenhaCad.Location = new System.Drawing.Point(302, 106);
            this.TXTsenhaCad.Name = "TXTsenhaCad";
            this.TXTsenhaCad.PasswordChar = '*';
            this.TXTsenhaCad.Size = new System.Drawing.Size(100, 24);
            this.TXTsenhaCad.TabIndex = 19;
            // 
            // BTTatualizar
            // 
            this.BTTatualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTTatualizar.Location = new System.Drawing.Point(122, 148);
            this.BTTatualizar.Name = "BTTatualizar";
            this.BTTatualizar.Size = new System.Drawing.Size(86, 46);
            this.BTTatualizar.TabIndex = 18;
            this.BTTatualizar.Text = "Atualizar";
            this.BTTatualizar.UseVisualStyleBackColor = true;
            this.BTTatualizar.Click += new System.EventHandler(this.BTTatualizar_Click);
            // 
            // LBemailCad
            // 
            this.LBemailCad.AutoSize = true;
            this.LBemailCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBemailCad.Location = new System.Drawing.Point(251, 60);
            this.LBemailCad.Name = "LBemailCad";
            this.LBemailCad.Size = new System.Drawing.Size(45, 18);
            this.LBemailCad.TabIndex = 21;
            this.LBemailCad.Text = "Email";
            // 
            // BTTlogout
            // 
            this.BTTlogout.BackColor = System.Drawing.Color.Black;
            this.BTTlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTTlogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTTlogout.Location = new System.Drawing.Point(96, 277);
            this.BTTlogout.Name = "BTTlogout";
            this.BTTlogout.Size = new System.Drawing.Size(296, 27);
            this.BTTlogout.TabIndex = 24;
            this.BTTlogout.Text = "Logout";
            this.BTTlogout.UseVisualStyleBackColor = false;
            this.BTTlogout.Click += new System.EventHandler(this.BTTlogout_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(329, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 34);
            this.button1.TabIndex = 28;
            this.button1.Text = "Deletar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "Atualize ou delete o cadastro!!";
            // 
            // BTTinfor
            // 
            this.BTTinfor.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BTTinfor.Image = ((System.Drawing.Image)(resources.GetObject("BTTinfor.Image")));
            this.BTTinfor.Location = new System.Drawing.Point(458, 270);
            this.BTTinfor.Name = "BTTinfor";
            this.BTTinfor.Size = new System.Drawing.Size(34, 34);
            this.BTTinfor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BTTinfor.TabIndex = 25;
            this.BTTinfor.TabStop = false;
            this.BTTinfor.Click += new System.EventHandler(this.BTTinfor_Click);
            // 
            // FormConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(504, 316);
            this.Controls.Add(this.BTTinfor);
            this.Controls.Add(this.BTTlogout);
            this.Controls.Add(this.GBatualiza);
            this.Controls.Add(this.BTTbuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTbuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualize ou delete o cadastro!!";
            this.Load += new System.EventHandler(this.FormConsulta_Load);
            this.GBatualiza.ResumeLayout(false);
            this.GBatualiza.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BTTinfor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTbuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTTbuscar;
        private System.Windows.Forms.GroupBox GBatualiza;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTnomeCad;
        private System.Windows.Forms.TextBox TXTtelCad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTTcancelar;
        private System.Windows.Forms.TextBox TXTemailCad;
        private System.Windows.Forms.Label LBsenhaCad;
        private System.Windows.Forms.TextBox TXTsenhaCad;
        private System.Windows.Forms.Button BTTatualizar;
        private System.Windows.Forms.Label LBemailCad;
        private System.Windows.Forms.Button BTTlogout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.PictureBox BTTinfor;
    }
}