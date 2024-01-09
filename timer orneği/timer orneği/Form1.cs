using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer_orneği
{
    public partial class Form1 : Form
    {
        int sayac=0;
        DateTime zaman2 = new DateTime(2024, 01, 09, 11, 30,0);
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            timer1.Start();
            this.BackColor = Color.GreenYellow;
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            // sayac--;
            // lblSayac.Text = sayac.ToString();
            // if (sayac <= 0)
            // {
            //  timer1.Stop();
            //
            //this.BackColor = Color.Red;
            TimeSpan fark = zaman2 - DateTime.Now;            
            lblSayac.Text= $"{fark.Minutes} : {fark.Seconds}";
        }
    }
}
