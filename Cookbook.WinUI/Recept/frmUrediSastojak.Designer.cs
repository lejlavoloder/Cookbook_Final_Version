namespace Cookbook.WinUI.Recept
{
    partial class frmUrediSastojak
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
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.cmbMjernaKoličina = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMjernaJedinica = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbSastojak = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(388, 223);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(81, 30);
            this.btnSacuvaj.TabIndex = 70;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // cmbMjernaKoličina
            // 
            this.cmbMjernaKoličina.FormattingEnabled = true;
            this.cmbMjernaKoličina.Location = new System.Drawing.Point(152, 160);
            this.cmbMjernaKoličina.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMjernaKoličina.Name = "cmbMjernaKoličina";
            this.cmbMjernaKoličina.Size = new System.Drawing.Size(265, 24);
            this.cmbMjernaKoličina.TabIndex = 69;
            this.cmbMjernaKoličina.Validating += new System.ComponentModel.CancelEventHandler(this.cmbMjernaKoličina_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 68;
            this.label1.Text = "Mjerna količina";
            // 
            // cmbMjernaJedinica
            // 
            this.cmbMjernaJedinica.FormattingEnabled = true;
            this.cmbMjernaJedinica.Location = new System.Drawing.Point(152, 94);
            this.cmbMjernaJedinica.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMjernaJedinica.Name = "cmbMjernaJedinica";
            this.cmbMjernaJedinica.Size = new System.Drawing.Size(265, 24);
            this.cmbMjernaJedinica.TabIndex = 67;
            this.cmbMjernaJedinica.Validating += new System.ComponentModel.CancelEventHandler(this.cmbMjernaJedinica_Validating);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(39, 94);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 17);
            this.label13.TabIndex = 66;
            this.label13.Text = "Mjerna jedinica";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(44, 42);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 17);
            this.label12.TabIndex = 65;
            this.label12.Text = "Sastojak";
            // 
            // cmbSastojak
            // 
            this.cmbSastojak.FormattingEnabled = true;
            this.cmbSastojak.Location = new System.Drawing.Point(152, 39);
            this.cmbSastojak.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSastojak.Name = "cmbSastojak";
            this.cmbSastojak.Size = new System.Drawing.Size(265, 24);
            this.cmbSastojak.TabIndex = 64;
            this.cmbSastojak.Validating += new System.ComponentModel.CancelEventHandler(this.cmbSastojak_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmUrediSastojak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 278);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.cmbMjernaKoličina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMjernaJedinica);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbSastojak);
            this.Name = "frmUrediSastojak";
            this.Text = "UrediSastojak";
            this.Load += new System.EventHandler(this.frmUrediSastojak_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.ComboBox cmbMjernaKoličina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMjernaJedinica;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbSastojak;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}