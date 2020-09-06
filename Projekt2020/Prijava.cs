using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projekt2020
{
    public partial class Prijava : Form
    {

        public  string oib;
        public Prijava()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            oib = textBox1.Text; 
            var con = Baza.konekcija();
            con.Open();
            SqlDataAdapter c = new SqlDataAdapter("select count(*) from Osoba where OIB=" + this.textBox1.Text + "and prava='c'", con);
            DataTable dt_c = new DataTable();
            c.Fill(dt_c);
            if (dt_c.Rows[0][0].ToString() == "1")
            {
                Civil otvori = new Civil(oib);
                this.Hide();
                otvori.Show();

            }

            else
            {
                SqlDataAdapter prijava_v = new SqlDataAdapter("select count(*) from Osoba where oib=" + textBox1.Text + " and prava = 'v'", con);
                DataTable dt_v = new DataTable();
                prijava_v.Fill(dt_v);
                if (dt_v.Rows[0][0].ToString() == "1")
                {
                    Vlasnik_poduzeca otvori = new Vlasnik_poduzeca(oib);
                    this.Hide();
                    otvori.Show();

                }
            }
            SqlDataAdapter prijava_s = new SqlDataAdapter("select count(*) from Osoba where oib=" + textBox1.Text + " and prava= 's'", con);
            DataTable dt_s = new DataTable();
            prijava_s.Fill(dt_s);
            if (dt_s.Rows[0][0].ToString() == "1")
            {
                Obradi otvori = new Obradi();
                this.Hide();
                otvori.Show();

            }

        }
    }
}
