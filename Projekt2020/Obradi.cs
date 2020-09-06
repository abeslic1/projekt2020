using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Text;

using System.Windows.Forms;

using System.Data.SqlClient;

namespace Projekt2020
{
    public partial class Obradi : Form
    {
        public Obradi()
        {
            InitializeComponent();
        }

        private void Obradi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projektDataSet1.Propusnica' table. You can move, or remove it, as needed.
            this.propusnicaTableAdapter1.Fill(this.projektDataSet1.Propusnica);
            

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.propusnicaTableAdapter.FillBy(this.projektDataSet.Propusnica);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var con = Baza.konekcija();
            con.Open();



            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            string zadatak = "UPDATE  Propusnica set odobreno=1 where broj ="+selectedRow.Cells["broj"].Value+"";
            SqlCommand cmd = new SqlCommand(zadatak, con);

            cmd.ExecuteNonQuery();

            selectedRow.Cells["odobreno"].Value = 1;


            con.Close();

            MessageBox.Show("Propusnica odobrena");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var con = Baza.konekcija();
            con.Open();



            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            string zadatak = "UPDATE  Propusnica set odobreno=2 where broj =" + selectedRow.Cells["broj"].Value + "";
            SqlCommand cmd = new SqlCommand(zadatak, con);

            cmd.ExecuteNonQuery();
            this.dataGridView1.EndEdit();
            this.dataGridView1.Refresh();
            selectedRow.Cells["odobreno"].Value = 2;
            con.Close();
            dataGridView1.Update();
            dataGridView1.Refresh();
            MessageBox.Show("Propusnica odbijena");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Prijava otvori = new Prijava();
            otvori.Show();
            this.Hide();
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.propusnicaTableAdapter.FillBy1(this.projektDataSet.Propusnica);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.propusnicaTableAdapter.FillBy2(this.projektDataSet.Propusnica);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy3ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.propusnicaTableAdapter.FillBy3(this.projektDataSet.Propusnica);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void odobravanjeToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.propusnicaTableAdapter.Odobravanje(this.projektDataSet.Propusnica);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy4ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.propusnicaTableAdapter.FillBy4(this.projektDataSet.Propusnica);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void prikazi_samo_one_u_obradiToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.propusnicaTableAdapter.Prikazi_samo_one_u_obradi(this.projektDataSet.Propusnica);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void neobrađaneToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.propusnicaTableAdapter.Neobrađane(this.projektDataSet.Propusnica);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void odbijeneToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.propusnicaTableAdapter.Odbijene(this.projektDataSet.Propusnica);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void odobrenoToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.propusnicaTableAdapter.Odobreno(this.projektDataSet.Propusnica);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void neobrađeneToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.propusnicaTableAdapter1.Neobrađene(this.projektDataSet1.Propusnica);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void odobreneToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.propusnicaTableAdapter1.Odobrene(this.projektDataSet1.Propusnica);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void odbijenoToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.propusnicaTableAdapter1.Odbijeno(this.projektDataSet1.Propusnica);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
