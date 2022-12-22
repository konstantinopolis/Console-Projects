using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vize1 = Convert.ToDouble(textBox1.Text); 
            double vize2 = Convert.ToDouble(textBox2.Text);
            double final = Convert.ToDouble(textBox3.Text);
            double ortalama = (vize1 * 0.3) + (vize2 * 0.3) + (final *0.4); // final ve vize notlarının etki yüzdeleriyle ortalamayı hesaplıyoruz .

            // Ortalamaya göre karşılaştırma yapıp harf notunu hesaplıyoruz.

            if(ortalama>=90 && ortalama <= 100)
            {
                MessageBox.Show("Ortalama:"+ ortalama + "Harf Notu : AA");
            }
            else if(ortalama>=85 && ortalama <= 89)
            {
                MessageBox.Show("Ortalama :" + ortalama + "Harf Notu : BA");
            }
            else if(ortalama>=80 && ortalama <= 84)
            {
                MessageBox.Show("Ortalama :" + ortalama + " Harf Notu : BB");
            }
            else if(ortalama>=75 && ortalama <= 79)
            {
                MessageBox.Show("Ortalama : " + ortalama + "Harf Notu : CB"); 
            }
            else if(ortalama>=65 && ortalama <= 74)
            {
                MessageBox.Show("Ortalama :" + ortalama + "Harf Notu : CC");
            }
            else if(ortalama>=60 && ortalama <= 64)
            {
                MessageBox.Show("Ortalama :" + ortalama + "Harf Notu : DC");
            }
            else if(ortalama>=50 && ortalama <= 59)
            {
                MessageBox.Show("Ortalama : " + ortalama + "Harf Notu : DD");
            }
            else if (ortalama <= 49)
            {
                MessageBox.Show("Ortalama :" + ortalama + "Harf Notu : FF");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
