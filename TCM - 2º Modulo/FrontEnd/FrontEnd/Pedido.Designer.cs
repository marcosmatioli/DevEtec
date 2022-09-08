namespace FrontEnd
{
    partial class Pedido
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
            this.cbxcomanda = new System.Windows.Forms.ComboBox();
            this.btnpedido = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxentrada = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxbebida = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxprato = new System.Windows.Forms.ComboBox();
            this.btnconsultar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txbobs = new System.Windows.Forms.TextBox();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.btnlimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxcomanda
            // 
            this.cbxcomanda.FormattingEnabled = true;
            this.cbxcomanda.Items.AddRange(new object[] {
            "Comanda 1"});
            this.cbxcomanda.Location = new System.Drawing.Point(286, 60);
            this.cbxcomanda.Name = "cbxcomanda";
            this.cbxcomanda.Size = new System.Drawing.Size(121, 21);
            this.cbxcomanda.TabIndex = 0;
            // 
            // btnpedido
            // 
            this.btnpedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(10)))));
            this.btnpedido.FlatAppearance.BorderSize = 0;
            this.btnpedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpedido.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpedido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnpedido.Location = new System.Drawing.Point(529, 195);
            this.btnpedido.Name = "btnpedido";
            this.btnpedido.Size = new System.Drawing.Size(180, 40);
            this.btnpedido.TabIndex = 1;
            this.btnpedido.Text = "Fazer Pedido";
            this.btnpedido.UseVisualStyleBackColor = false;
            this.btnpedido.Click += new System.EventHandler(this.btnpedido_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Comanda";
            // 
            // cbxentrada
            // 
            this.cbxentrada.FormattingEnabled = true;
            this.cbxentrada.Items.AddRange(new object[] {
            "Shimeji Batayaki",
            "Sunomono",
            "Rolinho de Camarão",
            "Misso Shiro",
            "Carpaccio de Polvo",
            "Lula a Dorê",
            "Batata Frita",
            "Isca de Peixe",
            "Shimeji com Legume"});
            this.cbxentrada.Location = new System.Drawing.Point(172, 147);
            this.cbxentrada.Name = "cbxentrada";
            this.cbxentrada.Size = new System.Drawing.Size(152, 21);
            this.cbxentrada.TabIndex = 3;
            this.cbxentrada.SelectedIndexChanged += new System.EventHandler(this.Cbxentrada_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(193, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Entrada";
            // 
            // cbxbebida
            // 
            this.cbxbebida.FormattingEnabled = true;
            this.cbxbebida.Items.AddRange(new object[] {
            "Refrigerante 2L",
            "Refrigerante 500ml",
            "Sucos Diversos",
            "Saquê",
            "Vinho",
            "Drinks Afrodisíacos"});
            this.cbxbebida.Location = new System.Drawing.Point(412, 147);
            this.cbxbebida.Name = "cbxbebida";
            this.cbxbebida.Size = new System.Drawing.Size(152, 21);
            this.cbxbebida.TabIndex = 5;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(444, 113);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(92, 31);
            this.label29.TabIndex = 6;
            this.label29.Text = "Bebida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(689, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Prato";
            // 
            // cbxprato
            // 
            this.cbxprato.FormattingEnabled = true;
            this.cbxprato.Items.AddRange(new object[] {
            "Kare Rice",
            "Ramen",
            "Sushi",
            "Gyudon",
            "Sukiyaki",
            "Sashimi",
            "Manju",
            "Mochi",
            "Guioza",
            "Tempura"});
            this.cbxprato.Location = new System.Drawing.Point(652, 147);
            this.cbxprato.Name = "cbxprato";
            this.cbxprato.Size = new System.Drawing.Size(152, 21);
            this.cbxprato.TabIndex = 8;
            // 
            // btnconsultar
            // 
            this.btnconsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(10)))));
            this.btnconsultar.FlatAppearance.BorderSize = 0;
            this.btnconsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconsultar.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsultar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnconsultar.Location = new System.Drawing.Point(412, 587);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(180, 60);
            this.btnconsultar.TabIndex = 9;
            this.btnconsultar.Text = "Consultar Pedido";
            this.btnconsultar.UseVisualStyleBackColor = false;
            this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(10)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(1142, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 46);
            this.button2.TabIndex = 11;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(927, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 31);
            this.label4.TabIndex = 12;
            this.label4.Text = "Observação";
            // 
            // txbobs
            // 
            this.txbobs.Location = new System.Drawing.Point(892, 147);
            this.txbobs.Name = "txbobs";
            this.txbobs.Size = new System.Drawing.Size(211, 20);
            this.txbobs.TabIndex = 13;
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(125, 255);
            this.dgv2.Name = "dgv2";
            this.dgv2.Size = new System.Drawing.Size(1016, 313);
            this.dgv2.TabIndex = 14;
            this.dgv2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv2_CellContentClick);
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(10)))));
            this.btnlimpar.FlatAppearance.BorderSize = 0;
            this.btnlimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnlimpar.Location = new System.Drawing.Point(695, 587);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(180, 60);
            this.btnlimpar.TabIndex = 15;
            this.btnlimpar.Text = "Limpar Tudo";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(157)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.txbobs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnconsultar);
            this.Controls.Add(this.cbxprato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.cbxbebida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxentrada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnpedido);
            this.Controls.Add(this.cbxcomanda);
            this.Name = "Pedido";
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.Pedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxcomanda;
        private System.Windows.Forms.Button btnpedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxentrada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxbebida;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxprato;
        private System.Windows.Forms.Button btnconsultar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbobs;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.Button btnlimpar;
    }
}