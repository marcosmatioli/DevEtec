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


namespace Escola_Cadastro
{
    public partial class TelaCadastroo : Form
    {
        public TelaCadastroo()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-KJ1E8U0D\\SQL2014;Initial Catalog=Escola_Cadastro;User ID=sa;Password=1234567");
        SqlCommand coman = new SqlCommand();
        SqlDataReader dr;

        private void TelaCadastroo_Load(object sender, EventArgs e)
        {
            coman.Connection = con;
        }

        private void btmCadastrar_Click(object sender, EventArgs e)
        {
            con.Open();
            coman.CommandText = "INSERT INTO dados (Nome, Idade, periodo) VALUES('" + txtNome.Text + "','" + txtIdade.Text + "','" + txtPeriodo.Text + "') ";
            coman.ExecuteNonQuery();
            con.Close();

            txtIdade.Text = "";
            txtNome.Text = "";
            txtPeriodo.Text = "";
            carregarlista();
        }

        private void btmDeletar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" & txtIdade.Text !="" & txtPeriodo.Text !="")
            {
                con.Open();
                coman.CommandText = "DELETE FROM estoque WHERE codProd ='" + txbcodprod.Text +"';
                coman.ExecuteNonQuery();
                con.Close();
                carregarlista();
            }
        }

        private void btmAlterar_Click(object sender, EventArgs e)
        {
            con.Open();
            coman.CommandText = "UPDATE da SET Nome = '"+txtNome.Text+"', Idade='"+txtIdade.Text+"',periodo = '"+txtPeriodo.Text+"' WHERE Nome ='"+listBox1.SelectedItem.ToString()+"' AND Idade = '"+listBox2.SelectedItem.ToString()+"' AND periodo = '"+listBox3.SelectedItem.ToString()+"'";
            coman.ExecuteNonQuery();
            con.Close();
            carregarlista();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                listBox1.SelectedIndex = l.SelectedIndex;
                listBox2.SelectedIndex = l.SelectedIndex;
                listBox3.SelectedIndex = l.SelectedIndex;

                txtNome.Text = listBox1.SelectedItem.ToString();
                txtIdade.Text = listBox2.SelectedItem.ToString();
                txtPeriodo.Text = listBox3.SelectedItem.ToString();
            }

        }
        private void carregarlista()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            con.Open();
            coman.CommandText = "SELECT * FROM dados";
            dr = coman.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    listBox1.Items.Add(dr[0].ToString());
                    listBox2.Items.Add(dr[1].ToString());
                    listBox3.Items.Add(dr[2].ToString());
                }
            }
            con.Close();


        }

        private void btmAlunos_Click(object sender, EventArgs e)
        {
            carregarlista();
        }
    }
}
