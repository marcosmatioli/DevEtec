using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Veiculo
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-8JGGFEG\\MASTERDB;Initial Catalog=loja;User ID=sa;Password=1234567");
        SqlCommand command = new SqlCommand();

        dadosveiculo veiculo = new dadosveiculo();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            command.CommandText = "INSERT INTO carro(modelo,fabricante,ano,placa,cor,estado,cidade,foto)" +
            "VALUES('"+txbmodelo.Text+"','"+cbfabricante.Text+ "','" + cbano.Text + "','" + txbplaca.Text + "'" +
            ",'" + txbcor.Text + "','" + cbestado.Text + "','" + txbcidade.Text + "'," +
            "'" + pictureBox1.Image + "')";
            command.ExecuteNonQuery();
            con.Close();

            txbmodelo.Text = "";
            cbfabricante.Text = "";
            cbano.Text = "";
            txbplaca.Text = "";
            txbcor.Text = "";
            cbestado.Text = "";
            txbcidade.Text = "";
            pictureBox1.Image.Dispose();

            MessageBox.Show("Foi com sucesso");
            
        }
        

        private void btncarregar_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Imagem|*jpg;*doc;*xms;*ppt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileInfo file = new FileInfo(openFileDialog1.FileName);
                if (file.Length <= 1148576)
                {
                    pictureBox1.ImageLocation = openFileDialog1.FileName;
                }
                else MessageBox.Show("Muito grande a imagem");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            command.Connection = con;
        }

        private void cbestado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
