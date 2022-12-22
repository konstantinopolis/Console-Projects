using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp40
{
    public partial class Form1 : Form
    {
        double sayi1;
        string islem;
        public Form1()
        
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* 1 butonuna basılınca textboxa 1 rakamının ekliyor .*/
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text += 1;
            }
            else
            {
                textBox1.Text += 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text += 2;
            }
            else
            {
                textBox1.Text += 2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text += 3;
            }
            else
            {
                textBox1.Text += 3;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text += 4;
            }
            else
            {
                textBox1.Text += 4;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text += 5;
            }
            else
            {
                textBox1.Text += 5;
            }
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Text += 6;

            }
            else
            {
                textBox1.Text += 6;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text += 7;
            }
            else
            {
                textBox1.Text += 7;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text += 8;
            }
            else
            {
                textBox1.Text += 8;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text += 9;
            }
            else
            {
                textBox1.Text += 9;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            /* Textboxtaki sayıyı okuyup sayi1'e atıyor.Daha sonra textboxı boşaltıyor . İşlem stringine de + dedik daha sonra 
             = için kullanacağımız butonda isleme atadığımız operatöre göre işlem yapacağız.*/
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = " ";
            islem = "+";
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            /* CE butonu için ... Textboxı boşaltıyor .*/
            textBox1.Text = " ";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = " ";
            islem = "-";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = " ";
            islem = "*";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = " ";
            islem = "/";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double sayi2;
            double sonuc;

            /* "=" butonuna basılınca öncelikle textboxa girilen ikinci sayıyı okuyor . Daha sonra işlem sırasında
             okunan operatöre (+,-,*,/) göre işlem yapılıp sonuç textboxa yazdırılıyor .*/
            sayi2 = Convert.ToDouble(textBox1.Text);

            if (islem == "+")
            {
                sonuc = sayi1 + sayi2;
                textBox1.Text = " ";
                textBox1.Text = sonuc.ToString();

            }
            else if(islem == "-"){
                sonuc = sayi1 - sayi2;
                textBox1.Text = " ";
                textBox1.Text = sonuc.ToString();
            }
            else if (islem == "*")
            {
                sonuc = sayi1 * sayi2;
                textBox1.Text = " ";
                textBox1.Text = sonuc.ToString();
            }
            else if (islem == "/")
            {
                sonuc = sayi1 / sayi2;
                textBox1.Text = " ";
                textBox1.Text = sonuc.ToString();
            }
            else
            {
                textBox1.Text = " ";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
