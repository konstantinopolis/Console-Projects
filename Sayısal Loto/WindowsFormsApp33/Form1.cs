using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApp33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);
            double sayi3 = Convert.ToDouble(textBox3.Text);
            double sayi4 = Convert.ToDouble(textBox4.Text);
            double sayi5 = Convert.ToDouble(textBox5.Text);
            double sayi6 = Convert.ToDouble(textBox6.Text);

            /*Kullanıcıdan 6 sayi alınıyor . Bu sayıların 1 ve 49 arasında olması gerekiyor . Eğer bu aralıkta değilse uyarı veriliyor .*/

            if (sayi1 < 0 || sayi1 > 49)
            {
                MessageBox.Show("1 ile 49 arasında sayılar girmeniz gerekiyor.");
                
            }
            else if (sayi2 < 0 || sayi2 > 49)
            {
                MessageBox.Show("1 ile 49 arasında sayılar girmeniz gerekiyor.");
            }
            else if (sayi3 < 0 || sayi3 > 49)
            {
                MessageBox.Show("1 ile 49 arasında sayılar girmeniz gerekiyor .");
            }
            else if (sayi4 < 0 || sayi4 > 49)
            {
                MessageBox.Show("1 ile 49 arasında sayılar girmeniz gerekiyor.");
            }
            else if (sayi5 < 0 || sayi5> 49)
            {
                MessageBox.Show("1 ile 49 arasında sayılar girmeniz gerekiyor.");
            }
            else if (sayi6 < 0 || sayi6 > 49)
            {
                MessageBox.Show("1 ile 49 arasında sayılar girmaniz gerekiyor .");
            }


            double[] sayilar = new double[6];
            double[] sayilar2 = new double[6];
            sayilar[0] = sayi1;
            sayilar[1] = sayi2;
            sayilar[2] = sayi3;
            sayilar[3] = sayi4;
            sayilar[4] = sayi5;
            sayilar[5] = sayi6;

            /* sayılar ve sayılar2 adlarında iki farklı dizi olusturdum . sayılar dizisinin içine ekrandan almış olduğum sayıları sırasıyla aktardım.
             sayılar2 dizisine ise random sayıları sırasıyla attım. */

            Random rnd = new Random();
            int i,j,tutan=0,sayi;

            for (j = 0; j < sayilar2.Length; j++)
            {
                sayi = rnd.Next(1, 49);
                sayilar2[j] = sayi;
            }


            label8.Text = sayilar2[0].ToString();
            label9.Text = sayilar2[1].ToString();
            label10.Text = sayilar2[2].ToString();
            label11.Text = sayilar2[3].ToString();
            label12.Text = sayilar2[4].ToString();
            label13.Text = sayilar2[5].ToString();

            /*Oluşturdum sayilar2 dizisinin elemanlarını sırasıyla labellara yerleştirdim.  */


            /* Daha sonra bir tutan adında bir sayaç tanımladım . Sayilar ve Sayilar2 dizilerinin elemanlarını karşılaştırıp eğer 
             aynı sayılar varsa sayacı artırdım.*/

            for (i = 0; i < sayilar.Length; i++)
            {
                for (j = 0; j < sayilar2.Length; j++)
                {
                    if (sayilar[i] == sayilar2[j])
                    {
                        tutan++;
                    }
                   
                }
            }
            
            /*Tanımladığım tutan adındaki sayacıma göre kullanıcının sayısal lotoyu kazanıp kazanamadığını bulup ekrana MessageBox olarak yazdırdım ...*/


            if (tutan >= 3)
            {
                MessageBox.Show("Tebrikler " + tutan + " tutturdunuz!!");
            }
            else
            {
                MessageBox.Show("Talihsiz gününüzdesiniz :( ..");
            }
        }
    }
}
