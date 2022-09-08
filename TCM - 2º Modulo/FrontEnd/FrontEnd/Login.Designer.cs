namespace FrontEnd
{
    partial class login
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
            this.txtlogin = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.Label();
            this.tbxLogin = new System.Windows.Forms.TextBox();
            this.tbxSenha = new System.Windows.Forms.TextBox();
            this.loginbutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtlogin
            // 
            this.txtlogin.AutoSize = true;
            this.txtlogin.BackColor = System.Drawing.Color.Transparent;
            this.txtlogin.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlogin.Location = new System.Drawing.Point(541, 377);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(58, 26);
            this.txtlogin.TabIndex = 0;
            this.txtlogin.Text = "Login";
            // 
            // txtpass
            // 
            this.txtpass.AutoSize = true;
            this.txtpass.BackColor = System.Drawing.Color.Transparent;
            this.txtpass.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(541, 436);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(64, 26);
            this.txtpass.TabIndex = 1;
            this.txtpass.Text = "Senha";
            // 
            // tbxLogin
            // 
            this.tbxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLogin.Location = new System.Drawing.Point(628, 383);
            this.tbxLogin.Name = "tbxLogin";
            this.tbxLogin.Size = new System.Drawing.Size(191, 22);
            this.tbxLogin.TabIndex = 2;
            this.tbxLogin.TextChanged += new System.EventHandler(this.tbxLogin_TextChanged);
            // 
            // tbxSenha
            // 
            this.tbxSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSenha.Location = new System.Drawing.Point(628, 442);
            this.tbxSenha.Name = "tbxSenha";
            this.tbxSenha.Size = new System.Drawing.Size(191, 22);
            this.tbxSenha.TabIndex = 3;
            this.tbxSenha.TextChanged += new System.EventHandler(this.tbxSenha_TextChanged);
            // 
            // loginbutton
            // 
            this.loginbutton.Location = new System.Drawing.Point(602, 495);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(75, 23);
            this.loginbutton.TabIndex = 4;
            this.loginbutton.Text = "Entrar";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            this.loginbutton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Loginbutton_KeyPress);
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(703, 495);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(75, 23);
            this.exitbutton.TabIndex = 5;
            this.exitbutton.Text = "Sair";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FrontEnd.Properties.Resources.Fundo_FE_Login1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.tbxSenha);
            this.Controls.Add(this.tbxLogin);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtlogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtlogin;
        private System.Windows.Forms.Label txtpass;
        private System.Windows.Forms.TextBox tbxLogin;
        private System.Windows.Forms.TextBox tbxSenha;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Button exitbutton;
    }
}

