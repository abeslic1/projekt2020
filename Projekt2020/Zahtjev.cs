﻿using System;
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
    public partial class Zahtjev : Form
    {
        public string oib;
        public Zahtjev(string a)
        {
            InitializeComponent();
            oib = a;
            popuni();
        }

        void popuni()
        {
            var con = Baza.konekcija();
            con.Open();
            string izvadi = "select * from  Osoba where oib ="+oib+"";
            SqlCommand izvadi_cmd = new SqlCommand(izvadi, con);
            SqlDataReader citac;
            citac = izvadi_cmd.ExecuteReader();


            while (citac.Read())
            {

                textBox1.Text= (citac["Oib"].ToString());
                textBox2.Text = (citac["Ime"].ToString());
                textBox3.Text = (citac["Prezime"].ToString());
               
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var con = Baza.konekcija();

            con.Open();




            string zadatak = "INSERT INTO Propusnica (oib,ime,prezime,mjesto_od,mjesto_do,razlog,odobreno,datumod,datumdo,napravio)  VALUES('" + this.textBox1.Text + "' ,'" + this.textBox2.Text + "' , ' " + this.textBox3.Text + "' , '" + this.textBox4.Text + "','" + this.textBox5.Text + "','" + this.textBox6.Text + "', 0,'" + this.dateTimePicker1.Text + "','" + this.dateTimePicker2.Text+ "',"+oib+");";
            SqlCommand cmd = new SqlCommand(zadatak, con);

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Zahtjev poslan na obradu");
            this.Hide();
            Civil otvori = new Civil(oib);
            otvori.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Civil otvori = new Civil(oib);
            otvori.Show();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }

        

        
    
}
