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


namespace ProjetoCity
{
    public partial class Form1 : Form
    {
        //declarando a string de conexão
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-8JGGFEG;Initial Catalog=ProjetoBanco1;User ID=sa;Password=1234567");
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comando.Connection = con;
        }

        private void btninserir_Click(object sender, EventArgs e)
        {

            con.Open();
            comando.CommandText = "INSERT INTO dados (id,nome) VALUES ('" + txtid.Text + "','" + txtnome.Text + "')";
            comando.ExecuteNonQuery();
            con.Close();
            carregarlista();
            
            txtid.Text = "";
            txtnome.Text = "";

        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void excluirB_Click(object sender, EventArgs e)
        {
            if (txtid.Text != "" & txtnome.Text != "")
            {
                con.Open();
                comando.CommandText = "DELETE FROM dados WHERE id='" + txtid.Text + "' AND nome='" + txtnome.Text + "'";
                comando.ExecuteNonQuery();
                con.Close();

                txtid.Text = "";
                txtnome.Text = "";
            }
            /*con.Open();
            comando.CommandText = "DELETE FROM dados WHERE id = '" + oqexclui.Text + "'";
            comando.ExecuteNonQuery();
            con.Close();*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if(l.SelectedIndex !=-1)
            {
                listBox1.SelectedIndex = l.SelectedIndex;
                listBox2.SelectedIndex = l.SelectedIndex;
                txtid.Text = listBox1.SelectedItem.ToString();
                txtnome.Text = listBox2.SelectedItem.ToString();
               
            }
        }

        private void carregarlista()
        {
            listBox1.SelectedItems.Clear();
            listBox2.SelectedItems.Clear();
            con.Open();
            comando.CommandText = "SELECT * FROM dados";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    listBox1.Items.Add(dr[0].ToString());
                    listBox2.Items.Add(dr[1].ToString());

                }


            }
            con.Close();
            

        }

        private void txtalterar_Click(object sender, EventArgs e)
        {
            con.Open();
            comando.CommandText = "UPDATE dados SET id = '" + txtid.Text + "', nome = '" + txtnome.Text + "' WHERE id = '" + listBox1.SelectedItem.ToString() + "' AND nome = '" + listBox2.SelectedItem.ToString() + "'";
            comando.ExecuteNonQuery();
            con.Close();

            carregarlista();
            txtid.Text = "";
            txtnome.Text = "";

        }
    }
}
