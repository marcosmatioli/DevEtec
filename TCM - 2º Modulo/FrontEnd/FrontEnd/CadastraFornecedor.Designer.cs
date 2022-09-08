namespace FrontEnd
{
    partial class CadastraFornecedor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbcodforn = new System.Windows.Forms.TextBox();
            this.txbnomeforn = new System.Windows.Forms.TextBox();
            this.txbcnpj = new System.Windows.Forms.TextBox();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.btndeletar = new System.Windows.Forms.Button();
            this.btnalterar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.btnatt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código Fornecedor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome Fornecedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "CNPJ";
            // 
            // txbcodforn
            // 
            this.txbcodforn.Location = new System.Drawing.Point(246, 46);
            this.txbcodforn.Name = "txbcodforn";
            this.txbcodforn.Size = new System.Drawing.Size(255, 20);
            this.txbcodforn.TabIndex = 4;
            // 
            // txbnomeforn
            // 
            this.txbnomeforn.Location = new System.Drawing.Point(246, 109);
            this.txbnomeforn.Name = "txbnomeforn";
            this.txbnomeforn.Size = new System.Drawing.Size(255, 20);
            this.txbnomeforn.TabIndex = 5;
            // 
            // txbcnpj
            // 
            this.txbcnpj.Location = new System.Drawing.Point(246, 178);
            this.txbcnpj.Name = "txbcnpj";
            this.txbcnpj.Size = new System.Drawing.Size(255, 20);
            this.txbcnpj.TabIndex = 6;
            // 
            // btncadastrar
            // 
            this.btncadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(10)))));
            this.btncadastrar.FlatAppearance.BorderSize = 0;
            this.btncadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncadastrar.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncadastrar.Location = new System.Drawing.Point(569, 162);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(117, 39);
            this.btncadastrar.TabIndex = 7;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = false;
            this.btncadastrar.Click += new System.EventHandler(this.Btncadastrar_Click_1);
            // 
            // btndeletar
            // 
            this.btndeletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(10)))));
            this.btndeletar.FlatAppearance.BorderSize = 0;
            this.btndeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndeletar.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeletar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btndeletar.Location = new System.Drawing.Point(941, 162);
            this.btndeletar.Name = "btndeletar";
            this.btndeletar.Size = new System.Drawing.Size(117, 39);
            this.btndeletar.TabIndex = 8;
            this.btndeletar.Text = "Deletar";
            this.btndeletar.UseVisualStyleBackColor = false;
            this.btndeletar.Click += new System.EventHandler(this.Btndeletar_Click_1);
            // 
            // btnalterar
            // 
            this.btnalterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(10)))));
            this.btnalterar.FlatAppearance.BorderSize = 0;
            this.btnalterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnalterar.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnalterar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnalterar.Location = new System.Drawing.Point(755, 162);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(117, 39);
            this.btnalterar.TabIndex = 9;
            this.btnalterar.Text = "Alterar";
            this.btnalterar.UseVisualStyleBackColor = false;
            this.btnalterar.Click += new System.EventHandler(this.Btnalterar_Click_1);
            // 
            // btnvoltar
            // 
            this.btnvoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(10)))));
            this.btnvoltar.FlatAppearance.BorderSize = 0;
            this.btnvoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnvoltar.Location = new System.Drawing.Point(1129, 37);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(117, 40);
            this.btnvoltar.TabIndex = 10;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = false;
            this.btnvoltar.Click += new System.EventHandler(this.Btnvoltar_Click_1);
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(46, 259);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(1248, 394);
            this.dgv1.TabIndex = 11;
            // 
            // btnatt
            // 
            this.btnatt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(10)))));
            this.btnatt.FlatAppearance.BorderSize = 0;
            this.btnatt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnatt.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnatt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnatt.Location = new System.Drawing.Point(1127, 161);
            this.btnatt.Name = "btnatt";
            this.btnatt.Size = new System.Drawing.Size(117, 39);
            this.btnatt.TabIndex = 12;
            this.btnatt.Text = "Atualizar";
            this.btnatt.UseVisualStyleBackColor = false;
            this.btnatt.Click += new System.EventHandler(this.Btnatt_Click);
            // 
            // CadastraFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(157)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btnatt);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnalterar);
            this.Controls.Add(this.btndeletar);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.txbcnpj);
            this.Controls.Add(this.txbnomeforn);
            this.Controls.Add(this.txbcodforn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastraFornecedor";
            this.Text = "CadastraFornecedor";
            this.Load += new System.EventHandler(this.CadastraFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbcodforn;
        private System.Windows.Forms.TextBox txbnomeforn;
        private System.Windows.Forms.TextBox txbcnpj;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.Button btndeletar;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button btnatt;
    }
}