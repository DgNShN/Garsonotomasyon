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
    public partial class Masa1 : Form
    {
        public Masa1()
        {
            InitializeComponent();
        }
        public static double Viski = 300, Tekila = 250, Cin = 150, Kola = 50, RedLabel = 190, Fanta = 40, TekirDag = 280, Rakı = 200, Chivas = 275, Kanyak = 100,
            Bira = 90, KucukBol = 60, OrtaBol = 120, BuyukBol = 180, VısneSuyu = 20, PortakalSuyu = 25, JackDaniels = 350, Jp = 210, Smirnof = 280, AbsolutVodka = 340,
            Elma1Porsiyon = 40, Portakal1Porsıyon = 25, Ayva1Porsiyon = 30, Karpuz1Porsiyon = 35, Kavun1Porsiyon = 35, Mandalina1Porsiyon = 35, CamFıstığı = 80, Fıstık = 40, Fındık = 40, Badem = 60,
            BeyazPeynir = 40, EskiKasar = 50, KuruEtPrsyn = 80, PirzolaPrsyn = 100, KanatPrsyn = 80, TavukPirzola = 60, CobanKavurmaBüyükboy = 200, CobanKavurmaOrtaBoy = 150, ÇobanKavurmaKüçük = 100,
            Salata = 60, Çorba = 50, AcılıEzme = 60, Beyin = 60, Haydari = 50, Cacık = 40, BallıMuz = 60, BallıKivi = 50, Saksuka = 20, RedBul = 80, ElmaSuyu = 50, Soda = 50, BallıNar = 50,
            KarışıkIzgaraPrsyn = 125, Likör = 60, Garsoniye = 20, Ekmek = 20, Su = 20, KalamarTava = 80, HamsiTava = 65, Sövüs = 25;

        private void button51_Click(object sender, EventArgs e)
        {
            Garsoniye = 20;
            listBox1.Items.Add(Garsoniye = 20);
        }

        private void button50_Click(object sender, EventArgs e)
        {
            BeyazPeynir = 40;
            listBox1.Items.Add(BeyazPeynir = 40);
        }

        private void button49_Click(object sender, EventArgs e)
        {
            Beyin = 60;
            listBox1.Items.Add(Beyin = 60);
        }

        private void button48_Click(object sender, EventArgs e)
        {
            Sövüs = 25;
            listBox1.Items.Add(Sövüs = 25);
        }

        private void button47_Click(object sender, EventArgs e)
        {
            AcılıEzme = 60;
            listBox1.Items.Add(AcılıEzme = 60);
        }

        private void button46_Click(object sender, EventArgs e)
        {
            Cacık = 40;
            listBox1.Items.Add(Cacık = 40);
        }

        private void button45_Click(object sender, EventArgs e)
        {
            Haydari = 50;
            listBox1.Items.Add(Haydari = 50);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            EskiKasar = 50;
            listBox1.Items.Add(EskiKasar = 50);
        }

        private void button43_Click(object sender, EventArgs e)
        {
            KuruEtPrsyn = 80;
            listBox1.Items.Add(KuruEtPrsyn = 80);
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
           
        }

        private void button42_Click(object sender, EventArgs e)
        {
            KarışıkIzgaraPrsyn = 125;
            listBox1.Items.Add(KarışıkIzgaraPrsyn = 125);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            Ekmek = 20;
            listBox1.Items.Add(Ekmek = 20);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            Çorba = 50;
            listBox1.Items.Add(Çorba = 50);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            ÇobanKavurmaKüçük = 100;
            listBox1.Items.Add(ÇobanKavurmaKüçük = 100);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            CobanKavurmaOrtaBoy = 150;
            listBox1.Items.Add(CobanKavurmaOrtaBoy=150);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            CobanKavurmaBüyükboy = 200;
            listBox1.Items.Add(CobanKavurmaBüyükboy);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            KanatPrsyn = 80;
            listBox1.Items.Add(KanatPrsyn);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            TavukPirzola = 60;
            listBox1.Items.Add(TavukPirzola);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            PirzolaPrsyn = 100;
            listBox1.Items.Add(PirzolaPrsyn);   
        }

        private void button39_Click(object sender, EventArgs e)
        {
            KalamarTava = 80;
            listBox1.Items.Add(KalamarTava = 80);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Badem = 60;
            listBox1.Items.Add(Badem);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            CamFıstığı = 80;
            listBox1.Items.Add(CamFıstığı);
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

        private void button30_Click(object sender, EventArgs e)
        {
            BallıNar = 50;
            listBox1.Items.Add(BallıNar);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            BallıKivi = 50;
            listBox1.Items.Add(BallıKivi);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            BallıMuz = 60;
            listBox1.Items.Add(BallıMuz);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Mandalina1Porsiyon = 35;
            listBox1.Items.Add(Mandalina1Porsiyon);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Ayva1Porsiyon = 30;
            listBox1.Items.Add(Ayva1Porsiyon);  
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Kavun1Porsiyon = 35;
            listBox1.Items.Add(Kavun1Porsiyon);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Karpuz1Porsiyon = 35;
            listBox1.Items.Add(Karpuz1Porsiyon);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Portakal1Porsıyon = 25;
            listBox1.Items.Add(Portakal1Porsıyon);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Bira = 90;
            listBox1.Items.Add(Bira);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            JackDaniels = 350;
            listBox1.Items.Add(JackDaniels);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
    
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Smirnof = 280;
            listBox1.Items.Add (Smirnof);
        
        }

        private void button19_Click(object sender, EventArgs e)
        {
            PortakalSuyu = 25;
            listBox1.Items.Add( PortakalSuyu);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            VısneSuyu = 20;
            listBox1.Items.Add(VısneSuyu);
        }
        private void button17_Click(object sender, EventArgs e)
        {
            AbsolutVodka = 340;
            listBox1.Items.Add( AbsolutVodka);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            BuyukBol = 180;
            listBox1.Items.Add(BuyukBol);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            OrtaBol = 120;
            listBox1.Items.Add(  OrtaBol);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            KucukBol = 60;
           listBox1.Items.Add( KucukBol);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Jp = 210;
            listBox1.Items.Add( Jp);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Kanyak = 100;
            listBox1.Items.Add(  Kanyak);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Chivas = 275;
            listBox1.Items.Add(  Chivas);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RedLabel = 190;
            listBox1.Items.Add( RedLabel);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TekirDag = 280;
            listBox1.Items.Add( TekirDag);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Fanta = 40;
            listBox1.Items.Add( Fanta);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Kola = 50;
            listBox1.Items.Add(  Kola);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Rakı = 200;
            listBox1.Items.Add(  Rakı);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cin = 150;
            listBox1.Items.Add( Cin);
        }

        private void button2_Click(object sender, EventArgs e)
        {
        Tekila= 250;
            listBox1.Items.Add(  Tekila);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Viski = 300;
            listBox1.Items.Add(  Viski);
        }
    }
}
