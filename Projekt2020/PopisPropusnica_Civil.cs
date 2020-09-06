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
    public partial class PopisPropusnica_Civil : Form
    {
        public string oib;
       

        List<Civil> popis_odobreno = new List<Civil>();
        List<Civil> popis_obrada = new List<Civil>();
        List<Civil> popis_odbijeno = new List<Civil>();
        public PopisPropusnica_Civil(string a)
        {
            InitializeComponent();
            oib = a;
            popuni_obrada();
            popuni_odobreno();

            popuni_odbijeno();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PopisPropusnica_Civil_Load(object sender, EventArgs e)
        {

        }
        void popuni_odobreno() {

            var con = Baza.konekcija();
            con.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Propusnica where napravio="+oib+" and odobreno =1 ", con);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Civil odobreno = new Civil(oib);
                odobreno.oib = (string)reader["oib"];
                odobreno.ime = (string)reader["ime"];
                odobreno.prezime = (string)reader["prezime"];
                odobreno.mjestood = (string)reader["mjesto_od"];
                odobreno.mjestodo = (string)reader["mjesto_do"];
                odobreno.datumod = (string)reader["datumod"];
                odobreno.razlog = (string)reader["razlog"];
                odobreno.datumdo = (string)reader["datumdo"];

                popis_odobreno.Add(odobreno);

                foreach (var s in popis_odobreno)
            {
                    string[] red = { s.oib, s.ime, s.prezime, s.mjestood, s.mjestodo, s.datumod, s.datumdo, s.razlog.ToString() };
                var prenosioc = new ListViewItem(red);
                listView1.Items.Add(prenosioc);
            }
            
        }
    }

        void popuni_obrada()
        {

            var con = Baza.konekcija();
            con.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Propusnica where napravio=" + oib + " and odobreno =0 ", con);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Civil obrada = new Civil(oib);
                obrada.oib = (string)reader["oib"];
                obrada.ime = (string)reader["ime"];
                obrada.prezime = (string)reader["prezime"];
                obrada.mjestood = (string)reader["mjesto_od"];
                obrada.mjestodo = (string)reader["mjesto_do"];
                obrada.datumod = (string)reader["datumod"];
                obrada.razlog = (string)reader["razlog"];
                obrada.datumdo = (string)reader["datumdo"];
                popis_odobreno.Add(obrada);

                foreach (var s in popis_odobreno)
                {
                    string[] red = { s.oib, s.ime, s.prezime, s.mjestood, s.mjestodo, s.datumod, s.datumdo, s.razlog };
                    var prenosioc = new ListViewItem(red);
                    listView2.Items.Add(prenosioc);
                }

            }


        }

        void popuni_odbijeno()
        {

            var con = Baza.konekcija();
            con.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Propusnica where napravio=" + oib + " and odobreno =2 ", con);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Civil odbijeno = new Civil(oib);
                odbijeno.oib = (string)reader["oib"];
                odbijeno.ime = (string)reader["ime"];
                odbijeno.prezime = (string)reader["prezime"];
                odbijeno.mjestood = (string)reader["mjesto_od"];
                odbijeno.mjestodo = (string)reader["mjesto_do"];
                odbijeno.datumod = (string)reader["datumod"];

                odbijeno.datumdo = (string)reader["datumdo"];
                popis_odobreno.Add(odbijeno);

                foreach (var s in popis_odobreno)
                {
                    string[] red = { s.oib, s.ime, s.prezime, s.mjestood, s.mjestodo, s.datumod, s.datumdo, s.razlog };
                    var prenosioc = new ListViewItem(red);
                    listView3.Items.Add(prenosioc);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Civil otvori = new Civil(oib);
            otvori.Show();
        }
    }
}
