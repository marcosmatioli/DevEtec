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
    public partial class FinalizarPedido : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-PQKTQDT\\MASTERDB;Initial Catalog=tcmrestaurante;User ID=sa;Password=1234567");
        SqlCommand command = new SqlCommand();
        DataSet dataSet = new DataSet();

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
                da.Fill(dataSet, "finalizar");
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public FinalizarPedido()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Principal prin = new Principal();
            Hide();
            prin.Show();
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (cbxcomanda1.Text != "")
            {
                dataSet.Clear();
                try
                {
                    ConnectaSQLServer();
                    //exibe o dados do dataset no datagrid
                    dgv3.DataSource = dataSet;
                    dgv3.DataMember = "finalizar";
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Escolha a comanda");
            }
        }

        private void FinalizarPedido_Load(object sender, EventArgs e)
        {
            command.Connection = con;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {// botão de pagamento da comanda
            if (cbxcomanda1.Text != "")
            {
                con.Open();
                command.CommandText = "DELETE FROM pedido WHERE codPedidoDeComandaFK = 1 ";
                command.ExecuteNonQuery();
                command.CommandText = "DELETE FROM comanda WHERE codComandaPK = 1";
                command.ExecuteNonQuery();
                con.Close();

                cbxcomanda1.Text = "";
                txtTotal.Text = "";
                dataSet.Clear();
                MessageBox.Show("Comanda paga com sucesso.","Sucesso !!!");
            }
        }

        private void Dgv3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
