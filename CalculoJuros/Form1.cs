using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CalculoJuros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool mover;
        private int cX, cY;

      
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";

            textBox4.Text = "";

            textBox6.Text = "";

            textBox8.Text = "";

            button6.Visible = false;

            label9.Text = "";


        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                Calculos.dias = int.Parse(textBox2.Text);
                Calculos.aluguel = float.Parse(textBox1.Text);

                button6.BackColor = Color.Transparent;

                if (Calculos.dias <= 10)
                {
                    Calculos.Calculo30SemDev();

                    textBox4.Text = Calculos.juros.ToString("C2");
                    textBox8.Text = Calculos.valorMulta.ToString("C2");
                    textBox6.Text = Calculos.valorFinal.ToString("C2");
                }

                else if (Calculos.dias >= 11 && Calculos.dias <= 30)
                {
                    button6.Visible = true;

                    Calculos.Calculo30SemDev();

                    MessageBox.Show("Numero de dias ultrapassado \n *SEMPRE* Confirmar valor no sistema", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBox4.Text = Calculos.juros.ToString("C2");
                    textBox8.Text = Calculos.valorMulta.ToString("C2");
                    textBox6.Text = Calculos.valorFinal.ToString("C2");

                }
                
                if(checkBox1.Checked == true)
                {
                    if (Calculos.dias >= 31 && Calculos.dias <= 60)
                    {

                        MessageBox.Show("Valor do aluguel RENOVADO 2 meses automaticamente \nVerificar lançamentos no Hiper (Contas a receber)", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        button6.Visible = true;

                        Calculos.Calculo60SemDev();

                        button6.BackColor = Color.Red;

                        MessageBox.Show("Numero de dias ultrapassado \n Confirmar valor no sistema", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        label9.Text = "RENOVADO por 2 meses";

                        textBox4.Text = Calculos.juros.ToString("C2");
                        textBox8.Text = Calculos.valorMulta.ToString("C2");
                        textBox6.Text = Calculos.valorFinal.ToString("C2");

                    }
                    else if (Calculos.dias >= 61 && Calculos.dias <= 90)
                    {

                        MessageBox.Show("Valor do aluguel RENOVADO 3 meses automaticamente \nVerificar lançamentos no Hiper (Contas a receber)", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        button6.Visible = true;

                        Calculos.Calculo90SemDev();

                        button6.BackColor = Color.Red;

                        MessageBox.Show("Numero de dias ultrapassado \n Confirmar valor no sistema", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        label9.Text = "RENOVADO por 3 meses";

                        textBox4.Text = Calculos.juros.ToString("C2");
                        textBox8.Text = Calculos.valorMulta.ToString("C2");
                        textBox6.Text = Calculos.valorFinal.ToString("C2");
                    }
                    else if (Calculos.dias >= 91 && Calculos.dias <= 120)
                    {

                        MessageBox.Show("Valor do aluguel RENOVADO 4 meses automaticamente \nVerificar lançamentos no Hiper (Contas a receber)", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        button6.Visible = true;

                        Calculos.Calculo120SemDev();

                        button6.BackColor = Color.Red;

                        MessageBox.Show("Numero de dias ultrapassado \n Confirmar valor no sistema", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        label9.Text = "RENOVADO por 4 meses";

                        textBox4.Text = Calculos.juros.ToString("C2");
                        textBox8.Text = Calculos.valorMulta.ToString("C2");
                        textBox6.Text = Calculos.valorFinal.ToString("C2");
                    }
                    else if (Calculos.dias >= 121 && Calculos.dias <= 150)
                    {

                        MessageBox.Show("Valor do aluguel RENOVADO 5 meses automaticamente \nVerificar lançamentos no Hiper (Contas a receber)", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        button6.Visible = true;

                        Calculos.Calculo150SemDev();

                        button6.BackColor = Color.Red;

                        MessageBox.Show("Numero de dias ultrapassado \n Confirmar valor no sistema", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        label9.Text = "RENOVADO por 5 meses";

                        textBox4.Text = Calculos.juros.ToString("C2");
                        textBox8.Text = Calculos.valorMulta.ToString("C2");
                        textBox6.Text = Calculos.valorFinal.ToString("C2");


                    }

                    else
                    {
                        MessageBox.Show("Valor do aluguel VENCIDO A MUITO TEMPO \nVerificar lançamentos no Hiper (Contas a receber)", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ocorrido \n" + erro.Message);
            }

        }
    

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 newForm3 = new Form3();
            this.Close();
            this.Hide();
            newForm3.ShowDialog();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
                mover = false;

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

            if (mover)
            {
                this.Left += e.X - (cX - panel1.Left);
                this.Top += e.Y - (cY - panel1.Top);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       
        private void button6_Click(object sender, EventArgs e)
        {
            Process pStart = new Process();
            pStart.StartInfo = new ProcessStartInfo(@"chrome.exe","https://aloemed.hiper.com.br/financeiro/contas-a-receber");
            pStart.Start();
        }

        
        private void button7_Click(object sender, EventArgs e)
        {
            
            Process.Start("calc");
            
        }

        private void bt_ajuda_Click(object sender, EventArgs e)
        {
            var ajuda = new Ajuda();
            ajuda.Show();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                cX = e.X;
                cY = e.Y;
                mover = true;
            }

        }

    }
}
