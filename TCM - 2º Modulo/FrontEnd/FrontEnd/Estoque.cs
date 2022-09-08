using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace FrontEnd
{
    public partial class Estoque : Form
    {
        
        public Estoque()
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
                string sql = "SELECT codProd as [Codigo Produto],nomeProd as [Nome Produto],qtdProd as [Quantidade Produto],fornProd as [Fornecedor Produto],descProd as [Descrição Produto] FROM estoque";
                //Cria uma nova conexão
              //  SqlConnection conexao = new SqlConnection(strConexao);
                //cria um dataadapter
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                //Abre Conexão
                con.Open();
                //preenche o dataset
                da.Fill(dataSet, "estoque");
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            private void btnVoltar_Click(object sender, EventArgs e)
        { // volta para a janela principal
            Principal prin = new Principal();
            Hide();
            prin.Show();
        }

        private void AttLista_Click(object sender, EventArgs e)
        {
            dataSet.Clear();
            try
            {
                
                ConnectaSQLServer();
                //exibe o dados do dataset no datagrid
                dgv1.DataSource = dataSet;
                dgv1.DataMember = "estoque";
                MessageBox.Show("Atualizado!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {// cadastra no banco de dados o estoque
            con.Open();
            command.CommandText = "INSERT INTO estoque (nomeProd,qtdProd,fornProd,descProd) VALUES('" + txbnomeprod.Text + "','" + txbqtd.Text + "','" + txbforn.Text + "','" + txbdesc.Text + "') ";
            command.ExecuteNonQuery();
            con.Close();

            txbcodprod.Text = "";
            txbnomeprod.Text = "";
            txbforn.Text = "";
            txbqtd.Text = "";
            txbdesc.Text = "";

            dataSet.Clear();
            try
            {

                ConnectaSQLServer();
                //exibe o dados do dataset no datagrid
                dgv1.DataSource = dataSet;
                dgv1.DataMember = "estoque";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("Cadastrado com sucesso.");
        }

        private void Estoque_Load(object sender, EventArgs e)
        { // carrega a conexão quando abre a janela estoque
            command.Connection = con;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {//botão de deletar
            if (txbcodprod.Text != "")
            {
                con.Open();
                command.CommandText = "DELETE FROM estoque WHERE codProd ='" + txbcodprod.Text + "'";
                command.ExecuteNonQuery();
                con.Close();

                txbcodprod.Text = "";
                txbnomeprod.Text = "";
                txbforn.Text = "";
                txbqtd.Text = "";
                txbdesc.Text = "";

                dataSet.Clear();
                try
                {

                    ConnectaSQLServer();
                    //exibe o dados do dataset no datagrid
                    dgv1.DataSource = dataSet;
                    dgv1.DataMember = "estoque";
                                    }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MessageBox.Show("Codigo deletado com sucesso.");
             }
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {//botão de alterar
            con.Open();
            command.CommandText = "UPDATE estoque SET nomeProd = '"+ txbnomeprod.Text +"', qtdProd = '"+txbqtd.Text+"', fornProd = '"+txbforn.Text+"', descProd = '"+txbdesc.Text+"' WHERE codProd = '"+txbcodprod.Text+"'";
            command.ExecuteNonQuery();
            con.Close();

            txbcodprod.Text = "";
            txbnomeprod.Text = "";
            txbforn.Text = "";
            txbqtd.Text = "";
            txbdesc.Text = "";

            dataSet.Clear();
            try
            {

                ConnectaSQLServer();
                //exibe o dados do dataset no datagrid
                dgv1.DataSource = dataSet;
                dgv1.DataMember = "estoque";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("Codigo Alterado com sucesso.");
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

