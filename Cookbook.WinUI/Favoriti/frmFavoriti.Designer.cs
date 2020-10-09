namespace Cookbook.WinUI.Favoriti
{
    partial class frmFavoriti
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
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvFavoriti = new System.Windows.Forms.DataGridView();
            this.FavoritiId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceptId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.favoriti = new System.Windows.Forms.GroupBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFavoriti)).BeginInit();
            this.favoriti.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // dgvFavoriti
            // 
            this.dgvFavoriti.AllowUserToAddRows = false;
            this.dgvFavoriti.AllowUserToDeleteRows = false;
            this.dgvFavoriti.BackgroundColor = System.Drawing.Color.Ivory;
            this.dgvFavoriti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFavoriti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FavoritiId,
            this.ReceptId,
            this.Recept});
            this.dgvFavoriti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFavoriti.Location = new System.Drawing.Point(4, 19);
            this.dgvFavoriti.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFavoriti.Name = "dgvFavoriti";
            this.dgvFavoriti.ReadOnly = true;
            this.dgvFavoriti.RowHeadersWidth = 51;
            this.dgvFavoriti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFavoriti.Size = new System.Drawing.Size(265, 381);
            this.dgvFavoriti.TabIndex = 0;
            this.dgvFavoriti.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvFavoriti_MouseDoubleClick);
            // 
            // FavoritiId
            // 
            this.FavoritiId.DataPropertyName = "FavoritiId";
            this.FavoritiId.HeaderText = "FavoritiId";
            this.FavoritiId.MinimumWidth = 6;
            this.FavoritiId.Name = "FavoritiId";
            this.FavoritiId.ReadOnly = true;
            this.FavoritiId.Visible = false;
            this.FavoritiId.Width = 125;
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
            // Recept
            // 
            this.Recept.DataPropertyName = "Recept";
            this.Recept.HeaderText = "Naziv";
            this.Recept.MinimumWidth = 6;
            this.Recept.Name = "Recept";
            this.Recept.ReadOnly = true;
            this.Recept.Width = 125;
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(526, 23);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(75, 27);
            this.btnPretraga.TabIndex = 75;
            this.btnPretraga.Text = "Pretraži";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // favoriti
            // 
            this.favoriti.Controls.Add(this.dgvFavoriti);
            this.favoriti.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.favoriti.Location = new System.Drawing.Point(176, 103);
            this.favoriti.Margin = new System.Windows.Forms.Padding(4);
            this.favoriti.Name = "favoriti";
            this.favoriti.Padding = new System.Windows.Forms.Padding(4);
            this.favoriti.Size = new System.Drawing.Size(273, 404);
            this.favoriti.TabIndex = 74;
            this.favoriti.TabStop = false;
            this.favoriti.Text = "Favoriti";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(176, 28);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(273, 22);
            this.txtNaziv.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 77;
            this.label1.Text = "Naziv recepta";
            // 
            // frmFavoriti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 512);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.favoriti);
            this.Name = "frmFavoriti";
            this.Text = "frmFavoriti";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFavoriti)).EndInit();
            this.favoriti.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.GroupBox favoriti;
        private System.Windows.Forms.DataGridView dgvFavoriti;
        private System.Windows.Forms.DataGridViewTextBoxColumn FavoritiId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceptId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recept;
    }
}