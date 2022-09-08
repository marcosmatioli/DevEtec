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
    public partial class login : Form
    {
        int count = 0;
        
        public login()
        {
            InitializeComponent();
            tbxSenha.PasswordChar = '*';
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            
            String confirmaNome = "admin";
            String confirmSenha = "admin";
            String Name = tbxLogin.Text.ToString();
            String Senha = tbxSenha.Text.ToString();

            
            if(confirmaNome == Name && confirmSenha == Senha)
            {
                Principal mainmenu = new Principal();
                Hide();
                mainmenu.ShowDialog();
            }
            else if(count < 4)
            {

                MessageBox.Show("Senha ou Usuario incorreto","Mensagem de Erro",MessageBoxButtons.OK,MessageBoxIcon.Information);
                count++;
            }
            else
            {
                Application.Exit();
            }

            
        }

        private void login_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void Loginbutton_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void tbxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
