using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3v3podejscie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         DaneWejsc.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DaneWejsc.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DaneWejsc.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DaneWejsc.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DaneWejsc.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DaneWejsc.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DaneWejsc.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DaneWejsc.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DaneWejsc.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DaneWejsc.Text += "0";
        }
        int pamiecKalkulatora = 0;
      

        private void button11_Click_1(object sender, EventArgs e)
        {
            int wprowadzonaWartosc = int.Parse(DaneWejsc.Text);
            pamiecKalkulatora += wprowadzonaWartosc;
            DaneWyjsciowe.Text = pamiecKalkulatora.ToString();
            DaneWejsc.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int wprowadzonaWartosc = int.Parse(DaneWejsc.Text);
            pamiecKalkulatora -= wprowadzonaWartosc;
            DaneWyjsciowe.Text = pamiecKalkulatora.ToString();
            DaneWejsc.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }
    }
}
