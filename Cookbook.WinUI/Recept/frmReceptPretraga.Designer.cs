namespace Cookbook.WinUI.Recept
{
    partial class frmReceptPretraga
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
            this.cmbGrupaJela = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbKategorija = new System.Windows.Forms.ComboBox();
            this.cmbSlozenost = new System.Windows.Forms.ComboBox();
            this.Recepti = new System.Windows.Forms.GroupBox();
            this.dgvRecept = new System.Windows.Forms.DataGridView();
            this.ReceptId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tekst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumObjave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrijemePripreme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrijemeKuhanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojLjudi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KategorijaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SlozenostId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrupaJelaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slika = new System.Windows.Forms.DataGridViewImageColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Recepti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbGrupaJela
            // 
            this.cmbGrupaJela.FormattingEnabled = true;
            this.cmbGrupaJela.Location = new System.Drawing.Point(180, 160);
            this.cmbGrupaJela.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGrupaJela.Name = "cmbGrupaJela";
            this.cmbGrupaJela.Size = new System.Drawing.Size(265, 24);
            this.cmbGrupaJela.TabIndex = 62;
            this.cmbGrupaJela.Validating += new System.ComponentModel.CancelEventHandler(this.cmbGrupaJela_Validating);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(72, 160);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 17);
            this.label13.TabIndex = 61;
            this.label13.Text = "Grupa jela";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(72, 101);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 17);
            this.label12.TabIndex = 60;
            this.label12.Text = "Složenost";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(72, 38);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 17);
            this.label11.TabIndex = 58;
            this.label11.Text = "Kategorija";
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.Location = new System.Drawing.Point(180, 38);
            this.cmbKategorija.Margin = new System.Windows.Forms.Padding(4);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(265, 24);
            this.cmbKategorija.TabIndex = 64;
            this.cmbKategorija.Validating += new System.ComponentModel.CancelEventHandler(this.cmbKategorija_Validating);
            // 
            // cmbSlozenost
            // 
            this.cmbSlozenost.FormattingEnabled = true;
            this.cmbSlozenost.Location = new System.Drawing.Point(180, 101);
            this.cmbSlozenost.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSlozenost.Name = "cmbSlozenost";
            this.cmbSlozenost.Size = new System.Drawing.Size(265, 24);
            this.cmbSlozenost.TabIndex = 65;
            this.cmbSlozenost.Validating += new System.ComponentModel.CancelEventHandler(this.cmbSlozenost_Validating);
            // 
            // Recepti
            // 
            this.Recepti.Controls.Add(this.dgvRecept);
            this.Recepti.Location = new System.Drawing.Point(32, 227);
            this.Recepti.Margin = new System.Windows.Forms.Padding(4);
            this.Recepti.Name = "Recepti";
            this.Recepti.Padding = new System.Windows.Forms.Padding(4);
            this.Recepti.Size = new System.Drawing.Size(912, 345);
            this.Recepti.TabIndex = 66;
            this.Recepti.TabStop = false;
            this.Recepti.Text = "Recepti";
            // 
            // dgvRecept
            // 
            this.dgvRecept.AllowUserToAddRows = false;
            this.dgvRecept.AllowUserToDeleteRows = false;
            this.dgvRecept.BackgroundColor = System.Drawing.Color.Ivory;
            this.dgvRecept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecept.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReceptId,
            this.Naziv,
            this.Tekst,
            this.DatumObjave,
            this.VrijemePripreme,
            this.VrijemeKuhanja,
            this.BrojLjudi,
            this.KategorijaId,
            this.SlozenostId,
            this.GrupaJelaId,
            this.Slika,
            this.Ocjena});
            this.dgvRecept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecept.Location = new System.Drawing.Point(4, 19);
            this.dgvRecept.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRecept.Name = "dgvRecept";
            this.dgvRecept.ReadOnly = true;
            this.dgvRecept.RowHeadersWidth = 51;
            this.dgvRecept.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecept.Size = new System.Drawing.Size(904, 322);
            this.dgvRecept.TabIndex = 0;
            this.dgvRecept.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRecept_CellMouseDoubleClick);
            // 
            // ReceptId
            // 
            this.ReceptId.DataPropertyName = "ReceptId";
            this.ReceptId.HeaderText = "ReceptId";
            this.ReceptId.MinimumWidth = 6;
            this.ReceptId.Name = "ReceptId";
            this.ReceptId.ReadOnly = true;
            this.ReceptId.Visible = false;
            this.ReceptId.Width = 125;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.MinimumWidth = 6;
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            this.Naziv.Width = 125;
            // 
            // Tekst
            // 
            this.Tekst.DataPropertyName = "Tekst";
            this.Tekst.HeaderText = "Tekst";
            this.Tekst.MinimumWidth = 6;
            this.Tekst.Name = "Tekst";
            this.Tekst.ReadOnly = true;
            this.Tekst.Width = 125;
            // 
            // DatumObjave
            // 
            this.DatumObjave.DataPropertyName = "DatumObjave";
            this.DatumObjave.HeaderText = "Datum objave";
            this.DatumObjave.MinimumWidth = 6;
            this.DatumObjave.Name = "DatumObjave";
            this.DatumObjave.ReadOnly = true;
            this.DatumObjave.Width = 125;
            // 
            // VrijemePripreme
            // 
            this.VrijemePripreme.DataPropertyName = "VrijemePripreme";
            this.VrijemePripreme.HeaderText = "Vrijeme pripreme";
            this.VrijemePripreme.MinimumWidth = 6;
            this.VrijemePripreme.Name = "VrijemePripreme";
            this.VrijemePripreme.ReadOnly = true;
            this.VrijemePripreme.Width = 125;
            // 
            // VrijemeKuhanja
            // 
            this.VrijemeKuhanja.DataPropertyName = "VrijemeKuhanja";
            this.VrijemeKuhanja.HeaderText = "Vrijeme kuhanja";
            this.VrijemeKuhanja.MinimumWidth = 6;
            this.VrijemeKuhanja.Name = "VrijemeKuhanja";
            this.VrijemeKuhanja.ReadOnly = true;
            this.VrijemeKuhanja.Width = 125;
            // 
            // BrojLjudi
            // 
            this.BrojLjudi.DataPropertyName = "BrojLjudi";
            this.BrojLjudi.HeaderText = "Broj ljudi";
            this.BrojLjudi.MinimumWidth = 6;
            this.BrojLjudi.Name = "BrojLjudi";
            this.BrojLjudi.ReadOnly = true;
            this.BrojLjudi.Width = 125;
            // 
            // KategorijaId
            // 
            this.KategorijaId.DataPropertyName = "KategorijaId";
            this.KategorijaId.HeaderText = "KategorijaId";
            this.KategorijaId.MinimumWidth = 6;
            this.KategorijaId.Name = "KategorijaId";
            this.KategorijaId.ReadOnly = true;
            this.KategorijaId.Visible = false;
            this.KategorijaId.Width = 125;
            // 
            // SlozenostId
            // 
            this.SlozenostId.DataPropertyName = "SlozenostId";
            this.SlozenostId.HeaderText = "SlozenostId";
            this.SlozenostId.MinimumWidth = 6;
            this.SlozenostId.Name = "SlozenostId";
            this.SlozenostId.ReadOnly = true;
            this.SlozenostId.Visible = false;
            this.SlozenostId.Width = 125;
            // 
            // GrupaJelaId
            // 
            this.GrupaJelaId.DataPropertyName = "GrupaJelaId";
            this.GrupaJelaId.HeaderText = "GrupaJelaId";
            this.GrupaJelaId.MinimumWidth = 6;
            this.GrupaJelaId.Name = "GrupaJelaId";
            this.GrupaJelaId.ReadOnly = true;
            this.GrupaJelaId.Visible = false;
            this.GrupaJelaId.Width = 125;
            // 
            // Slika
            // 
            this.Slika.DataPropertyName = "Slika";
            this.Slika.FillWeight = 500F;
            this.Slika.HeaderText = "Slika";
            this.Slika.MinimumWidth = 100;
            this.Slika.Name = "Slika";
            this.Slika.ReadOnly = true;
            this.Slika.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Slika.Width = 150;
            // 
            // Ocjena
            // 
            this.Ocjena.DataPropertyName = "Ocjena";
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.MinimumWidth = 6;
            this.Ocjena.Name = "Ocjena";
            this.Ocjena.ReadOnly = true;
            this.Ocjena.Width = 125;
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(739, 170);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(75, 27);
            this.btnPretraga.TabIndex = 67;
            this.btnPretraga.Text = "Pretraži";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmReceptPretraga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 656);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.Recepti);
            this.Controls.Add(this.cmbSlozenost);
            this.Controls.Add(this.cmbKategorija);
            this.Controls.Add(this.cmbGrupaJela);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Name = "frmReceptPretraga";
            this.Text = "frmPretraga";
            this.Load += new System.EventHandler(this.frmReceptPretraga_Load);
            this.Recepti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbGrupaJela;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
     
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbKategorija;
        private System.Windows.Forms.ComboBox cmbSlozenost;
        private System.Windows.Forms.GroupBox Recepti;
        private System.Windows.Forms.DataGridView dgvRecept;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceptId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tekst;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumObjave;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrijemePripreme;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrijemeKuhanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojLjudi;
        private System.Windows.Forms.DataGridViewTextBoxColumn KategorijaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlozenostId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrupaJelaId;
        private System.Windows.Forms.DataGridViewImageColumn Slika;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
    }
}