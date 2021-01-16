using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioFinalAlvaro
{
    public partial class Form1 : Form
    {
        int passoDeixa = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                checkBox2.Checked = false;
            else checkBox1.Checked = true;
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                checkBox1.Checked = false;
            else 
                checkBox2.Checked = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (passoDeixa == 0)
            {
                pictureBox4.Visible = true;
                if (checkBox1.Checked) pictureBox4.Image = pictureBox1.Image;
                if (checkBox2.Checked) pictureBox4.Image = pictureBox2.Image;
                pictureBox3.Visible = true;
                label1.Visible = true;
                label1.Text = "Olá";
                passoDeixa++;
            }
            else if (passoDeixa == 1)
            {
                label1.Text = "Eu sou \n " + textBox1.Text;
                passoDeixa++;
            }
            else if (passoDeixa == 2)
            {
                label1.Text = "Está pronto \n Parabéns";
                passoDeixa++;
            }
            else if (passoDeixa == 3)
            {
                label1.Text = "Se tiveres\n tempo podes";
                passoDeixa++;
            }
            else if (passoDeixa == 4)
            {
                label1.Text = "validar os\nvaloresInseridos\nnas Textbox";
                //passoDeixa++;
            }
            else label1.Text = "algo correu mal";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valorPulse;
            int.TryParse(textBox2.Text, out valorPulse);

            timer1.Interval = valorPulse;
            timer1.Enabled = true;
            passoDeixa = 0;
        }

        private void textBox2_KeyPres(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&(e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
