using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RestaurantOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int Viski, Tekila, Cin, YeniRakı;


        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Minimum = 0;
            numericUpDown1.Maximum = 1000;
            numericUpDown2.Minimum = 0;
            numericUpDown2.Maximum = 1000;
            numericUpDown3.Minimum = 0;
            numericUpDown3.Maximum = 1000;
            numericUpDown4.Minimum = 0;
            numericUpDown4.Maximum = 1000;
            numericUpDown1.Increment = 200;
            numericUpDown2.Increment = 300;
            numericUpDown3.Increment = 100;
            numericUpDown4.Increment = 175;
        }


        private void button6_Click(object sender, EventArgs e)
        {
            Cin = 200;
          listBox1Urunler.Items.Add(Cin);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YeniRakı = 150;
            listBox1Urunler.Items.Add(YeniRakı);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double toplam = 0;
            for (int i = 0; i < listBox1Urunler.Items.Count; i++)
            {
                toplam += Convert.ToDouble(listBox1Urunler.Items[i]);
            }
            label6.Text = "Toplam : " + toplam;
            toplam=Convert.ToDouble(toplam);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1Urunler.Items.Clear();
        }

        private void AlkolsuzTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Masalar masalar = new Masalar();
            masalar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double numopdwn1, numopdwn2, numopdwn3, numopdwn4, Toplam;
            numopdwn1 = Convert.ToDouble(numericUpDown1.Value);
            numopdwn2 = Convert.ToDouble(numericUpDown2.Value);
            numopdwn3 = Convert.ToDouble(numericUpDown3.Value);
            numopdwn4 = Convert.ToDouble(numericUpDown4.Value);

            Toplam = numopdwn1 + numopdwn2 + numopdwn3 + numopdwn4;
            listBox1Urunler.Items.Add(numopdwn1);
            listBox1Urunler.Items.Add(numopdwn2);
            listBox1Urunler.Items.Add(numopdwn3);
            listBox1Urunler.Items.Add(numopdwn4);

            Toplam = Convert.ToDouble(Toplam);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            int Viski = 300, Tekila = 250, Cin = 200, YeniRakı = 150, sonuc;
            Viski = 300;
            listBox1Urunler.Items.Add(Viski);
            sonuc = Viski + Tekila;
            sonuc = Tekila + Cin;
            sonuc = Viski + Cin;
            sonuc = Tekila + YeniRakı;

            sonuc.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Tekila = 250;
            listBox1Urunler.Items.Add(Tekila);
        }

    }
}
