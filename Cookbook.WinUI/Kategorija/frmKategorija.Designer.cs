namespace Cookbook.WinUI.Kategorija
{
    partial class frmKategorija
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
            this.Kategorija = new System.Windows.Forms.GroupBox();
            this.dgvKategorija = new System.Windows.Forms.DataGridView();
            this.KategorijaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKategorija = new System.Windows.Forms.TextBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.Kategorija.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategorija)).BeginInit();
            this.SuspendLayout();
            // 
            // Kategorija
            // 
            this.Kategorija.Controls.Add(this.dgvKategorija);
            this.Kategorija.Location = new System.Drawing.Point(107, 77);
            this.Kategorija.Name = "Kategorija";
            this.Kategorija.Size = new System.Drawing.Size(247, 308);
            this.Kategorija.TabIndex = 5;
            this.Kategorija.TabStop = false;
            this.Kategorija.Text = "Kategorije";
            // 
            // dgvKategorija
            // 
            this.dgvKategorija.AllowUserToAddRows = false;
            this.dgvKategorija.AllowUserToDeleteRows = false;
            this.dgvKategorija.BackgroundColor = System.Drawing.Color.Ivory;
            this.dgvKategorija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKategorija.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KategorijaId,
            this.Naziv});
            this.dgvKategorija.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKategorija.Location = new System.Drawing.Point(3, 18);
            this.dgvKategorija.Name = "dgvKategorija";
            this.dgvKategorija.ReadOnly = true;
            this.dgvKategorija.RowHeadersWidth = 51;
            this.dgvKategorija.RowTemplate.Height = 24;
            this.dgvKategorija.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKategorija.Size = new System.Drawing.Size(241, 287);
            this.dgvKategorija.TabIndex = 0;
            this.dgvKategorija.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvKategorija_MouseDoubleClick);
            // 
            // KategorijaId
            // 
            this.KategorijaId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.KategorijaId.DataPropertyName = "KategorijaId";
            this.KategorijaId.HeaderText = "KategorijaId";
            this.KategorijaId.MinimumWidth = 6;
            this.KategorijaId.Name = "KategorijaId";
            this.KategorijaId.ReadOnly = true;
            this.KategorijaId.Visible = false;
            this.KategorijaId.Width = 125;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Naziv";
            // 
            // txtKategorija
            // 
            this.txtKategorija.Location = new System.Drawing.Point(116, 25);
            this.txtKategorija.Name = "txtKategorija";
            this.txtKategorija.Size = new System.Drawing.Size(208, 22);
            this.txtKategorija.TabIndex = 7;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(356, 25);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(87, 23);
            this.btnPrikazi.TabIndex = 6;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // frmKategorija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 402);
            this.Controls.Add(this.Kategorija);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKategorija);
            this.Controls.Add(this.btnPrikazi);
            this.Name = "frmKategorija";
            this.Text = "frmKategorija";
            this.Kategorija.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategorija)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Kategorija;
        private System.Windows.Forms.DataGridView dgvKategorija;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKategorija;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.DataGridViewTextBoxColumn KategorijaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
    }
}