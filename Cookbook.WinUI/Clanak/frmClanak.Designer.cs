namespace Cookbook.WinUI.Clanak
{
    partial class frmClanak
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
            this.Clanak = new System.Windows.Forms.GroupBox();
            this.dgvClanak = new System.Windows.Forms.DataGridView();
            this.ClanakId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tekst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumObjave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrstaClankaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.cmbVrstaClanka = new System.Windows.Forms.ComboBox();
            this.Clanak.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanak)).BeginInit();
            this.SuspendLayout();
            // 
            // Clanak
            // 
            this.Clanak.Controls.Add(this.dgvClanak);
            this.Clanak.Location = new System.Drawing.Point(70, 96);
            this.Clanak.Margin = new System.Windows.Forms.Padding(4);
            this.Clanak.Name = "Clanak";
            this.Clanak.Padding = new System.Windows.Forms.Padding(4);
            this.Clanak.Size = new System.Drawing.Size(641, 283);
            this.Clanak.TabIndex = 9;
            this.Clanak.TabStop = false;
            this.Clanak.Text = "Članci";
            // 
            // dgvClanak
            // 
            this.dgvClanak.AllowUserToAddRows = false;
            this.dgvClanak.AllowUserToDeleteRows = false;
            this.dgvClanak.BackgroundColor = System.Drawing.Color.Ivory;
            this.dgvClanak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClanak.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClanakId,
            this.Naziv,
            this.Tekst,
            this.DatumObjave,
            this.VrstaClankaId});
            this.dgvClanak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClanak.Location = new System.Drawing.Point(4, 19);
            this.dgvClanak.Margin = new System.Windows.Forms.Padding(4);
            this.dgvClanak.Name = "dgvClanak";
            this.dgvClanak.ReadOnly = true;
            this.dgvClanak.RowHeadersWidth = 51;
            this.dgvClanak.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClanak.Size = new System.Drawing.Size(633, 260);
            this.dgvClanak.TabIndex = 0;
            this.dgvClanak.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvClanak_MouseDoubleClick_1);
            // 
            // ClanakId
            // 
            this.ClanakId.DataPropertyName = "ClanakId";
            this.ClanakId.HeaderText = "ClanakId";
            this.ClanakId.MinimumWidth = 6;
            this.ClanakId.Name = "ClanakId";
            this.ClanakId.ReadOnly = true;
            this.ClanakId.Visible = false;
            this.ClanakId.Width = 125;
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
            // VrstaClankaId
            // 
            this.VrstaClankaId.DataPropertyName = "VrstaClankaId";
            this.VrstaClankaId.HeaderText = "VrstaClankaId";
            this.VrstaClankaId.MinimumWidth = 6;
            this.VrstaClankaId.Name = "VrstaClankaId";
            this.VrstaClankaId.ReadOnly = true;
            this.VrstaClankaId.Visible = false;
            this.VrstaClankaId.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Vrsta članka";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(643, 409);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(100, 28);
            this.btnDodaj.TabIndex = 11;
            this.btnDodaj.Text = "Dodaj novi";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // cmbVrstaClanka
            // 
            this.cmbVrstaClanka.FormattingEnabled = true;
            this.cmbVrstaClanka.Location = new System.Drawing.Point(190, 18);
            this.cmbVrstaClanka.Margin = new System.Windows.Forms.Padding(4);
            this.cmbVrstaClanka.Name = "cmbVrstaClanka";
            this.cmbVrstaClanka.Size = new System.Drawing.Size(281, 24);
            this.cmbVrstaClanka.TabIndex = 10;
            this.cmbVrstaClanka.SelectedIndexChanged += new System.EventHandler(this.cmbVrstaClanka_SelectedIndexChanged);
            // 
            // frmClanak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Clanak);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cmbVrstaClanka);
            this.Name = "frmClanak";
            this.Text = "frmClanak";
            this.Load += new System.EventHandler(this.frmClanak_Load);
            this.Clanak.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Clanak;
        private System.Windows.Forms.DataGridView dgvClanak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ComboBox cmbVrstaClanka;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClanakId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tekst;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumObjave;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrstaClankaId;
    }
}