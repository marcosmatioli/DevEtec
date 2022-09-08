using System;
using System.Windows.Forms;

namespace Sistema_Login_desk
{
    public partial class Splash : Form
    {
        WMPLib.WindowsMediaPlayer meuplayer = new WMPLib.WindowsMediaPlayer();
        public Splash()
        {
            InitializeComponent();
            iniciaPlayer();
            desaparecer();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //metodo que chama a musica no local
        void iniciaPlayer()
        {
            meuplayer.URL = @"C:\Users\Lenovo\Desktop\DADOS_2\Sistema_Login_desk\Sistema_Login_desk\O Rei Leão.mp3";
            meuplayer.controls.play();
        }
        // para desaparecer a tela splash
        void desaparecer()
        {
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
            this.Opacity = 1;
        }
        // metodo do timer do splash
        private void timer1_Tick(object sender, EventArgs e)
        {
            bool ativo = true;

            if(ativo)
            {
                this.Opacity -= 0.01D;  // opacidade de 0.01D 
            }
            if(this.Opacity==0)
            {
                ativo = false;
                timer1.Enabled = false;
                Form1 login = new Form1();
                login.Show();

                meuplayer.controls.stop();
                this.Hide();
            }
        }
    }
}
