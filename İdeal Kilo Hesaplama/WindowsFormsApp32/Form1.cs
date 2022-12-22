using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* Girilen tüm bilgileri sıfırlıyor. */

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            comboBox1.SelectedItem = null;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string soyad = textBox2.Text;
            double yas = Convert.ToDouble(textBox3.Text);
            double boy = Convert.ToDouble(textBox4.Text);
            double kilo = Convert.ToDouble(textBox5.Text);
            double hesapla;
            double fazlalik;

            /* Comboboxın sıfırıncı indexinde kadın birinci indexinde ise erkek seçenegi var . Kadınlarda ve erkeklerde farklı farklı k 
              katsayıları kullanılıyor .*/
            if (comboBox1.SelectedIndex==0)
            {
                hesapla = (boy - 100 + yas / 10) * 0.8;
                textBox6.Text = hesapla.ToString();
                fazlalik = kilo - hesapla;
                
                textBox6.Text = hesapla.ToString();

                /*Bilgileri alınan kişinin şu anki kilosu ve olması gereken kilosu karşılaştırılıyor.*/

                if (kilo > hesapla)
                {
                    label9.Text = "Şişmansın!" + fazlalik + " kilo fazlan var";
                }
                else if (kilo == hesapla)
                {
                    label9.Text = "İdeal kilodasın...";
                }
                else if (kilo < hesapla)
                {
                    label9.Text = "Zayıfsın! İdeal kilona ulaşmak için " + fazlalik + "  kilo almalısın";
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                hesapla = (boy - 100 + yas / 10) * 0.9;
                textBox6.Text = hesapla.ToString();
                fazlalik = kilo - hesapla;

                textBox6.Text = hesapla.ToString();

                if(kilo > hesapla)
                {
                    label9.Text = "Şişmansın!" + fazlalik + " kilo fazlan var";
                }
                else if (kilo == hesapla)
                {
                    label9.Text = "İdeal kilodasın...";
                }
                else if (kilo < hesapla)
                {
                    label9.Text = "Zayıfsın! İdeal kilona ulaşmak için " + fazlalik + "  kilo almalısın";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
