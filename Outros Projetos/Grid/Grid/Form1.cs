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

namespace Grid
{
    public partial class FormGrid : Form
    {
        //Criando um DataSet
        DataSet ds = new DataSet();
        private void ConnectaSQLServer()

        {
            try
            {

                //define a string de conexão
                string strConexao = @"Data source = localhost; Initial Catalog = CONTATO; User = sa; Password = 1234567";
                //Define o comando SQL
                string sql = "SELECT ID, NOME, CIDADE, TELEFONE FROM PESSOA";
                //Cria uma nova conexão
                SqlConnection conexao = new SqlConnection(strConexao);
                //cria um dataadapter
                SqlDataAdapter da = new SqlDataAdapter(sql, conexao);
                //Abre Conexão
                conexao.Open();
                //preenche o dataset
                da.Fill(ds, "PESSOA");
                //fecha a conexão
                conexao.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public FormGrid()
        {
            InitializeComponent();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectaSQLServer();
                //exibe o dados do dataset no datagrid
                dgvGrid.DataSource = ds;
                dgvGrid.DataMember = "PESSOA";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
