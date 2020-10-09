namespace Cookbook.WinUI.MjernaJedinica
{
    partial class frmMjernaJedinica
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMjernaJedinica = new System.Windows.Forms.TextBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.MjernaJedinica = new System.Windows.Forms.GroupBox();
            this.dgvMjernaJedinica = new System.Windows.Forms.DataGridView();
            this.MjernaJedinicaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MjernaJedinica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMjernaJedinica)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Naziv";
            // 
            // txtMjernaJedinica
            // 
            this.txtMjernaJedinica.Location = new System.Drawing.Point(113, 30);
            this.txtMjernaJedinica.Name = "txtMjernaJedinica";
            this.txtMjernaJedinica.Size = new System.Drawing.Size(208, 22);
            this.txtMjernaJedinica.TabIndex = 12;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(353, 30);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(87, 23);
            this.btnPrikazi.TabIndex = 11;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // MjernaJedinica
            // 
            this.MjernaJedinica.Controls.Add(this.dgvMjernaJedinica);
            this.MjernaJedinica.Location = new System.Drawing.Point(98, 69);
            this.MjernaJedinica.Name = "MjernaJedinica";
            this.MjernaJedinica.Size = new System.Drawing.Size(247, 308);
            this.MjernaJedinica.TabIndex = 14;
            this.MjernaJedinica.TabStop = false;
            this.MjernaJedinica.Text = "Mjerne jedinice";
            // 
            // dgvMjernaJedinica
            // 
            this.dgvMjernaJedinica.AllowUserToAddRows = false;
            this.dgvMjernaJedinica.AllowUserToDeleteRows = false;
            this.dgvMjernaJedinica.BackgroundColor = System.Drawing.Color.Ivory;
            this.dgvMjernaJedinica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMjernaJedinica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MjernaJedinicaId,
            this.Naziv});
            this.dgvMjernaJedinica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMjernaJedinica.Location = new System.Drawing.Point(3, 18);
            this.dgvMjernaJedinica.Name = "dgvMjernaJedinica";
            this.dgvMjernaJedinica.ReadOnly = true;
            this.dgvMjernaJedinica.RowHeadersWidth = 51;
            this.dgvMjernaJedinica.RowTemplate.Height = 24;
            this.dgvMjernaJedinica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMjernaJedinica.Size = new System.Drawing.Size(241, 287);
            this.dgvMjernaJedinica.TabIndex = 0;
            this.dgvMjernaJedinica.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvMjernaJedinica_MouseDoubleClick);
            // 
            // MjernaJedinicaId
            // 
            this.MjernaJedinicaId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MjernaJedinicaId.DataPropertyName = "MjernaJedinicaId";
            this.MjernaJedinicaId.HeaderText = "MjernaJedinicaId";
            this.MjernaJedinicaId.MinimumWidth = 6;
            this.MjernaJedinicaId.Name = "MjernaJedinicaId";
            this.MjernaJedinicaId.ReadOnly = true;
            this.MjernaJedinicaId.Visible = false;
            this.MjernaJedinicaId.Width = 125;
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
            // frmMjernaJedinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 412);
            this.Controls.Add(this.MjernaJedinica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMjernaJedinica);
            this.Controls.Add(this.btnPrikazi);
            this.Name = "frmMjernaJedinica";
            this.Text = "frmMjernaJedinica";
            this.MjernaJedinica.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMjernaJedinica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMjernaJedinica;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.GroupBox MjernaJedinica;
        private System.Windows.Forms.DataGridView dgvMjernaJedinica;
        private System.Windows.Forms.DataGridViewTextBoxColumn MjernaJedinicaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
    }
}