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
    public partial class Calendario : Form
    {
        
        public Calendario()
        {
            InitializeComponent();
            
             
        }
        private void atualizarhora()
        {
            

        }
        private void btmVoltar_Click(object sender, EventArgs e)
        {
            Principal prin = new Principal();
            Hide();
            prin.Show();
        }

        private void Calendario_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
