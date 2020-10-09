namespace Cookbook.WinUI.MjernaKolicina
{
    partial class frmMjernaKolicina
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
            this.dgvMjernaKolicina = new System.Windows.Forms.DataGridView();
            this.MjernaKolicinaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMjernaKolicina)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMjernaKolicina
            // 
            this.dgvMjernaKolicina.AllowUserToAddRows = false;
            this.dgvMjernaKolicina.AllowUserToDeleteRows = false;
            this.dgvMjernaKolicina.BackgroundColor = System.Drawing.Color.Ivory;
            this.dgvMjernaKolicina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMjernaKolicina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MjernaKolicinaId,
            this.Kolicina});
            this.dgvMjernaKolicina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMjernaKolicina.Location = new System.Drawing.Point(4, 19);
            this.dgvMjernaKolicina.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMjernaKolicina.Name = "dgvMjernaKolicina";
            this.dgvMjernaKolicina.ReadOnly = true;
            this.dgvMjernaKolicina.RowHeadersWidth = 40;
            this.dgvMjernaKolicina.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvMjernaKolicina.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMjernaKolicina.Size = new System.Drawing.Size(270, 262);
            this.dgvMjernaKolicina.TabIndex = 0;
            this.dgvMjernaKolicina.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvMjernaKolicina_MouseDoubleClick);
            // 
            // MjernaKolicinaId
            // 
            this.MjernaKolicinaId.DataPropertyName = "MjernaKolicinaId";
            this.MjernaKolicinaId.HeaderText = "MjernaKolicinaId";
            this.MjernaKolicinaId.MinimumWidth = 6;
            this.MjernaKolicinaId.Name = "MjernaKolicinaId";
            this.MjernaKolicinaId.ReadOnly = true;
            this.MjernaKolicinaId.Visible = false;
            this.MjernaKolicinaId.Width = 125;
            // 
            // Kolicina
            // 
            this.Kolicina.DataPropertyName = "Kolicina";
            this.Kolicina.HeaderText = "Kolicina";
            this.Kolicina.MinimumWidth = 6;
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.ReadOnly = true;
            this.Kolicina.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvMjernaKolicina);
            this.groupBox1.Location = new System.Drawing.Point(98, 90);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(278, 285);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(343, 36);
            this.btnPrikazi.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(100, 28);
            this.btnPrikazi.TabIndex = 19;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Mjerna količina";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(178, 36);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(4);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(133, 22);
            this.txtNaziv.TabIndex = 21;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(343, 403);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(100, 28);
            this.btnDodaj.TabIndex = 23;
            this.btnDodaj.Text = "Dodaj novu";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // frmMjernaKolicina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 455);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.btnDodaj);
            this.Name = "frmMjernaKolicina";
            this.Text = "frmMjernaKolicina";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMjernaKolicina)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMjernaKolicina;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn MjernaKolicinaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
    }
}