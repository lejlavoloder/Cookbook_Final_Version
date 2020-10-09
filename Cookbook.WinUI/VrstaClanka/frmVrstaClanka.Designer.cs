namespace Cookbook.WinUI.VrstaClanka
{
    partial class frmVrstaClanka
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
            this.VrstaClanka = new System.Windows.Forms.GroupBox();
            this.dgvVrstaClanka = new System.Windows.Forms.DataGridView();
            this.VrstaClankaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKategorija = new System.Windows.Forms.TextBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.VrstaClanka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVrstaClanka)).BeginInit();
            this.SuspendLayout();
            // 
            // VrstaClanka
            // 
            this.VrstaClanka.Controls.Add(this.dgvVrstaClanka);
            this.VrstaClanka.Location = new System.Drawing.Point(85, 97);
            this.VrstaClanka.Name = "VrstaClanka";
            this.VrstaClanka.Size = new System.Drawing.Size(247, 308);
            this.VrstaClanka.TabIndex = 10;
            this.VrstaClanka.TabStop = false;
            this.VrstaClanka.Text = "Vrsta članka";
            // 
            // dgvVrstaClanka
            // 
            this.dgvVrstaClanka.AllowUserToAddRows = false;
            this.dgvVrstaClanka.AllowUserToDeleteRows = false;
            this.dgvVrstaClanka.BackgroundColor = System.Drawing.Color.Ivory;
            this.dgvVrstaClanka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVrstaClanka.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VrstaClankaId,
            this.Naziv});
            this.dgvVrstaClanka.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVrstaClanka.Location = new System.Drawing.Point(3, 18);
            this.dgvVrstaClanka.Name = "dgvVrstaClanka";
            this.dgvVrstaClanka.ReadOnly = true;
            this.dgvVrstaClanka.RowHeadersWidth = 51;
            this.dgvVrstaClanka.RowTemplate.Height = 24;
            this.dgvVrstaClanka.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVrstaClanka.Size = new System.Drawing.Size(241, 287);
            this.dgvVrstaClanka.TabIndex = 0;
            this.dgvVrstaClanka.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvVrstaClanka_MouseDoubleClick);
            // 
            // VrstaClankaId
            // 
            this.VrstaClankaId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.VrstaClankaId.DataPropertyName = "VrstaClankaId";
            this.VrstaClankaId.HeaderText = "VrstaClankaId";
            this.VrstaClankaId.MinimumWidth = 6;
            this.VrstaClankaId.Name = "VrstaClankaId";
            this.VrstaClankaId.ReadOnly = true;
            this.VrstaClankaId.Visible = false;
            this.VrstaClankaId.Width = 125;
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
            this.label1.Location = new System.Drawing.Point(15, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Naziv";
            // 
            // txtKategorija
            // 
            this.txtKategorija.Location = new System.Drawing.Point(94, 45);
            this.txtKategorija.Name = "txtKategorija";
            this.txtKategorija.Size = new System.Drawing.Size(208, 22);
            this.txtKategorija.TabIndex = 12;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(334, 45);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(87, 23);
            this.btnPrikazi.TabIndex = 11;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(338, 415);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(96, 33);
            this.btnDodaj.TabIndex = 12;
            this.btnDodaj.Text = "Dodaj novu";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // frmVrstaClanka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 460);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.VrstaClanka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKategorija);
            this.Controls.Add(this.btnPrikazi);
            this.Name = "frmVrstaClanka";
            this.Text = "frmVrstaClanka";
            this.VrstaClanka.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVrstaClanka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox VrstaClanka;
        private System.Windows.Forms.DataGridView dgvVrstaClanka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKategorija;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrstaClankaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.Button btnDodaj;
    }
}