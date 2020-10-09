namespace Cookbook.WinUI.Recept
{
    partial class frmDodajSastojak
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
            this.cmbMjernaJedinica = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbSastojak = new System.Windows.Forms.ComboBox();
            this.cmbMjernaKoličina = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRecept = new System.Windows.Forms.ComboBox();
            this.Recept = new System.Windows.Forms.GroupBox();
            this.dgvReceptSastojak = new System.Windows.Forms.DataGridView();
            this.ReceptSastojakId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sastojak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MjernaKolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MjernaJedinica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Recept.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceptSastojak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMjernaJedinica
            // 
            this.cmbMjernaJedinica.FormattingEnabled = true;
            this.cmbMjernaJedinica.Location = new System.Drawing.Point(220, 135);
            this.cmbMjernaJedinica.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMjernaJedinica.Name = "cmbMjernaJedinica";
            this.cmbMjernaJedinica.Size = new System.Drawing.Size(265, 24);
            this.cmbMjernaJedinica.TabIndex = 60;
            this.cmbMjernaJedinica.Validating += new System.ComponentModel.CancelEventHandler(this.cmbMjernaJedinica_Validating);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(109, 135);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 17);
            this.label13.TabIndex = 59;
            this.label13.Text = "Mjerna jedinica";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(114, 83);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 17);
            this.label12.TabIndex = 58;
            this.label12.Text = "Sastojak";
            // 
            // cmbSastojak
            // 
            this.cmbSastojak.FormattingEnabled = true;
            this.cmbSastojak.Location = new System.Drawing.Point(222, 80);
            this.cmbSastojak.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSastojak.Name = "cmbSastojak";
            this.cmbSastojak.Size = new System.Drawing.Size(265, 24);
            this.cmbSastojak.TabIndex = 57;
            this.cmbSastojak.Validating += new System.ComponentModel.CancelEventHandler(this.cmbSastojak_Validating);
            // 
            // cmbMjernaKoličina
            // 
            this.cmbMjernaKoličina.FormattingEnabled = true;
            this.cmbMjernaKoličina.Location = new System.Drawing.Point(222, 201);
            this.cmbMjernaKoličina.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMjernaKoličina.Name = "cmbMjernaKoličina";
            this.cmbMjernaKoličina.Size = new System.Drawing.Size(265, 24);
            this.cmbMjernaKoličina.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 201);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 61;
            this.label1.Text = "Mjerna količina";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(571, 201);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(81, 30);
            this.btnSacuvaj.TabIndex = 63;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 65;
            this.label2.Text = "Recept";
            // 
            // cmbRecept
            // 
            this.cmbRecept.FormattingEnabled = true;
            this.cmbRecept.Location = new System.Drawing.Point(220, 33);
            this.cmbRecept.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRecept.Name = "cmbRecept";
            this.cmbRecept.Size = new System.Drawing.Size(265, 24);
            this.cmbRecept.TabIndex = 64;
            this.cmbRecept.SelectedIndexChanged += new System.EventHandler(this.cmbRecept_SelectedIndexChanged);
            this.cmbRecept.Validating += new System.ComponentModel.CancelEventHandler(this.cmbRecept_Validating);
            // 
            // Recept
            // 
            this.Recept.Controls.Add(this.dgvReceptSastojak);
            this.Recept.Location = new System.Drawing.Point(76, 251);
            this.Recept.Margin = new System.Windows.Forms.Padding(4);
            this.Recept.Name = "Recept";
            this.Recept.Padding = new System.Windows.Forms.Padding(4);
            this.Recept.Size = new System.Drawing.Size(823, 306);
            this.Recept.TabIndex = 66;
            this.Recept.TabStop = false;
            this.Recept.Text = "Recept";
            // 
            // dgvReceptSastojak
            // 
            this.dgvReceptSastojak.AllowUserToAddRows = false;
            this.dgvReceptSastojak.AllowUserToDeleteRows = false;
            this.dgvReceptSastojak.BackgroundColor = System.Drawing.Color.Ivory;
            this.dgvReceptSastojak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceptSastojak.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReceptSastojakId,
            this.Sastojak,
            this.MjernaKolicina,
            this.MjernaJedinica});
            this.dgvReceptSastojak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReceptSastojak.Location = new System.Drawing.Point(4, 19);
            this.dgvReceptSastojak.Margin = new System.Windows.Forms.Padding(4);
            this.dgvReceptSastojak.Name = "dgvReceptSastojak";
            this.dgvReceptSastojak.ReadOnly = true;
            this.dgvReceptSastojak.RowHeadersWidth = 51;
            this.dgvReceptSastojak.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceptSastojak.Size = new System.Drawing.Size(815, 283);
            this.dgvReceptSastojak.TabIndex = 0;
            this.dgvReceptSastojak.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvReceptSastojak_MouseDoubleClick);
            // 
            // ReceptSastojakId
            // 
            this.ReceptSastojakId.DataPropertyName = "ReceptSastojakId";
            this.ReceptSastojakId.HeaderText = "ReceptSastojakId";
            this.ReceptSastojakId.MinimumWidth = 6;
            this.ReceptSastojakId.Name = "ReceptSastojakId";
            this.ReceptSastojakId.ReadOnly = true;
            this.ReceptSastojakId.Visible = false;
            this.ReceptSastojakId.Width = 125;
            // 
            // Sastojak
            // 
            this.Sastojak.DataPropertyName = "Sastojak";
            this.Sastojak.HeaderText = "Naziv sastojka";
            this.Sastojak.MinimumWidth = 6;
            this.Sastojak.Name = "Sastojak";
            this.Sastojak.ReadOnly = true;
            this.Sastojak.Width = 125;
            // 
            // MjernaKolicina
            // 
            this.MjernaKolicina.DataPropertyName = "MjernaKolicina";
            this.MjernaKolicina.HeaderText = "Mjerna količina";
            this.MjernaKolicina.MinimumWidth = 6;
            this.MjernaKolicina.Name = "MjernaKolicina";
            this.MjernaKolicina.ReadOnly = true;
            this.MjernaKolicina.Width = 125;
            // 
            // MjernaJedinica
            // 
            this.MjernaJedinica.DataPropertyName = "MjernaJedinica";
            this.MjernaJedinica.HeaderText = "Mjerna jedinica";
            this.MjernaJedinica.MinimumWidth = 6;
            this.MjernaJedinica.Name = "MjernaJedinica";
            this.MjernaJedinica.ReadOnly = true;
            this.MjernaJedinica.Width = 125;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmDodajSastojak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 597);
            this.Controls.Add(this.Recept);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbRecept);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.cmbMjernaKoličina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMjernaJedinica);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbSastojak);
            this.Name = "frmDodajSastojak";
            this.Text = "DodajSastojak";
            this.Load += new System.EventHandler(this.frmDodajSastojak_Load);
            this.Recept.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceptSastojak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMjernaJedinica;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbSastojak;
        private System.Windows.Forms.ComboBox cmbMjernaKoličina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRecept;
        private System.Windows.Forms.GroupBox Recept;
        private System.Windows.Forms.DataGridView dgvReceptSastojak;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceptSastojakId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sastojak;
        private System.Windows.Forms.DataGridViewTextBoxColumn MjernaKolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn MjernaJedinica;
    }
}