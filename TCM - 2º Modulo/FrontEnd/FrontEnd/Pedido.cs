using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class Pedido : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-PQKTQDT\\MASTERDB;Initial Catalog=tcmrestaurante;User ID=sa;Password=1234567");
        SqlCommand command = new SqlCommand();
        
        DataSet dataSet = new DataSet();
        public Pedido()
        {
            InitializeComponent();
        }

        private void btnpedido_Click(object sender, EventArgs e)
        {
            if (cbxcomanda.Text != "" && cbxentrada.Text != "" && cbxbebida.Text != "" && cbxprato.Text != "" )
            {
                con.Open();
                command.CommandText = "insert into comanda values (1,'" + txbobs.Text + "')";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO pedido (codPedidoDeComandaFK,entrada,bebida,prato) VALUES(1,'" + cbxentrada.Text + "','" + cbxbebida.Text + "','" + cbxprato.Text + "')";
                command.ExecuteNonQuery();
                con.Close();

                cbxcomanda.Text = "";
                cbxentrada.Text = "";
                cbxbebida.Text = "";
                cbxprato.Text = "";
                txbobs.Text = "";
            }
            else MessageBox.Show("Escolha a Comanda/Pedido/Bebida/Prato");
        }

        private void Pedido_Load(object sender, EventArgs e)
        {
            command.Connection = con;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void button2_Click(object sender, EventArgs e)
        {// botão de voltar para a tela main
            Principal prin = new Principal();
            Hide();
            prin.Show();
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            if (cbxcomanda.Text == "Comanda 1")
            {//colocar aqui o bangue para atualizar o grid
                dataSet.Clear();
                try
                {
                    ConnectaSQLServer();
                    //exibe o dados do dataset no datagrid
                    dgv2.DataSource = dataSet;
                    dgv2.DataMember = "pedido";
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Escolha a Comanda.");
            }
        }
        private void ConnectaSQLServer()

        {
            try
            {

                //define a string de conexão
                // string strConexao = @"Data source = localhost; Initial Catalog = tcmrestaurante; User = sa; Password = 1234567";
                //Define o comando SQL
                string sql = "select pedido.entrada,pedido.bebida,pedido.prato,comanda.observacaoComanda from comanda,pedido where comanda.codComandaPK=pedido.codPedidoDeComandaFK";
                //Cria uma nova conexão
                //  SqlConnection conexao = new SqlConnection(strConexao);
                //cria um dataadapter
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                //Abre Conexão
                con.Open();
                //preenche o dataset
                da.Fill(dataSet, "pedido");
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            dataSet.Clear();
            cbxcomanda.Text = "";
            cbxentrada.Text = "";
            cbxbebida.Text = "";
            cbxprato.Text = "";
            txbobs.Text = "";
        }

        private void Cbxentrada_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}