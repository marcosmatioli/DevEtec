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

    public partial class CadastraFornecedor : Form
    {

        public CadastraFornecedor()
        {
            InitializeComponent();
        }
        //inicia a conexão padrão com o banco de dados do projeto
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
                string sql = "SELECT codForn,nomeForn,cnpjForn FROM fornecedor";
                //Cria uma nova conexão
                //  SqlConnection conexao = new SqlConnection(strConexao);
                //cria um dataadapter
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                //Abre Conexão
                con.Open();
                //preenche o dataset
                da.Fill(dataSet, "fornecedor");
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Btnvoltar_Click_1(object sender, EventArgs e)
        {
            // volta para a janela principal
            Principal prin = new Principal();
            Hide();
            prin.Show();
        }

        private void Btnatt_Click(object sender, EventArgs e)
        {
            dataSet.Clear();
            try
            {

                ConnectaSQLServer();
                //exibe o dados do dataset no datagrid
                dgv1.DataSource = dataSet;
                dgv1.DataMember = "fornecedor";
                MessageBox.Show("Atualizado!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btnalterar_Click_1(object sender, EventArgs e)
        {
            //botão de alterar
            con.Open();
            command.CommandText = "UPDATE fornecedor SET nomeForn = '" + txbnomeforn.Text + "', cnpjForn = '" + txbcnpj.Text + "' WHERE codForn = '" + txbcodforn.Text + "'";
            command.ExecuteNonQuery();
            con.Close();

            txbcodforn.Text = "";
            txbnomeforn.Text = "";
            txbcnpj.Text = "";

            dataSet.Clear();
            try
            {

                ConnectaSQLServer();
                //exibe o dados do dataset no datagrid
                dgv1.DataSource = dataSet;
                dgv1.DataMember = "fornecedor";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("Codigo Alterado com sucesso.");
        }

        private void CadastraFornecedor_Load(object sender, EventArgs e)
        {
            // carrega a conexão quando abre a janela estoque
            command.Connection = con;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

        }

        private void Btndeletar_Click_1(object sender, EventArgs e)
        {
            //botão de deletar
            if (txbcodforn.Text != "")
            {
                con.Open();
                command.CommandText = "DELETE FROM fornecedor WHERE codForn ='" + txbcodforn.Text + "'";
                command.ExecuteNonQuery();
                con.Close();

                txbcodforn.Text = "";
                txbnomeforn.Text = "";
                txbcnpj.Text = "";

                dataSet.Clear();
                try
                {

                    ConnectaSQLServer();
                    //exibe o dados do dataset no datagrid
                    dgv1.DataSource = dataSet;
                    dgv1.DataMember = "fornecedor";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MessageBox.Show("Codigo deletado com sucesso.");
            }
        }
        private void Btncadastrar_Click_1(object sender, EventArgs e)
        {
            // cadastra no banco de dados o estoque
            con.Open();
            command.CommandText = "INSERT INTO fornecedor (codForn,nomeForn,cnpjForn) VALUES('" + txbcodforn.Text + "','" + txbnomeforn.Text + "','" + txbcnpj.Text + "') ";
            command.ExecuteNonQuery();
            con.Close();

            txbcodforn.Text = "";
            txbnomeforn.Text = "";
            txbcnpj.Text = "";

            dataSet.Clear();
            try
            {

                ConnectaSQLServer();
                //exibe o dados do dataset no datagrid
                dgv1.DataSource = dataSet;
                dgv1.DataMember = "fornecedor";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("Cadastrado com sucesso.");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
            
