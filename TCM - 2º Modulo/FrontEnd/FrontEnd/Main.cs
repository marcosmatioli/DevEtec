using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btmVoltar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FinalizarPedido pdv = new FinalizarPedido();
            Principal.ActiveForm.Hide();
            pdv.ShowDialog();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            Estoque est = new Estoque();
            Principal.ActiveForm.Hide();
            est.ShowDialog();

        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            /*Calendario cal = new Calendario();
            Principal.ActiveForm.Hide();
            cal.ShowDialog();*/
            MessageBox.Show("Implementação Futura");
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            /*Config config = new Config();
            Principal.ActiveForm.Hide();
            config.ShowDialog();*/
            MessageBox.Show("Implementação Futura");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CadastrarFuncionario vaicadastrar = new CadastrarFuncionario();
            Principal.ActiveForm.Hide();
            vaicadastrar.ShowDialog();
        }

        private void btnpedido_Click(object sender, EventArgs e)
        {
            Pedido abrindoseupedido= new Pedido();
            Principal.ActiveForm.Hide();
            abrindoseupedido.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CadastraFornecedor forn = new CadastraFornecedor();
            Principal.ActiveForm.Hide();
            forn.ShowDialog();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Implementação Futura");
        }
    }
}
