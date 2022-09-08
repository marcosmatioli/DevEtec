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
    public partial class CadastrarFuncionario : Form
    {//declaração da string de conexão
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
                string sql = "select codFunc,nomeFunc,usuarioFunc,senhaFunc,cargoFunc from funcionario";
                //Cria uma nova conexão
                //  SqlConnection conexao = new SqlConnection(strConexao);
                //cria um dataadapter
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                //Abre Conexão
                con.Open();
                //preenche o dataset
                da.Fill(dataSet, "funcionario");
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public CadastrarFuncionario()
        {
            InitializeComponent();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {// fecha esta windows form e abre novamente a janela principal
            Principal prin = new Principal();
            Hide();
            prin.Show();
        }

        private void btncadasatrar_Click(object sender, EventArgs e)
        {//cadastra funcionario no banco de dados
            con.Open();
            command.CommandText = "INSERT INTO funcionario (nomeFunc,usuarioFunc,senhaFunc,cargoFunc) VALUES('" + txbnome.Text + "','" + txbusuario.Text + "','" + txbsenha.Text + "','" + txbcargo.Text + "') ";
            command.ExecuteNonQuery();
            con.Close();

            txbnome.Text = "";
            txbusuario.Text = "";
            txbsenha.Text = "";
            txbcargo.Text = "";
            
            MessageBox.Show("Cadastrado com sucesso.");

            dataSet.Clear();
            try
            {

                ConnectaSQLServer();
                //exibe o dados do dataset no datagrid
                dgv1.DataSource = dataSet;
                dgv1.DataMember = "funcionario";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btndeletar_Click(object sender, EventArgs e)
        {//deleta funcionario do banco de dados
            con.Open();
            command.CommandText = "DELETE FROM funcionario WHERE codFunc ='" + txbcodfunc.Text + "'";
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deletado com sucesso.");

            dataSet.Clear();
            try
            {

                ConnectaSQLServer();
                //exibe o dados do dataset no datagrid
                dgv1.DataSource = dataSet;
                dgv1.DataMember = "funcionario";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void CadastrarFuncionario_Load(object sender, EventArgs e)
        {// carrega a conexão quando abre a janela estoque
            command.Connection = con;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            dataSet.Clear();
            try
            {

                ConnectaSQLServer();
                //exibe o dados do dataset no datagrid
                dgv1.DataSource = dataSet;
                dgv1.DataMember = "funcionario";
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btnatt_Click(object sender, EventArgs e)
        {
            dataSet.Clear();
            try
            {

                ConnectaSQLServer();
                //exibe o dados do dataset no datagrid
                dgv1.DataSource = dataSet;
                dgv1.DataMember = "funcionario";
                MessageBox.Show("Atualizado!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
