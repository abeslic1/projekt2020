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

namespace Projekt2020
{
    
    public partial class Vlasnik_poduzeca : Form
    {
        public string oib, ime, prezime, mjestood, mjestodo, datumod, datumdo, razlog;

        private void button3_Click_1(object sender, EventArgs e)
        {

            Prijava otvori = new Prijava();
            otvori.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Popis_Vlasnik otvori = new Popis_Vlasnik(oib);

            otvori.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Nova_vlasnik otvori = new Nova_vlasnik(oib);
            otvori.Show();
        }

        

        public Vlasnik_poduzeca(string a)
        {
            InitializeComponent();
            oib = a;
        }

       
    }
}
