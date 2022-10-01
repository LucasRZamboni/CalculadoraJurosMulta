using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoJuros
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private bool mover;
        private int cX, cY;
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 newForm1 = new Form1();
            this.Hide(); 
            newForm1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 newForm2 = new Form2();
            this.Hide();
            newForm2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
