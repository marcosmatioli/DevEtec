namespace Sistema_Login_desk.View
{
    partial class frm_funcionario
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
            this.lblCodioFunc = new System.Windows.Forms.Label();
            this.txtCodFunc = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSairFunc = new System.Windows.Forms.Button();
            this.btnCadastrarFunc = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblEmailFunc = new System.Windows.Forms.Label();
            this.lblTelefonFunc = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOME:";
            // 
            // lblCodioFunc
            // 
            this.lblCodioFunc.AutoSize = true;
            this.lblCodioFunc.Location = new System.Drawing.Point(42, 55);
            this.lblCodioFunc.Name = "lblCodioFunc";
            this.lblCodioFunc.Size = new System.Drawing.Size(52, 13);
            this.lblCodioFunc.TabIndex = 1;
            this.lblCodioFunc.Text = "CÓDIGO:";
            // 
            // txtCodFunc
            // 
            this.txtCodFunc.Location = new System.Drawing.Point(106, 52);
            this.txtCodFunc.Name = "txtCodFunc";
            this.txtCodFunc.Size = new System.Drawing.Size(117, 20);
            this.txtCodFunc.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(106, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(197, 20);
            this.textBox2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSairFunc);
            this.groupBox1.Controls.Add(this.btnCadastrarFunc);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lblEmailFunc);
            this.groupBox1.Controls.Add(this.lblTelefonFunc);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCodFunc);
            this.groupBox1.Controls.Add(this.lblCodioFunc);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 355);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Funcionários:";
            // 
            // btnSairFunc
            // 
            this.btnSairFunc.Location = new System.Drawing.Point(297, 285);
            this.btnSairFunc.Name = "btnSairFunc";
            this.btnSairFunc.Size = new System.Drawing.Size(111, 34);
            this.btnSairFunc.TabIndex = 9;
            this.btnSairFunc.Text = "SAIR";
            this.btnSairFunc.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarFunc
            // 
            this.btnCadastrarFunc.Location = new System.Drawing.Point(171, 285);
            this.btnCadastrarFunc.Name = "btnCadastrarFunc";
            this.btnCadastrarFunc.Size = new System.Drawing.Size(102, 34);
            this.btnCadastrarFunc.TabIndex = 8;
            this.btnCadastrarFunc.Text = "CADASTRAR";
            this.btnCadastrarFunc.UseVisualStyleBackColor = true;
            this.btnCadastrarFunc.Click += new System.EventHandler(this.btnCadastrarFunc_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(106, 178);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(197, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 138);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 20);
            this.textBox1.TabIndex = 6;
            // 
            // lblEmailFunc
            // 
            this.lblEmailFunc.AutoSize = true;
            this.lblEmailFunc.Location = new System.Drawing.Point(42, 178);
            this.lblEmailFunc.Name = "lblEmailFunc";
            this.lblEmailFunc.Size = new System.Drawing.Size(42, 13);
            this.lblEmailFunc.TabIndex = 5;
            this.lblEmailFunc.Text = "EMAIL:";
            // 
            // lblTelefonFunc
            // 
            this.lblTelefonFunc.AutoSize = true;
            this.lblTelefonFunc.Location = new System.Drawing.Point(42, 141);
            this.lblTelefonFunc.Name = "lblTelefonFunc";
            this.lblTelefonFunc.Size = new System.Drawing.Size(66, 13);
            this.lblTelefonFunc.TabIndex = 4;
            this.lblTelefonFunc.Text = "TELEFONE:";
            // 
            // frm_funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_funcionario";
            this.Text = "FUNCIONÁRIO";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCodioFunc;
        private System.Windows.Forms.TextBox txtCodFunc;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSairFunc;
        private System.Windows.Forms.Button btnCadastrarFunc;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblEmailFunc;
        private System.Windows.Forms.Label lblTelefonFunc;
    }
}