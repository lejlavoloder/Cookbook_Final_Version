using System;

namespace Cookbook.WinUI.Sastojak
{
    partial class frmSastojak
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
            this.Sastojak = new System.Windows.Forms.GroupBox();
            this.dgvSastojak = new System.Windows.Forms.DataGridView();
            this.SastojakId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Sastojak.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSastojak)).BeginInit();
            this.SuspendLayout();
            // 
            // Sastojak
            // 
            this.Sastojak.Controls.Add(this.dgvSastojak);
            this.Sastojak.Location = new System.Drawing.Point(110, 75);
            this.Sastojak.Name = "Sastojak";
            this.Sastojak.Size = new System.Drawing.Size(247, 308);
            this.Sastojak.TabIndex = 0;
            this.Sastojak.TabStop = false;
            this.Sastojak.Text = "Sastojci";
            // 
            // dgvSastojak
            // 
            this.dgvSastojak.AllowUserToAddRows = false;
            this.dgvSastojak.AllowUserToDeleteRows = false;
            this.dgvSastojak.BackgroundColor = System.Drawing.Color.Ivory;
            this.dgvSastojak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSastojak.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SastojakId,
            this.Naziv});
            this.dgvSastojak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSastojak.Location = new System.Drawing.Point(3, 18);
            this.dgvSastojak.Name = "dgvSastojak";
            this.dgvSastojak.ReadOnly = true;
            this.dgvSastojak.RowHeadersWidth = 51;
            this.dgvSastojak.RowTemplate.Height = 24;
            this.dgvSastojak.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSastojak.Size = new System.Drawing.Size(241, 287);
            this.dgvSastojak.TabIndex = 0;
            this.dgvSastojak.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvSastojak_MouseDoubleClick);
            // 
            // SastojakId
            // 
            this.SastojakId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SastojakId.DataPropertyName = "SastojakId";
            this.SastojakId.HeaderText = "SastojakId";
            this.SastojakId.MinimumWidth = 6;
            this.SastojakId.Name = "SastojakId";
            this.SastojakId.ReadOnly = true;
            this.SastojakId.Visible = false;
            this.SastojakId.Width = 125;
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
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(359, 23);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(87, 23);
            this.btnPrikazi.TabIndex = 1;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(119, 23);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(208, 22);
            this.txtPretraga.TabIndex = 2;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(359, 403);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(93, 23);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Dodaj novi";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Naziv";
            // 
            // frmSastojak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.Sastojak);
            this.Name = "frmSastojak";
            this.Text = "frmSastojak";
            this.Sastojak.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSastojak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

     

        #endregion

        private System.Windows.Forms.GroupBox Sastojak;
        private System.Windows.Forms.DataGridView dgvSastojak;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SastojakId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
    }
}