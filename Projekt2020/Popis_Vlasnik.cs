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
    public partial class Popis_Vlasnik : Form
    {

        public string oib;
        List<Vlasnik_poduzeca> popis = new List<Vlasnik_poduzeca>();

        public Popis_Vlasnik(string a)
        {
            InitializeComponent();
            oib = a;
            popis_popuni();
        }

        private void Popis_Vlasnik_Load(object sender, EventArgs e)
        {

        }

        void popis_popuni()
        {

            var con = Baza.konekcija();
            con.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Propusnica where napravio=" + oib + " and odobreno =1 ", con);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Vlasnik_poduzeca odobreno = new Vlasnik_poduzeca(oib);
                odobreno.oib = (string)reader["oib"];
                odobreno.ime = (string)reader["ime"];
                odobreno.prezime = (string)reader["prezime"];
                odobreno.mjestood = (string)reader["mjesto_od"];
                odobreno.mjestodo = (string)reader["mjesto_do"];
                odobreno.datumod = (string)reader["datumod"];
                odobreno.razlog = (string)reader["razlog"];
                odobreno.datumdo = (string)reader["datumdo"];

                popis.Add(odobreno);

                foreach (var s in popis)
                {
                    string[] red = { s.oib, s.ime, s.prezime, s.mjestood, s.mjestodo, s.datumod, s.datumdo, s.razlog.ToString() };
                    var prenosioc = new ListViewItem(red);
                    listView1.Items.Add(prenosioc);
                }

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
