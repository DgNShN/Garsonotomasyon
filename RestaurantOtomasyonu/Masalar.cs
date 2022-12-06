using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOtomasyonu
{
    public partial class Masalar : Form
    {
        public Masalar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Masa1 masa1 = new Masa1();
            masa1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Masa2 masa2 = new Masa2();
            masa2.Show();
        }
    }
}
