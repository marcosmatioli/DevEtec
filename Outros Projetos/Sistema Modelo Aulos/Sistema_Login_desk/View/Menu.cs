using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Login_desk.View
{
    public partial class Menu : Form
    {
       DateTime data_hora;

        public Menu()
        {
            InitializeComponent();
        }

        private void cadToolStripMenuItem_Click(object sender, EventArgs e)
        {
        

          
        }

        private void fUNCIONARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_funcionario fun = new frm_funcionario();
           fun.Show();
        }

        private void lOGOFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Application.Exit();
           


        }

        private void Menu_Load(object sender, EventArgs e)
        {
          

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
              data_hora = DateTime.Now;
            lblData_Hora.Text = "" + data_hora.ToLongDateString()+"   " + data_hora.ToLongTimeString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pRODUTOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
