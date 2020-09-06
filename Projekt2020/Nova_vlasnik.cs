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
    public partial class Nova_vlasnik : Form
    {
        public string oib;
        public Nova_vlasnik(string a)
        {
            InitializeComponent();
            oib = a;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var con = Baza.konekcija();
            
            con.Open();
            SqlDataAdapter c = new SqlDataAdapter("select count(*) from Vlasnik_radnik where oib_radnika=" + this.textBox1.Text + "and oib_vlasnika='"+oib+"'", con);
            DataTable dt_c = new DataTable();
            c.Fill(dt_c);
            if (dt_c.Rows[0][0].ToString() == "1")
            {

                string izvadi = "select * from  Osoba where oib =" + textBox1.Text + "";
                SqlCommand izvadi_cmd = new SqlCommand(izvadi, con);
                SqlDataReader citac;
                citac = izvadi_cmd.ExecuteReader();


                while (citac.Read())
                {


                    textBox2.Text = (citac["Ime"].ToString());
                    textBox3.Text = (citac["Prezime"].ToString());

                }

            }
            else MessageBox.Show("Ne postoji radnik u vasoj tvrtki s tim OIB-om");

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var con = Baza.konekcija();
            con.Open();




            string zadatak = "INSERT INTO Propusnica (oib,ime,prezime,mjesto_od,mjesto_do,razlog,odobreno,datumod,datumdo,napravio)  VALUES('" + this.textBox1.Text + "' ,'" + this.textBox2.Text + "' , ' " + this.textBox3.Text + "' , '" + this.textBox4.Text + "','" + this.textBox5.Text + "','" + this.textBox6.Text + "', 1,'" + this.dateTimePicker1.Text + "','" + this.dateTimePicker2.Text + "',"+oib+");";
            SqlCommand cmd = new SqlCommand(zadatak, con);

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Propusnica napravljena");
            this.Hide();
            Vlasnik_poduzeca otvori = new Vlasnik_poduzeca(oib);
            otvori.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vlasnik_poduzeca otvori = new Vlasnik_poduzeca(oib);
            otvori.Show();
        }
    }
}
