using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Label lblDayz;
        Int32   y = 0;
        Int32 x ;
        Int32 ndayz;
        string Dayofweek,CurrentCulture;
        int  VerificaDia()
        {
            DateTime time = Convert.ToDateTime(cboMes.Text +  "/01/" + txtAno .Text );
           //péga o dia de inicio da semana para data informada
            Dayofweek = Application.CurrentCulture.Calendar.GetDayOfWeek(time).ToString();
            if (Dayofweek == "Sunday")
            {
                x = 0;
            }
            else if (Dayofweek == "Monday")
            {
                x = 0+42;
                ndayz = 1;
            }
            else if (Dayofweek == "Tuesday")
            {
                x = 0 + 84;
                ndayz = 2;
            }
            else if (Dayofweek == "Wednesday")
            {
                x = 0 + 84 + 42;
                ndayz = 3;
            }
            else if (Dayofweek == "Thursday")
            {
                x = 0 + 84 + 84;
                ndayz = 4;
            }
            else if (Dayofweek == "Friday")
            {
                x = 0 + 84 + 84 + 42;
                ndayz = 5;
            }
            else if (Dayofweek == "Saturday")
            {
                x = 0 + 84 + 84 + 84;
                ndayz = 6;
            }
            return x;
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CurrentCulture =Application .CurrentCulture .Name ;
            //exibe o mes atual
            cboMes.Text = DateTime.Now.Month.ToString();
            //exibe o nome completo do mes atual
            labelMes.Text = Application.CurrentCulture.DateTimeFormat.GetMonthName(Convert .ToInt32 ( cboMes.Text)); 
            //altera a cultura para evitar data incorreta
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-us");
            //obtem o nume de dias no mes e ano selecionado
            Int32 Dayz = DateTime.DaysInMonth(DateTime.Now .Year  , DateTime .Now .Month  );
            //exibe o ano atual no textbox
            txtAno.Text = DateTime.Now.Year.ToString();
            //chama a função 
            VerificaDia();
            for (Int32 i = 1; i < Dayz + 1; i++)
            {
                ndayz += 1;
                lblDayz = new Label();
                lblDayz.Name = "B" + i;
                lblDayz.Text = i.ToString();
                lblDayz.BorderStyle = BorderStyle.Fixed3D;
                if (i == DateTime.Now.Day)
                {
                    lblDayz.BackColor = Color.Green;
                }
                else if (ndayz == 01)
                {
                    lblDayz.BackColor = Color.LightSalmon;
                }
                else
                {
                    lblDayz.BackColor = Color.Aquamarine;
                }
               lblDayz.Font = label31.Font;
                lblDayz.SetBounds(x, y, 37, 27);
                 x += 42;
                if (ndayz == 7)
                {
                    x = 0;
                    ndayz = 0;
                    y += 29;
                }
                panel1.Controls.Add(lblDayz);
            }
            //return all values to default
            x = 0;
            ndayz = 0;
            y = 0;
           }
             
       private void buttonGo_Click_1(object sender, EventArgs e)
        {
            if ((cboMes.Text == null) || (txtAno.Text == null))
            {
                MessageBox.Show("O ano ou o mês estão incorretos");
            }
            else
            {
                try
                {
                    Int32 t = Convert.ToInt32(txtAno.Text);
                    if ((txtAno.Text != "0") || (t < 1))
                    {
                        //remove todos os controles do painel
                        panel1.Controls.Clear();
                        Thread.CurrentThread.CurrentCulture = new CultureInfo(CurrentCulture);
                        //exibe o nome completo do mes selecionado
                        labelMes.Text = Application.CurrentCulture.DateTimeFormat.GetMonthName(Convert.ToInt32(cboMes.Text));
                         Thread.CurrentThread.CurrentCulture = new CultureInfo("en-us");
                        Int32 Dayz = DateTime.DaysInMonth(Convert.ToInt32(txtAno.Text), Convert.ToInt32(cboMes.Text));
                        VerificaDia();
                        for (Int32 i = 1; i < Dayz + 1; i++)
                        {
                            ndayz += 1;
                            lblDayz = new Label();
                            lblDayz.Text = i.ToString();
                            lblDayz.BorderStyle = BorderStyle.Fixed3D;
                            Int32 mon = Convert.ToInt32(cboMes.Text);
                            Int32 year = Convert.ToInt32(txtAno.Text);
                            if ((i == DateTime.Now.Day) && (mon == DateTime.Now.Month) && (year == DateTime.Now.Year))
                            {
                                //destaca o dia atual com cor diferente
                                lblDayz.BackColor = Color.Green;
                            }
                            else if (ndayz == 01)
                            {
                                lblDayz.BackColor = Color.LightYellow;
                            }
                            else
                            {
                                //define a cor para outros dias do mes selecionado
                                lblDayz.BackColor = Color.Aquamarine;
                            }
                            lblDayz.Font = label31.Font;
                            lblDayz.SetBounds(x, y, 37, 27);

                            x += 42;
                            if (ndayz == 7)
                            {
                                x = 0;
                                ndayz = 0;
                                y += 29;
                            }
                            panel1.Controls.Add(lblDayz);
                        }
                        x = 0;
                        ndayz = 0;
                        y = 0;
                    }
                    else
                    {
                        MessageBox.Show("O valor deve estar entre 0 e 9999");
                        txtAno.Focus();
                    }
                }
                catch (FormatException )
                {
                    MessageBox.Show("O ano deve estar entre 0 e 9999");
                    txtAno.Focus();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 mesAtual, anoAtual;
                anoAtual = Convert.ToInt32(txtAno.Text);
                mesAtual = Convert.ToInt32(cboMes.Text);
                if (mesAtual == 12)
                {
                    anoAtual += 1;
                    mesAtual = 1;
                    txtAno.Text = anoAtual.ToString();
                    cboMes.Text = mesAtual.ToString();
                }
                else
                {
                    mesAtual += 1;
                    cboMes.Text = mesAtual.ToString();
                }

                //remove todos os controles do painel
                panel1.Controls.Clear();
                Thread.CurrentThread.CurrentCulture = new CultureInfo(CurrentCulture );
                //exibe o nome completo do mes selecionado
                labelMes.Text = Application.CurrentCulture.DateTimeFormat.GetMonthName(mesAtual);
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-za");
                Int32 Dayz = DateTime.DaysInMonth(Convert.ToInt32(txtAno.Text), Convert.ToInt32(cboMes.Text));
                VerificaDia();
                for (Int32 i = 1; i < Dayz + 1; i++)
                {
                    ndayz += 1;

                    lblDayz = new Label();
                    lblDayz.Text = i.ToString();
                    lblDayz.BorderStyle = BorderStyle.Fixed3D;
                    Int32 mon = Convert.ToInt32(cboMes.Text);
                    Int32 year=Convert .ToInt32 ( txtAno .Text) ;
                    if ((i == DateTime.Now.Day) && (mon == DateTime.Now.Month) && (year ==DateTime.Now .Year )  )
                    {
                        //o dia atual deve ser destacado com cor diferente
                        lblDayz.BackColor = Color.Green;

                    }
                    else if (ndayz == 01)
                    {
                        lblDayz.BackColor = Color.LightSalmon;
                    }
                    else
                    {
                        //define a cor dos outros dias do mes
                        lblDayz.BackColor = Color.Aquamarine;
                    }
                    lblDayz.Font = label31.Font;
                    lblDayz.SetBounds(x, y, 37, 27);

                    x += 42;
                    if (ndayz == 7)
                    {
                        x = 0;
                        ndayz = 0;
                        y += 29;
                    }
                    panel1.Controls.Add(lblDayz);
                }
                x = 0;
                ndayz = 0;
                y = 0;
            }
            catch (FormatException)
            {
                MessageBox.Show("data inválida");
                txtAno.Focus();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("data inválida");
                txtAno.Focus();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 mesAtual, anoAtual;
                anoAtual = Convert.ToInt32(txtAno.Text);
                mesAtual = Convert.ToInt32(cboMes.Text);
                if (mesAtual == 1)
                {
                    anoAtual -= 1;
                    mesAtual = 12;
                    txtAno.Text = anoAtual.ToString();
                    cboMes.Text = mesAtual.ToString();
                }
                else
                {
                    mesAtual -= 1;
                    cboMes.Text = mesAtual.ToString();
                }

                //remove all the controls in the panel
                panel1.Controls.Clear();
                Thread.CurrentThread.CurrentCulture = new CultureInfo(CurrentCulture );
                //display the selected month's fullname
                labelMes.Text = Application.CurrentCulture.DateTimeFormat.GetMonthName(mesAtual);
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-za");
                Int32 Dayz = DateTime.DaysInMonth(Convert.ToInt32(txtAno.Text), Convert.ToInt32(cboMes.Text));
                VerificaDia();
                for (Int32 i = 1; i < Dayz + 1; i++)
                {
                    ndayz += 1;

                    lblDayz = new Label();
                    lblDayz.Text = i.ToString();
                    lblDayz.BorderStyle = BorderStyle.Fixed3D;
                    Int32 mon = Convert.ToInt32(cboMes.Text);
                    Int32 year = Convert.ToInt32(txtAno.Text);
                    if ((i == DateTime.Now.Day) && (mon == DateTime.Now.Month) && (year == DateTime.Now.Year))
                    {
                        //the current day must be highlighted differently
                        lblDayz.BackColor = Color.Green;
                    }
                    else if (ndayz == 01)
                    {
                        lblDayz.BackColor = Color.LightSalmon;
                    }
                    else
                    {
                        //set this color for other days in the selected month
                        lblDayz.BackColor = Color.Aquamarine;
                    }
                    lblDayz.Font = label31.Font;
                    lblDayz.SetBounds(x, y, 37, 27);

                    x += 42;
                    if (ndayz == 7)
                    {
                        x = 0;
                        ndayz = 0;
                        y += 29;
                    }
                    panel1.Controls.Add(lblDayz);
                }
                x = 0;
                ndayz = 0;
                y = 0;
            }
            catch (FormatException)
            {
                MessageBox.Show("Data inválida");
                txtAno.Focus();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Data inválida");
                txtAno.Focus();
            }
        }
            }
            
        }

    

