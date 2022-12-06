using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOtomasyonu
{
    public partial class Masa2 : Form
    {
        public Masa2()
        {
            InitializeComponent();
        }
        public static double Viski = 300, Tekila = 250, Cin = 150, Kola = 50, RedLabel = 190, Fanta = 40, TekirDag = 280, Rakı = 200, Chivas = 275, Kanyak = 100,
            Bira = 90, KucukBol = 60, OrtaBol = 120, BuyukBol = 180, VısneSuyu = 20, PortakalSuyu = 25, JackDaniels = 350, Jp = 210, Smirnof = 280, AbsolutVodka = 340;

      

        private void button2_Click_1(object sender, EventArgs e)
        {
            Tekila = 250;
            listBox1.Items.Add(Tekila);
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            double toplam = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {

                toplam += Convert.ToDouble(listBox1.Items[i]);
                label1.Text = "Toplam : " + toplam;

                toplam = Convert.ToDouble(toplam);
            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Cin = 150;
            listBox1.Items.Add(Cin);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Rakı = 200;
            listBox1.Items.Add(Rakı);
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            PortakalSuyu = 25;
            listBox1.Items.Add(PortakalSuyu);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Kola = 50;
            listBox1.Items.Add(Kola);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Fanta = 40;
            listBox1.Items.Add(Fanta);
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            TekirDag = 280;
            listBox1.Items.Add(TekirDag);
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            RedLabel = 190;
            listBox1.Items.Add(RedLabel);
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Chivas = 275;
            listBox1.Items.Add(Chivas);
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            Kanyak = 100;
            listBox1.Items.Add(Kanyak);
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            Jp = 210;
            listBox1.Items.Add(Jp);
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            KucukBol = 60;
            listBox1.Items.Add(KucukBol);
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            OrtaBol = 120;
            listBox1.Items.Add(OrtaBol);
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            BuyukBol = 180;
            listBox1.Items.Add(BuyukBol);
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            AbsolutVodka = 340;
            listBox1.Items.Add(AbsolutVodka);
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            VısneSuyu = 20;
            listBox1.Items.Add(VısneSuyu);
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            JackDaniels = 350;
            listBox1.Items.Add(JackDaniels);
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            Smirnof = 280;
            listBox1.Items.Add(Smirnof);
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            Bira = 90;
            listBox1.Items.Add(Bira);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Viski = 300;
            listBox1.Items.Add(Viski);
        }
    }
}
