namespace ProjetoCity
{
    partial class Form1
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
            this.lblid = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.btninserir = new System.Windows.Forms.Button();
            this.excluirB = new System.Windows.Forms.Button();
            this.oqexclui = new System.Windows.Forms.TextBox();
            this.txtid2 = new System.Windows.Forms.Label();
            this.txtnome2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.txtalterar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(13, 13);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(18, 13);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "ID";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(13, 46);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(35, 13);
            this.lblnome.TabIndex = 1;
            this.lblnome.Text = "Nome";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(79, 13);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 2;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(79, 46);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(100, 20);
            this.txtnome.TabIndex = 3;
            this.txtnome.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            // 
            // btninserir
            // 
            this.btninserir.Location = new System.Drawing.Point(315, 6);
            this.btninserir.Name = "btninserir";
            this.btninserir.Size = new System.Drawing.Size(128, 53);
            this.btninserir.TabIndex = 4;
            this.btninserir.Text = "Inserir";
            this.btninserir.UseVisualStyleBackColor = true;
            this.btninserir.Click += new System.EventHandler(this.btninserir_Click);
            // 
            // excluirB
            // 
            this.excluirB.Location = new System.Drawing.Point(315, 110);
            this.excluirB.Name = "excluirB";
            this.excluirB.Size = new System.Drawing.Size(128, 53);
            this.excluirB.TabIndex = 5;
            this.excluirB.Text = "Excluir";
            this.excluirB.UseVisualStyleBackColor = true;
            this.excluirB.Click += new System.EventHandler(this.excluirB_Click);
            // 
            // oqexclui
            // 
            this.oqexclui.Location = new System.Drawing.Point(79, 90);
            this.oqexclui.Name = "oqexclui";
            this.oqexclui.Size = new System.Drawing.Size(100, 20);
            this.oqexclui.TabIndex = 8;
            this.oqexclui.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtid2
            // 
            this.txtid2.AutoSize = true;
            this.txtid2.Location = new System.Drawing.Point(13, 192);
            this.txtid2.Name = "txtid2";
            this.txtid2.Size = new System.Drawing.Size(18, 13);
            this.txtid2.TabIndex = 9;
            this.txtid2.Text = "ID";
            // 
            // txtnome2
            // 
            this.txtnome2.AutoSize = true;
            this.txtnome2.Location = new System.Drawing.Point(12, 346);
            this.txtnome2.Name = "txtnome2";
            this.txtnome2.Size = new System.Drawing.Size(35, 13);
            this.txtnome2.TabIndex = 10;
            this.txtnome2.Text = "Nome";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(79, 167);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(79, 299);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 12;
            // 
            // txtalterar
            // 
            this.txtalterar.Location = new System.Drawing.Point(315, 209);
            this.txtalterar.Name = "txtalterar";
            this.txtalterar.Size = new System.Drawing.Size(128, 53);
            this.txtalterar.TabIndex = 13;
            this.txtalterar.Text = "Alterar";
            this.txtalterar.UseVisualStyleBackColor = true;
            this.txtalterar.Click += new System.EventHandler(this.txtalterar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtalterar);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtnome2);
            this.Controls.Add(this.txtid2);
            this.Controls.Add(this.oqexclui);
            this.Controls.Add(this.excluirB);
            this.Controls.Add(this.btninserir);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.lblid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Button btninserir;
        private System.Windows.Forms.Button excluirB;
        private System.Windows.Forms.TextBox oqexclui;
        private System.Windows.Forms.Label txtid2;
        private System.Windows.Forms.Label txtnome2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button txtalterar;
    }
}

