namespace MPJConstrucoesReformas
{
    partial class frmLogin
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
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.pctSenha = new System.Windows.Forms.PictureBox();
            this.pctUser = new System.Windows.Forms.PictureBox();
            this.pctFechar = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblLink = new System.Windows.Forms.LinkLabel();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.lblLink);
            this.pnlLogin.Controls.Add(this.pctSenha);
            this.pnlLogin.Controls.Add(this.txtSenha);
            this.pnlLogin.Controls.Add(this.lblSenha);
            this.pnlLogin.Controls.Add(this.txtUser);
            this.pnlLogin.Controls.Add(this.btnEntrar);
            this.pnlLogin.Controls.Add(this.pctUser);
            this.pnlLogin.Controls.Add(this.lblUser);
            this.pnlLogin.Controls.Add(this.pctLogo);
            this.pnlLogin.Location = new System.Drawing.Point(600, 192);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(250, 309);
            this.pnlLogin.TabIndex = 0;
            // 
            // pctLogo
            // 
            this.pctLogo.Image = global::MPJConstrucoesReformas.Properties.Resources.logo;
            this.pctLogo.Location = new System.Drawing.Point(28, 3);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(193, 93);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 0;
            this.pctLogo.TabStop = false;
            // 
            // pctSenha
            // 
            this.pctSenha.BackColor = System.Drawing.Color.White;
            this.pctSenha.Image = global::MPJConstrucoesReformas.Properties.Resources.senha;
            this.pctSenha.Location = new System.Drawing.Point(17, 192);
            this.pctSenha.Name = "pctSenha";
            this.pctSenha.Size = new System.Drawing.Size(35, 35);
            this.pctSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctSenha.TabIndex = 1;
            this.pctSenha.TabStop = false;
            // 
            // pctUser
            // 
            this.pctUser.BackColor = System.Drawing.Color.White;
            this.pctUser.Image = global::MPJConstrucoesReformas.Properties.Resources.usuario;
            this.pctUser.Location = new System.Drawing.Point(17, 129);
            this.pctUser.Name = "pctUser";
            this.pctUser.Size = new System.Drawing.Size(35, 35);
            this.pctUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctUser.TabIndex = 2;
            this.pctUser.TabStop = false;
            // 
            // pctFechar
            // 
            this.pctFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctFechar.BackColor = System.Drawing.Color.Transparent;
            this.pctFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctFechar.Image = global::MPJConstrucoesReformas.Properties.Resources.fechar;
            this.pctFechar.Location = new System.Drawing.Point(1288, 12);
            this.pctFechar.Name = "pctFechar";
            this.pctFechar.Size = new System.Drawing.Size(100, 100);
            this.pctFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctFechar.TabIndex = 3;
            this.pctFechar.TabStop = false;
            this.pctFechar.Click += new System.EventHandler(this.pctFechar_Click);
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(13, 123);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(217, 45);
            this.lblUser.TabIndex = 3;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Location = new System.Drawing.Point(13, 250);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(217, 34);
            this.btnEntrar.TabIndex = 5;
            this.btnEntrar.Text = "&Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.BackColor = System.Drawing.Color.Transparent;
            this.lblLink.Location = new System.Drawing.Point(60, 287);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(104, 13);
            this.lblLink.TabIndex = 4;
            this.lblLink.TabStop = true;
            this.lblLink.Text = "Esqueceu a Senha?";
            // 
            // txtUser
            // 
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(63, 136);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(155, 19);
            this.txtUser.TabIndex = 6;
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(63, 199);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(155, 19);
            this.txtSenha.TabIndex = 7;
            // 
            // lblSenha
            // 
            this.lblSenha.BackColor = System.Drawing.Color.White;
            this.lblSenha.Location = new System.Drawing.Point(13, 187);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(217, 45);
            this.lblSenha.TabIndex = 8;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MPJConstrucoesReformas.Properties.Resources.fundo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1400, 663);
            this.Controls.Add(this.pctFechar);
            this.Controls.Add(this.pnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MPJ Construções e Reformas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFechar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.LinkLabel lblLink;
        private System.Windows.Forms.PictureBox pctSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.PictureBox pctUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.PictureBox pctFechar;
        private System.Windows.Forms.TextBox txtUser;
    }
}

