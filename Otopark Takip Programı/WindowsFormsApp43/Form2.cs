using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace WindowsFormsApp43
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* Tahsilatı hesapladık*/ 

            if (comboBox2.SelectedIndex == 0 && checkBox1.Checked==false && checkBox2.Checked==false)
            {
                MessageBox.Show("Borcunuz yok!");
            }
            else if(comboBox2.SelectedIndex==0 && checkBox1.Checked== true && checkBox2.Checked == false)
            {
                MessageBox.Show("Borcunuz : 10 TL");
            }
            else if(comboBox2.SelectedIndex==0 && checkBox2.Checked==true && checkBox1.Checked == false)
            {
                MessageBox.Show("Borcunuz : 10 TL");
            }
            else if(comboBox2.SelectedIndex==0 && checkBox1.Checked==true && checkBox1.Checked == true)
            {
                MessageBox.Show("Borcunuz : 20 TL");
            }

            if (comboBox2.SelectedIndex == 1 && checkBox1.Checked == false && checkBox2.Checked == false)
            {
                MessageBox.Show("Borcunuz : 2 TL");
            }
            else if (comboBox2.SelectedIndex == 1 && checkBox1.Checked == true && checkBox2.Checked == false)
            {
                MessageBox.Show("Borcunuz : 12 TL");
            }
            else if (comboBox2.SelectedIndex == 1 && checkBox2.Checked == true && checkBox1.Checked == false)
            {
                MessageBox.Show("Borcunuz : 12 TL");
            }
            else if (comboBox2.SelectedIndex == 1 && checkBox1.Checked == true && checkBox1.Checked == true)
            {
                MessageBox.Show("Borcunuz : 22 TL");
            }

            if (comboBox2.SelectedIndex == 2 && checkBox1.Checked == false && checkBox2.Checked == false)
            {
                MessageBox.Show("Borcunuz : 3 TL");
            }
            else if (comboBox2.SelectedIndex == 2 && checkBox1.Checked == true && checkBox2.Checked == false)
            {
                MessageBox.Show("Borcunuz : 13 TL");
            }
            else if (comboBox2.SelectedIndex == 2 && checkBox2.Checked == true && checkBox1.Checked == false)
            {
                MessageBox.Show("Borcunuz : 13 TL");
            }
            else if (comboBox2.SelectedIndex == 2 && checkBox1.Checked == true && checkBox1.Checked == true)
            {
                MessageBox.Show("Borcunuz : 23 TL");
            }

            if (comboBox2.SelectedIndex == 3 && checkBox1.Checked == false && checkBox2.Checked == false)
            {
                MessageBox.Show("Borcunuz : 5 TL");
            }
            else if (comboBox2.SelectedIndex == 3 && checkBox1.Checked == true && checkBox2.Checked == false)
            {
                MessageBox.Show("Borcunuz : 15 TL");
            }
            else if (comboBox2.SelectedIndex == 3 && checkBox2.Checked == true && checkBox1.Checked == false)
            {
                MessageBox.Show("Borcunuz : 15 TL");
            }
            else if (comboBox2.SelectedIndex == 3 && checkBox1.Checked == true && checkBox1.Checked == true)
            {
                MessageBox.Show("Borcunuz : 25 TL");
            }

            if (comboBox2.SelectedIndex == 4 && checkBox1.Checked == false && checkBox2.Checked == false)
            {
                MessageBox.Show("Borcunuz : 10 TL");
            }
            else if (comboBox2.SelectedIndex == 4 && checkBox1.Checked == true && checkBox2.Checked == false)
            {
                MessageBox.Show("Borcunuz : 20 TL");
            }
            else if (comboBox2.SelectedIndex == 4 && checkBox2.Checked == true && checkBox1.Checked == false)
            {
                MessageBox.Show("Borcunuz : 20 TL");
            }
            else if (comboBox2.SelectedIndex == 4 && checkBox1.Checked == true && checkBox1.Checked == true)
            {
                MessageBox.Show("Borcunuz : 30 TL");
            }
            if (comboBox2.SelectedIndex == 5 && checkBox1.Checked == false && checkBox2.Checked == false)
            {
                MessageBox.Show("Borcunuz : 15 TL");
            }
            else if (comboBox2.SelectedIndex == 5 && checkBox1.Checked == true && checkBox2.Checked == false)
            {
                MessageBox.Show("Borcunuz : 25 TL");
            }
            else if (comboBox2.SelectedIndex == 5 && checkBox2.Checked == true && checkBox1.Checked == false)
            {
                MessageBox.Show("Borcunuz : 25 TL");
            }
            else if (comboBox2.SelectedIndex == 5 && checkBox1.Checked == true && checkBox1.Checked == true)
            {
                MessageBox.Show("Borcunuz : 35 TL");
            }

            if (comboBox2.SelectedIndex == 5 && checkBox1.Checked == false && checkBox2.Checked == false)
            {
                MessageBox.Show("Borcunuz : 25 TL");
            }
            else if (comboBox2.SelectedIndex == 6 && checkBox1.Checked == true && checkBox2.Checked == false)
            {
                MessageBox.Show("Borcunuz : 35 TL");
            }
            else if (comboBox2.SelectedIndex == 6 && checkBox2.Checked == true && checkBox1.Checked == false)
            {
                MessageBox.Show("Borcunuz : 35 TL");
            }
            else if (comboBox2.SelectedIndex == 6 && checkBox1.Checked == true && checkBox1.Checked == true)
            {
                MessageBox.Show("Borcunuz : 45 TL");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        public ArrayList liste = new ArrayList();
        int sayac = 0;
        private void button6_Click(object sender, EventArgs e)
        { 
          
                string ad = textBox2.Text;
                string soyad = textBox3.Text;
                string plaka = textBox5.Text;
                string marka = textBox6.Text;
                string model = textBox7.Text;
                string renk = textBox8.Text;
                string konum = comboBox1.Text;


                if (comboBox1.SelectedIndex == 0)
                {
                    konum = " A1";
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    konum = "A2";
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    konum = "A3";
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    konum = "A4";
                }
                else if (comboBox1.SelectedIndex == 4)
                {
                    konum = "A5";
                }
                else if (comboBox1.SelectedIndex == 5)
                {
                    konum = "B1";
                }
                else if (comboBox1.SelectedIndex == 6)
                {
                    konum = "B2";
                }
                else if (comboBox1.SelectedIndex == 7)
                {
                    konum = "B3";
                }
                else if (comboBox1.SelectedIndex == 8)
                {
                    konum = "B4";
                }
                else if (comboBox1.SelectedIndex == 9)
                {
                    konum = "B5";
                }
                else if (comboBox1.SelectedIndex == 10)
                {
                    konum = "C1";
                }
                else if (comboBox1.SelectedIndex == 11)
                {
                    konum = "C2";
                }
                else if (comboBox1.SelectedIndex == 12)
                {
                    konum = "C3";
                }
                else if (comboBox1.SelectedIndex == 13)
                {
                    konum = "C4";
                }
                else if (comboBox1.SelectedIndex == 14)
                {
                    konum = "C5";
                }
                else if (comboBox1.SelectedIndex == 15)
                {
                    konum = "D1";
                }
                else if (comboBox1.SelectedIndex == 16)
                {
                    konum = "D2";
                }
                else if (comboBox1.SelectedIndex == 17)
                {
                    konum = "D3";
                }
                else if (comboBox1.SelectedIndex == 18)
                {
                    konum = "D4";
                }
                else if (comboBox1.SelectedIndex == 19)
                {
                    konum = "D5";
                }

            

            if (maskedTextBox1.Text!="" && textBox2.Text != "" && textBox3.Text!="" && maskedTextBox2.Text!="" && textBox5.Text!="" && textBox6.Text!="" && textBox7.Text!="" && textBox8.Text!="" && comboBox1!= null)
            {
                if(sayac < 20)
                {

                    liste.Add((sayac + 1).ToString() + "#" + maskedTextBox1.Text + "#" + ad + "#" + soyad + "#" + maskedTextBox2.Text + "#" + plaka + "#" + marka + "#" + model + "#" + renk + "#" + konum);
                    maskedTextBox1.Text = "";
                    textBox2.Text = "";
                    maskedTextBox2.Text = "";
                    textBox3.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    comboBox1.EndUpdate();

                    sayac = sayac + 1;

                    label12.Text = sayac.ToString() + "/20";
                }
                else
                {
                    MessageBox.Show("OTOPARK DOLU!");
                }

                }
            else
            {
                MessageBox.Show("Bilgileriniz eksik!");
            }

            

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
