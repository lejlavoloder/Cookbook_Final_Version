namespace Cookbook.WinUI.Recept
{
    partial class frmDodajRecept
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chBoxAktivan = new System.Windows.Forms.CheckBox();
            this.cmbGrupaJela = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbSlozenost = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbKategorija = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBrojLjudi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVrijemeKuhanja = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVrijemePripreme = new System.Windows.Forms.TextBox();
            this.btnSlika = new System.Windows.Forms.Button();
            this.txtInputSlike = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtObjave = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.richTextBtxtTekstox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Recept = new System.Windows.Forms.GroupBox();
            this.dgvReceptSastojak = new System.Windows.Forms.DataGridView();
            this.Sastojak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MjernaKolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MjernaJedinica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.cmbMjernaKoličina = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbMjernaJedinica = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbSastojak = new System.Windows.Forms.ComboBox();
            this.Sacuvaj = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.Recept.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceptSastojak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(20, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(989, 729);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chBoxAktivan);
            this.tabPage1.Controls.Add(this.cmbGrupaJela);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.cmbSlozenost);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.cmbKategorija);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txtBrojLjudi);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtVrijemeKuhanja);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtVrijemePripreme);
            this.tabPage1.Controls.Add(this.btnSlika);
            this.tabPage1.Controls.Add(this.txtInputSlike);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.dtObjave);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtNaziv);
            this.tabPage1.Controls.Add(this.richTextBtxtTekstox1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(981, 700);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Recept";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chBoxAktivan
            // 
            this.chBoxAktivan.AutoSize = true;
            this.chBoxAktivan.Location = new System.Drawing.Point(373, 632);
            this.chBoxAktivan.Margin = new System.Windows.Forms.Padding(4);
            this.chBoxAktivan.Name = "chBoxAktivan";
            this.chBoxAktivan.Size = new System.Drawing.Size(76, 21);
            this.chBoxAktivan.TabIndex = 83;
            this.chBoxAktivan.Text = "Aktivan";
            this.chBoxAktivan.UseVisualStyleBackColor = true;
            // 
            // cmbGrupaJela
            // 
            this.cmbGrupaJela.FormattingEnabled = true;
            this.cmbGrupaJela.Location = new System.Drawing.Point(196, 382);
            this.cmbGrupaJela.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGrupaJela.Name = "cmbGrupaJela";
            this.cmbGrupaJela.Size = new System.Drawing.Size(265, 24);
            this.cmbGrupaJela.TabIndex = 82;
            this.cmbGrupaJela.Validating += new System.ComponentModel.CancelEventHandler(this.cmbGrupaJela_Validating);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(73, 382);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 17);
            this.label13.TabIndex = 81;
            this.label13.Text = "Grupa jela";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(73, 323);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 17);
            this.label12.TabIndex = 80;
            this.label12.Text = "Složenost";
            // 
            // cmbSlozenost
            // 
            this.cmbSlozenost.FormattingEnabled = true;
            this.cmbSlozenost.Location = new System.Drawing.Point(196, 320);
            this.cmbSlozenost.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSlozenost.Name = "cmbSlozenost";
            this.cmbSlozenost.Size = new System.Drawing.Size(265, 24);
            this.cmbSlozenost.TabIndex = 79;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(73, 257);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 17);
            this.label11.TabIndex = 78;
            this.label11.Text = "Kategorija";
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.Location = new System.Drawing.Point(196, 257);
            this.cmbKategorija.Margin = new System.Windows.Forms.Padding(4);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(265, 24);
            this.cmbKategorija.TabIndex = 77;
            this.cmbKategorija.Validating += new System.ComponentModel.CancelEventHandler(this.cmbKategorija_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(73, 184);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 17);
            this.label9.TabIndex = 76;
            this.label9.Text = "Broj ljudi";
            // 
            // txtBrojLjudi
            // 
            this.txtBrojLjudi.Location = new System.Drawing.Point(196, 184);
            this.txtBrojLjudi.Margin = new System.Windows.Forms.Padding(4);
            this.txtBrojLjudi.Name = "txtBrojLjudi";
            this.txtBrojLjudi.Size = new System.Drawing.Size(265, 22);
            this.txtBrojLjudi.TabIndex = 75;
            this.txtBrojLjudi.Validating += new System.ComponentModel.CancelEventHandler(this.txtBrojLjudi_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(109, 216);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 17);
            this.label10.TabIndex = 74;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 130);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 73;
            this.label7.Text = "Vrijeme kuhanja";
            // 
            // txtVrijemeKuhanja
            // 
            this.txtVrijemeKuhanja.Location = new System.Drawing.Point(196, 127);
            this.txtVrijemeKuhanja.Margin = new System.Windows.Forms.Padding(4);
            this.txtVrijemeKuhanja.Name = "txtVrijemeKuhanja";
            this.txtVrijemeKuhanja.Size = new System.Drawing.Size(265, 22);
            this.txtVrijemeKuhanja.TabIndex = 72;
            this.txtVrijemeKuhanja.Validating += new System.ComponentModel.CancelEventHandler(this.txtVrijemeKuhanja_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 159);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 71;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 78);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 70;
            this.label6.Text = "Vrijeme pripreme";
            // 
            // txtVrijemePripreme
            // 
            this.txtVrijemePripreme.Location = new System.Drawing.Point(196, 75);
            this.txtVrijemePripreme.Margin = new System.Windows.Forms.Padding(4);
            this.txtVrijemePripreme.Name = "txtVrijemePripreme";
            this.txtVrijemePripreme.Size = new System.Drawing.Size(265, 22);
            this.txtVrijemePripreme.TabIndex = 69;
            this.txtVrijemePripreme.Validating += new System.ComponentModel.CancelEventHandler(this.txtVrijemePripreme_Validating);
            // 
            // btnSlika
            // 
            this.btnSlika.Location = new System.Drawing.Point(784, 263);
            this.btnSlika.Margin = new System.Windows.Forms.Padding(4);
            this.btnSlika.Name = "btnSlika";
            this.btnSlika.Size = new System.Drawing.Size(100, 28);
            this.btnSlika.TabIndex = 66;
            this.btnSlika.Text = "Dodaj sliku";
            this.btnSlika.UseVisualStyleBackColor = true;
            this.btnSlika.Click += new System.EventHandler(this.btnSlika_Click);
            // 
            // txtInputSlike
            // 
            this.txtInputSlike.Location = new System.Drawing.Point(619, 233);
            this.txtInputSlike.Margin = new System.Windows.Forms.Padding(4);
            this.txtInputSlike.Name = "txtInputSlike";
            this.txtInputSlike.Size = new System.Drawing.Size(265, 22);
            this.txtInputSlike.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(564, 236);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 64;
            this.label5.Text = "Slika";
            // 
            // dtObjave
            // 
            this.dtObjave.Location = new System.Drawing.Point(20, 632);
            this.dtObjave.Margin = new System.Windows.Forms.Padding(4);
            this.dtObjave.Name = "dtObjave";
            this.dtObjave.Size = new System.Drawing.Size(265, 22);
            this.dtObjave.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 611);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 60;
            this.label3.Text = "Datum/vrijeme objave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 433);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 59;
            this.label2.Text = "Priprema";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 58;
            this.label1.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(196, 18);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(4);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(265, 22);
            this.txtNaziv.TabIndex = 57;
            this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaziv_Validating);
            // 
            // richTextBtxtTekstox1
            // 
            this.richTextBtxtTekstox1.Location = new System.Drawing.Point(196, 430);
            this.richTextBtxtTekstox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBtxtTekstox1.Name = "richTextBtxtTekstox1";
            this.richTextBtxtTekstox1.Size = new System.Drawing.Size(709, 136);
            this.richTextBtxtTekstox1.TabIndex = 68;
            this.richTextBtxtTekstox1.Text = "";
            this.richTextBtxtTekstox1.Validating += new System.ComponentModel.CancelEventHandler(this.richTextBtxtTekstox1_Validating);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(631, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Recept);
            this.tabPage2.Controls.Add(this.btnSacuvaj);
            this.tabPage2.Controls.Add(this.cmbMjernaKoličina);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.cmbMjernaJedinica);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.cmbSastojak);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(981, 700);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sastojci";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Recept
            // 
            this.Recept.Controls.Add(this.dgvReceptSastojak);
            this.Recept.Location = new System.Drawing.Point(7, 106);
            this.Recept.Margin = new System.Windows.Forms.Padding(4);
            this.Recept.Name = "Recept";
            this.Recept.Padding = new System.Windows.Forms.Padding(4);
            this.Recept.Size = new System.Drawing.Size(963, 587);
            this.Recept.TabIndex = 74;
            this.Recept.TabStop = false;
            this.Recept.Text = "Recept";
            // 
            // dgvReceptSastojak
            // 
            this.dgvReceptSastojak.AllowUserToAddRows = false;
            this.dgvReceptSastojak.AllowUserToDeleteRows = false;
            this.dgvReceptSastojak.BackgroundColor = System.Drawing.Color.Ivory;
            this.dgvReceptSastojak.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvReceptSastojak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceptSastojak.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sastojak,
            this.MjernaKolicina,
            this.MjernaJedinica});
            this.dgvReceptSastojak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReceptSastojak.Location = new System.Drawing.Point(4, 19);
            this.dgvReceptSastojak.Margin = new System.Windows.Forms.Padding(4);
            this.dgvReceptSastojak.MultiSelect = false;
            this.dgvReceptSastojak.Name = "dgvReceptSastojak";
            this.dgvReceptSastojak.ReadOnly = true;
            this.dgvReceptSastojak.RowHeadersVisible = false;
            this.dgvReceptSastojak.RowHeadersWidth = 51;
            this.dgvReceptSastojak.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceptSastojak.Size = new System.Drawing.Size(955, 564);
            this.dgvReceptSastojak.TabIndex = 0;
            // 
            // Sastojak
            // 
            this.Sastojak.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sastojak.DataPropertyName = "Sastojak";
            this.Sastojak.HeaderText = "Naziv sastojka";
            this.Sastojak.MinimumWidth = 6;
            this.Sastojak.Name = "Sastojak";
            this.Sastojak.ReadOnly = true;
            // 
            // MjernaKolicina
            // 
            this.MjernaKolicina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MjernaKolicina.DataPropertyName = "MjernaKolicina";
            this.MjernaKolicina.HeaderText = "Mjerna količina";
            this.MjernaKolicina.MinimumWidth = 6;
            this.MjernaKolicina.Name = "MjernaKolicina";
            this.MjernaKolicina.ReadOnly = true;
            // 
            // MjernaJedinica
            // 
            this.MjernaJedinica.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MjernaJedinica.DataPropertyName = "MjernaJedinica";
            this.MjernaJedinica.HeaderText = "Mjerna jedinica";
            this.MjernaJedinica.MinimumWidth = 6;
            this.MjernaJedinica.Name = "MjernaJedinica";
            this.MjernaJedinica.ReadOnly = true;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(796, 44);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(135, 30);
            this.btnSacuvaj.TabIndex = 73;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // cmbMjernaKoličina
            // 
            this.cmbMjernaKoličina.FormattingEnabled = true;
            this.cmbMjernaKoličina.Location = new System.Drawing.Point(518, 48);
            this.cmbMjernaKoličina.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMjernaKoličina.Name = "cmbMjernaKoličina";
            this.cmbMjernaKoličina.Size = new System.Drawing.Size(239, 24);
            this.cmbMjernaKoličina.TabIndex = 72;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(515, 27);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 17);
            this.label14.TabIndex = 71;
            this.label14.Text = "Mjerna količina";
            // 
            // cmbMjernaJedinica
            // 
            this.cmbMjernaJedinica.FormattingEnabled = true;
            this.cmbMjernaJedinica.Location = new System.Drawing.Point(252, 48);
            this.cmbMjernaJedinica.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMjernaJedinica.Name = "cmbMjernaJedinica";
            this.cmbMjernaJedinica.Size = new System.Drawing.Size(248, 24);
            this.cmbMjernaJedinica.TabIndex = 70;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(249, 27);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 17);
            this.label15.TabIndex = 69;
            this.label15.Text = "Mjerna jedinica";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 27);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 17);
            this.label16.TabIndex = 68;
            this.label16.Text = "Sastojak";
            // 
            // cmbSastojak
            // 
            this.cmbSastojak.FormattingEnabled = true;
            this.cmbSastojak.Location = new System.Drawing.Point(7, 48);
            this.cmbSastojak.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSastojak.Name = "cmbSastojak";
            this.cmbSastojak.Size = new System.Drawing.Size(224, 24);
            this.cmbSastojak.TabIndex = 67;
            // 
            // Sacuvaj
            // 
            this.Sacuvaj.Location = new System.Drawing.Point(820, 756);
            this.Sacuvaj.Name = "Sacuvaj";
            this.Sacuvaj.Size = new System.Drawing.Size(174, 34);
            this.Sacuvaj.TabIndex = 1;
            this.Sacuvaj.Text = "Sacuvaj";
            this.Sacuvaj.UseVisualStyleBackColor = true;
            this.Sacuvaj.Click += new System.EventHandler(this.Sacuvaj_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmDodajRecept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 806);
            this.Controls.Add(this.Sacuvaj);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmDodajRecept";
            this.Text = "frmTest";
            this.Load += new System.EventHandler(this.frmTest_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.Recept.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceptSastojak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Sacuvaj;
        private System.Windows.Forms.ComboBox cmbGrupaJela;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbSlozenost;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbKategorija;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBrojLjudi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVrijemeKuhanja;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVrijemePripreme;
        private System.Windows.Forms.Button btnSlika;
        private System.Windows.Forms.TextBox txtInputSlike;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtObjave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.RichTextBox richTextBtxtTekstox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chBoxAktivan;
        private System.Windows.Forms.GroupBox Recept;
        private System.Windows.Forms.DataGridView dgvReceptSastojak;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.ComboBox cmbMjernaKoličina;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbMjernaJedinica;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbSastojak;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sastojak;
        private System.Windows.Forms.DataGridViewTextBoxColumn MjernaKolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn MjernaJedinica;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}