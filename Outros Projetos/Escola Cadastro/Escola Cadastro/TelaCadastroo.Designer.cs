namespace Escola_Cadastro
{
    partial class TelaCadastroo
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
            this.lblNome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.btmCadastrar = new System.Windows.Forms.Button();
            this.btmAlterar = new System.Windows.Forms.Button();
            this.btmDeletar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.btmAlunos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(131, 41);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(41, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Período: ";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(131, 71);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(40, 13);
            this.lblIdade.TabIndex = 2;
            this.lblIdade.Text = "Idade: ";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(168, 38);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Location = new System.Drawing.Point(168, 94);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(100, 20);
            this.txtPeriodo.TabIndex = 4;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(168, 68);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(23, 20);
            this.txtIdade.TabIndex = 5;
            // 
            // btmCadastrar
            // 
            this.btmCadastrar.Location = new System.Drawing.Point(95, 161);
            this.btmCadastrar.Name = "btmCadastrar";
            this.btmCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btmCadastrar.TabIndex = 6;
            this.btmCadastrar.Text = "Cadastrar";
            this.btmCadastrar.UseVisualStyleBackColor = true;
            this.btmCadastrar.Click += new System.EventHandler(this.btmCadastrar_Click);
            // 
            // btmAlterar
            // 
            this.btmAlterar.Location = new System.Drawing.Point(95, 205);
            this.btmAlterar.Name = "btmAlterar";
            this.btmAlterar.Size = new System.Drawing.Size(75, 23);
            this.btmAlterar.TabIndex = 7;
            this.btmAlterar.Text = "Alterar";
            this.btmAlterar.UseVisualStyleBackColor = true;
            this.btmAlterar.Click += new System.EventHandler(this.btmAlterar_Click);
            // 
            // btmDeletar
            // 
            this.btmDeletar.Location = new System.Drawing.Point(193, 161);
            this.btmDeletar.Name = "btmDeletar";
            this.btmDeletar.Size = new System.Drawing.Size(75, 23);
            this.btmDeletar.TabIndex = 8;
            this.btmDeletar.Text = "Deletar";
            this.btmDeletar.UseVisualStyleBackColor = true;
            this.btmDeletar.Click += new System.EventHandler(this.btmDeletar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(385, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 277);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(522, 19);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 277);
            this.listBox2.TabIndex = 10;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(658, 19);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 277);
            this.listBox3.TabIndex = 11;
            // 
            // btmAlunos
            // 
            this.btmAlunos.Location = new System.Drawing.Point(193, 204);
            this.btmAlunos.Name = "btmAlunos";
            this.btmAlunos.Size = new System.Drawing.Size(75, 23);
            this.btmAlunos.TabIndex = 12;
            this.btmAlunos.Text = "Alunos";
            this.btmAlunos.UseVisualStyleBackColor = true;
            this.btmAlunos.Click += new System.EventHandler(this.btmAlunos_Click);
            // 
            // TelaCadastroo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btmAlunos);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btmDeletar);
            this.Controls.Add(this.btmAlterar);
            this.Controls.Add(this.btmCadastrar);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.txtPeriodo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNome);
            this.Name = "TelaCadastroo";
            this.Text = "TelaCadastroo";
            this.Load += new System.EventHandler(this.TelaCadastroo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Button btmCadastrar;
        private System.Windows.Forms.Button btmAlterar;
        private System.Windows.Forms.Button btmDeletar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button btmAlunos;
    }
}