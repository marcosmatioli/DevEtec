using Sistema_Login_desk.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Login_desk.Repositorio;
using Sistema_Login_desk.Model;
using Menu = Sistema_Login_desk.View.Menu;

namespace Sistema_Login_desk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        // primeiro processo para chamar a tela no projeto

        private void btnCadastrese_Click(object sender, EventArgs e)
        {
            frm_funcionario cad = new frm_funcionario();
            cad.Show();


        }
        // Ao clicar no botão entrar os metodos serão acionados em caso de sucesso ou não no login
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            controle controle = new controle();
            controle.acessar(txtUsuario.Text, txtSenha.Text);
            if(controle.mensagem.Equals(""))
            if(controle.T)
            {
                MessageBox.Show("Logado com sucesso", "entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Menu men = new Menu();
                    men.Show();
            }
            else
            {
                MessageBox.Show("usúario/senha invalídos", "ATENÇÃO!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }
    }
}