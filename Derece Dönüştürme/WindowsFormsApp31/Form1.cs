using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* Fahrenaty hesabı yapacak buton */

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(textBox1.Text);
            double fahrenayt = (sayi * 9 / 5) + 32;
            textBox2.Text = fahrenayt.ToString();

        }

        /* Santigrad hesabı yapacak buton */

        private void button2_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(textBox1.Text);
            double santigrad = (sayi - 32) * 5 / 9;
            textBox2.Text = santigrad.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
