namespace Projekt2020
{
    partial class Obradi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.propusnicaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projektDataSet = new Projekt2020.ProjektDataSet();
            this.propusnicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.propusnicaTableAdapter = new Projekt2020.ProjektDataSetTableAdapters.PropusnicaTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.neobrađeneToolStrip = new System.Windows.Forms.ToolStrip();
            this.neobrađeneToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.odobreneToolStrip = new System.Windows.Forms.ToolStrip();
            this.odobreneToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.broj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mjestoodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mjestodoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razlogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odobreno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumdoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.napravioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propusnicaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.projektDataSet1 = new Projekt2020.ProjektDataSet1();
            this.propusnicaTableAdapter1 = new Projekt2020.ProjektDataSet1TableAdapters.PropusnicaTableAdapter();
            this.odbijenoToolStrip = new System.Windows.Forms.ToolStrip();
            this.odbijenoToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propusnicaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propusnicaBindingSource)).BeginInit();
            this.neobrađeneToolStrip.SuspendLayout();
            this.odobreneToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propusnicaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektDataSet1)).BeginInit();
            this.odbijenoToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.broj,
            this.oIBDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.mjestoodDataGridViewTextBoxColumn,
            this.mjestodoDataGridViewTextBoxColumn,
            this.razlogDataGridViewTextBoxColumn,
            this.odobreno,
            this.datumodDataGridViewTextBoxColumn,
            this.datumdoDataGridViewTextBoxColumn,
            this.napravioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.propusnicaBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(38, 84);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 171);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // propusnicaBindingSource1
            // 
            this.propusnicaBindingSource1.DataMember = "Propusnica";
            this.propusnicaBindingSource1.DataSource = this.projektDataSet;
            // 
            // projektDataSet
            // 
            this.projektDataSet.DataSetName = "ProjektDataSet";
            this.projektDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // propusnicaBindingSource
            // 
            this.propusnicaBindingSource.DataMember = "Propusnica";
            this.propusnicaBindingSource.DataSource = this.projektDataSet;
            // 
            // propusnicaTableAdapter
            // 
            this.propusnicaTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 271);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 71);
            this.button1.TabIndex = 2;
            this.button1.Text = "ODOBRI";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(479, 271);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 71);
            this.button2.TabIndex = 3;
            this.button2.Text = "PONIŠTI";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 402);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 42);
            this.button3.TabIndex = 4;
            this.button3.Text = "IZLAZ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // neobrađeneToolStrip
            // 
            this.neobrađeneToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neobrađeneToolStripButton});
            this.neobrađeneToolStrip.Location = new System.Drawing.Point(0, 0);
            this.neobrađeneToolStrip.Name = "neobrađeneToolStrip";
            this.neobrađeneToolStrip.Size = new System.Drawing.Size(863, 25);
            this.neobrađeneToolStrip.TabIndex = 8;
            this.neobrađeneToolStrip.Text = "neobrađeneToolStrip";
            // 
            // neobrađeneToolStripButton
            // 
            this.neobrađeneToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.neobrađeneToolStripButton.Name = "neobrađeneToolStripButton";
            this.neobrađeneToolStripButton.Size = new System.Drawing.Size(76, 22);
            this.neobrađeneToolStripButton.Text = "Neobrađene";
            this.neobrađeneToolStripButton.Click += new System.EventHandler(this.neobrađeneToolStripButton_Click);
            // 
            // odobreneToolStrip
            // 
            this.odobreneToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odobreneToolStripButton});
            this.odobreneToolStrip.Location = new System.Drawing.Point(0, 25);
            this.odobreneToolStrip.Name = "odobreneToolStrip";
            this.odobreneToolStrip.Size = new System.Drawing.Size(863, 25);
            this.odobreneToolStrip.TabIndex = 9;
            this.odobreneToolStrip.Text = "odobreneToolStrip";
            // 
            // odobreneToolStripButton
            // 
            this.odobreneToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.odobreneToolStripButton.Name = "odobreneToolStripButton";
            this.odobreneToolStripButton.Size = new System.Drawing.Size(64, 22);
            this.odobreneToolStripButton.Text = "Odobrene";
            this.odobreneToolStripButton.Click += new System.EventHandler(this.odobreneToolStripButton_Click);
            // 
            // broj
            // 
            this.broj.DataPropertyName = "broj";
            this.broj.HeaderText = "broj";
            this.broj.MinimumWidth = 6;
            this.broj.Name = "broj";
            this.broj.ReadOnly = true;
            this.broj.Width = 125;
            // 
            // oIBDataGridViewTextBoxColumn
            // 
            this.oIBDataGridViewTextBoxColumn.DataPropertyName = "OIB";
            this.oIBDataGridViewTextBoxColumn.HeaderText = "OIB";
            this.oIBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oIBDataGridViewTextBoxColumn.Name = "oIBDataGridViewTextBoxColumn";
            this.oIBDataGridViewTextBoxColumn.Width = 125;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.Width = 125;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // mjestoodDataGridViewTextBoxColumn
            // 
            this.mjestoodDataGridViewTextBoxColumn.DataPropertyName = "Mjesto_od";
            this.mjestoodDataGridViewTextBoxColumn.HeaderText = "Mjesto_od";
            this.mjestoodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mjestoodDataGridViewTextBoxColumn.Name = "mjestoodDataGridViewTextBoxColumn";
            this.mjestoodDataGridViewTextBoxColumn.Width = 125;
            // 
            // mjestodoDataGridViewTextBoxColumn
            // 
            this.mjestodoDataGridViewTextBoxColumn.DataPropertyName = "Mjesto_do";
            this.mjestodoDataGridViewTextBoxColumn.HeaderText = "Mjesto_do";
            this.mjestodoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mjestodoDataGridViewTextBoxColumn.Name = "mjestodoDataGridViewTextBoxColumn";
            this.mjestodoDataGridViewTextBoxColumn.Width = 125;
            // 
            // razlogDataGridViewTextBoxColumn
            // 
            this.razlogDataGridViewTextBoxColumn.DataPropertyName = "razlog";
            this.razlogDataGridViewTextBoxColumn.HeaderText = "razlog";
            this.razlogDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.razlogDataGridViewTextBoxColumn.Name = "razlogDataGridViewTextBoxColumn";
            this.razlogDataGridViewTextBoxColumn.Width = 125;
            // 
            // odobreno
            // 
            this.odobreno.DataPropertyName = "odobreno";
            this.odobreno.HeaderText = "odobreno";
            this.odobreno.MinimumWidth = 6;
            this.odobreno.Name = "odobreno";
            this.odobreno.Width = 125;
            // 
            // datumodDataGridViewTextBoxColumn
            // 
            this.datumodDataGridViewTextBoxColumn.DataPropertyName = "datumod";
            this.datumodDataGridViewTextBoxColumn.HeaderText = "datumod";
            this.datumodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datumodDataGridViewTextBoxColumn.Name = "datumodDataGridViewTextBoxColumn";
            this.datumodDataGridViewTextBoxColumn.Width = 125;
            // 
            // datumdoDataGridViewTextBoxColumn
            // 
            this.datumdoDataGridViewTextBoxColumn.DataPropertyName = "datumdo";
            this.datumdoDataGridViewTextBoxColumn.HeaderText = "datumdo";
            this.datumdoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datumdoDataGridViewTextBoxColumn.Name = "datumdoDataGridViewTextBoxColumn";
            this.datumdoDataGridViewTextBoxColumn.Width = 125;
            // 
            // napravioDataGridViewTextBoxColumn
            // 
            this.napravioDataGridViewTextBoxColumn.DataPropertyName = "napravio";
            this.napravioDataGridViewTextBoxColumn.HeaderText = "napravio";
            this.napravioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.napravioDataGridViewTextBoxColumn.Name = "napravioDataGridViewTextBoxColumn";
            this.napravioDataGridViewTextBoxColumn.Width = 125;
            // 
            // propusnicaBindingSource2
            // 
            this.propusnicaBindingSource2.DataMember = "Propusnica";
            this.propusnicaBindingSource2.DataSource = this.projektDataSet1;
            // 
            // projektDataSet1
            // 
            this.projektDataSet1.DataSetName = "ProjektDataSet1";
            this.projektDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // propusnicaTableAdapter1
            // 
            this.propusnicaTableAdapter1.ClearBeforeFill = true;
            // 
            // odbijenoToolStrip
            // 
            this.odbijenoToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odbijenoToolStripButton});
            this.odbijenoToolStrip.Location = new System.Drawing.Point(0, 0);
            this.odbijenoToolStrip.Name = "odbijenoToolStrip";
            this.odbijenoToolStrip.Size = new System.Drawing.Size(111, 25);
            this.odbijenoToolStrip.TabIndex = 10;
            this.odbijenoToolStrip.Text = "odbijenoToolStrip";
            // 
            // odbijenoToolStripButton
            // 
            this.odbijenoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.odbijenoToolStripButton.Name = "odbijenoToolStripButton";
            this.odbijenoToolStripButton.Size = new System.Drawing.Size(60, 22);
            this.odbijenoToolStripButton.Text = "Odbijeno";
            this.odbijenoToolStripButton.Click += new System.EventHandler(this.odbijenoToolStripButton_Click);
            // 
            // Obradi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 477);
            this.Controls.Add(this.odbijenoToolStrip);
            this.Controls.Add(this.odobreneToolStrip);
            this.Controls.Add(this.neobrađeneToolStrip);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Obradi";
            this.Text = "Obradi";
            this.Load += new System.EventHandler(this.Obradi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propusnicaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propusnicaBindingSource)).EndInit();
            this.neobrađeneToolStrip.ResumeLayout(false);
            this.neobrađeneToolStrip.PerformLayout();
            this.odobreneToolStrip.ResumeLayout(false);
            this.odobreneToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propusnicaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektDataSet1)).EndInit();
            this.odbijenoToolStrip.ResumeLayout(false);
            this.odbijenoToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ProjektDataSet projektDataSet;
        private System.Windows.Forms.BindingSource propusnicaBindingSource;
        private ProjektDataSetTableAdapters.PropusnicaTableAdapter propusnicaTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn broj;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mjestoodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mjestodoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razlogDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odobreno;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumdoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn napravioDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource propusnicaBindingSource1;
        private ProjektDataSet1 projektDataSet1;
        private System.Windows.Forms.BindingSource propusnicaBindingSource2;
        private ProjektDataSet1TableAdapters.PropusnicaTableAdapter propusnicaTableAdapter1;
        private System.Windows.Forms.ToolStrip neobrađeneToolStrip;
        private System.Windows.Forms.ToolStripButton neobrađeneToolStripButton;
        private System.Windows.Forms.ToolStrip odobreneToolStrip;
        private System.Windows.Forms.ToolStripButton odobreneToolStripButton;
        private System.Windows.Forms.ToolStrip odbijenoToolStrip;
        private System.Windows.Forms.ToolStripButton odbijenoToolStripButton;
    }
}