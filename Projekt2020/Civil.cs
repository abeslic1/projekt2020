using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt2020
{
    public partial class Civil : Form
    {
        public string oib, ime, prezime, mjestood, mjestodo, datumod, datumdo, razlog, a;

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Prijava otvori = new Prijava();
            otvori.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            PopisPropusnica_Civil otvori = new PopisPropusnica_Civil(oib);
            otvori.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Zahtjev otvori = new Zahtjev(oib);
            otvori.Show();

        }

       

        public Civil(string a)
        {
            InitializeComponent();
            oib = a;
        }

       
    }
}
