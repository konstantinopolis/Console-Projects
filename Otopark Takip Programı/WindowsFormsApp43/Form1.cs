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

namespace WindowsFormsApp43
{
    public partial class Form1 : Form
    {
        
    public Form1()
        {
          

            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*Çıkış yapmak için */
            this.Close();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Dosya açmak için*/
            string path = Environment.CurrentDirectory + "/" + "otopark.txt";
            if (!File.Exists(path))
            {
                File.CreateText(path);
            }

            /*Dosyadaki yazanları okuyup messageboxta gösterecek .*/

            string readfile = File.ReadAllText(path);
            MessageBox.Show(readfile);
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*Araç bilgilerinin girileceği forma geçiş yapar. */
            Form2 f2 = new Form2();

            f2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /* Araç yerlerinin gösterildiği forma geçiş yapar. */
            Form3 f3 = new Form3();

            f3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*otopark adında bir dosya oluşturduk .*/
            string path = Application.StartupPath.ToString() + "\\otopark.txt";
            FileStream dosya = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter yaz = new StreamWriter(dosya);

            Form2 f2 = (Form2)Application.OpenForms["Form2"];

            if (!File.Exists(path))
            {
                File.CreateText(path);
            }

            f2.liste.Remove(null);
            foreach(string i in f2.liste)
            {
                
                yaz.WriteLine(i);
            }

            yaz.Close();
            dosya.Close();
            

            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
