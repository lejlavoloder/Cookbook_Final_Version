using Cookbook.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cookbook.WinUI.Recept
{
    public partial class frmDodajRecept : Form
    {
        private readonly APIService _grupajela = new APIService("GrupaJela");
        private readonly APIService _slozenost = new APIService("Slozenost");
        private readonly APIService _kategorija = new APIService("Kategorija");
        private readonly APIService _recept = new APIService("Recept");
        private readonly APIService _sastojak = new APIService("Sastojak");
        private readonly APIService _mjernajedinica = new APIService("MjernaJedinica");
        private readonly APIService _mjernakolicina = new APIService("MjernaKolicina");
        private readonly APIService _receptSastojak = new APIService("ReceptSastojak");
        List<Model.ReceptSastojak> ListaSastojaka = new List<Model.ReceptSastojak>();


        List<Model.Sastojak> sastojci = new List<Model.Sastojak>();
        List<Model.MjernaJedinica> mjerneJedinice = new List<Model.MjernaJedinica>();
        List<Model.MjernaKolicina> mjerneKolicine = new List<Model.MjernaKolicina>();

        ImageConverter imgConverter = new ImageConverter();
        ReceptUpsertRequest request = new ReceptUpsertRequest();
        public frmDodajRecept()
        {
            InitializeComponent();

            dgvReceptSastojak.AutoGenerateColumns = false;
        }


        private async void Sacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            { 
                if (ListaSastojaka.Any())
                {
                    int.TryParse(txtBrojLjudi.Text, out var n);
                    double.TryParse(txtVrijemeKuhanja.Text, out var m);
                    double.TryParse(txtVrijemePripreme.Text, out var mm);

                    var idObj = cmbGrupaJela.SelectedValue;
                    var idObj1 = cmbKategorija.SelectedValue;
                    var idObj2 = cmbSlozenost.SelectedValue;
                    if (int.TryParse(idObj.ToString(), out int GrupaJelaId) && (int.TryParse(idObj1.ToString(), out int KategorijaId)) &&
                        (int.TryParse(idObj2.ToString(), out int SlozenostId)))
                    {
                        ReceptUpsertRequest request = new ReceptUpsertRequest()
                        {
                            GrupaJelaId = GrupaJelaId,
                            KategorijaId = KategorijaId,
                            SlozenostId = SlozenostId,
                            Naziv = txtNaziv.Text,
                            Tekst = richTextBtxtTekstox1.Text,
                            DatumObjave = dtObjave.Value,
                            BrojLjudi = n,
                            VrijemeKuhanja = m,
                            VrijemePripreme = mm,
                            Odobren = true,
                            Slika = (System.Byte[])imgConverter.ConvertTo(pictureBox1.Image, Type.GetType("System.Byte[]")),
                            KorisnikId = 1
                        };
                        var entity = await _recept.Insert<Model.Recept>(request);

                        ListaSastojaka.ForEach(x => x.ReceptId = entity.ReceptId);

                        foreach (var item in ListaSastojaka)
                        {
                            ReceptSastojakUpsertRequest requestSastojak = new ReceptSastojakUpsertRequest()
                            {
                                SastojakId = item.SastojakId,
                                MjernaJedinicaId = item.MjernaJedinicaId,
                                MjernaKolicinaId = item.MjernaKolicinaId,
                                ReceptId = item.ReceptId

                            };

                            var sastojak = await _receptSastojak.Insert<Model.ReceptSastojak>(requestSastojak);
                          
                        }
                        MessageBox.Show("Uspješno sačuvani podaci");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Niste unijeli nijedan sastojak, ne mozete pohraniti podatke");
                }
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidateSastojciCmb())
            {
                var idObj = cmbSastojak.SelectedValue;
                var idObj1 = cmbMjernaKoličina.SelectedValue;
                var idObj2 = cmbMjernaJedinica.SelectedValue;
                if (int.TryParse(idObj.ToString(), out int SastojakId) && (int.TryParse(idObj1.ToString(), out int MjernaKolicinaId)) &&
                    (int.TryParse(idObj2.ToString(), out int MjernaJedinicaId)))
                {
                    Model.ReceptSastojak receptSastojak = new Model.ReceptSastojak
                    {
                        SastojakId = SastojakId,
                        Sastojak = sastojci.FirstOrDefault(x => x.SastojakId == SastojakId).Naziv,
                        MjernaJedinicaId = MjernaJedinicaId,
                        MjernaJedinica = mjerneJedinice.FirstOrDefault(x => x.MjernaJedinicaId == MjernaJedinicaId).Naziv,
                        MjernaKolicinaId = MjernaKolicinaId,
                        MjernaKolicina = mjerneKolicine.FirstOrDefault(x => x.MjernaKolicinaId == MjernaKolicinaId).Kolicina,
                    };

                    ListaSastojaka.Add(receptSastojak);
                    cmbSastojak.SelectedValue = 0;
                    cmbMjernaKoličina.SelectedValue = 0;
                    cmbMjernaJedinica.SelectedValue = 0;

                    dgvReceptSastojak.DataSource = null;
                    dgvReceptSastojak.DataSource = ListaSastojaka;
                }
            }
        }

        private bool ValidateSastojciCmb()
        {

            if (cmbSastojak.SelectedValue == null || (int)cmbSastojak.SelectedValue == 0)
                errorProvider.SetError(cmbSastojak, Properties.Resources.Validation_RequiredField);
            else
                errorProvider.SetError(cmbSastojak, null);

            if (cmbMjernaJedinica.SelectedValue == null || (int)cmbMjernaJedinica.SelectedValue == 0)
                errorProvider.SetError(cmbMjernaJedinica, Properties.Resources.Validation_RequiredField);
            else
                errorProvider.SetError(cmbMjernaJedinica, null);


            if (cmbMjernaKoličina.SelectedValue == null || (int)cmbMjernaKoličina.SelectedValue == 0)
                errorProvider.SetError(cmbMjernaKoličina, Properties.Resources.Validation_RequiredField);
            else
                errorProvider.SetError(cmbMjernaKoličina, null);

           var result = string.IsNullOrWhiteSpace(errorProvider.GetError(cmbSastojak)) &&
                   string.IsNullOrWhiteSpace(errorProvider.GetError(cmbMjernaJedinica)) &&
                   string.IsNullOrWhiteSpace(errorProvider.GetError(cmbMjernaKoličina));

            return result;
        }

        private async void frmTest_Load(object sender, EventArgs e)
        {
            await LoadGrupaJela();
            await LoadKategorija();
            await LoadSlozenost();

            await LoadSastojci();
            await LoadMjernaKolicina();
            await LoadMjernaJedinica();


        }
        private async Task LoadGrupaJela()
        {
            var result = await _grupajela.Get<List<Model.GrupaJela>>(null);
            cmbGrupaJela.DisplayMember = "Naziv";
            cmbGrupaJela.ValueMember = "GrupaJelaId";
            result.Insert(0, new Model.GrupaJela { Naziv = "Odaberi" });
            cmbGrupaJela.DataSource = result;
        }
        private async Task LoadKategorija()
        {
            var result = await _kategorija.Get<List<Model.Kategorija>>(null);
            cmbKategorija.DisplayMember = "Naziv";
            cmbKategorija.ValueMember = "KategorijaId";
            result.Insert(0, new Model.Kategorija { Naziv = "Odaberi" });
            cmbKategorija.DataSource = result;
        }
        private async Task LoadSlozenost()
        {
            var result = await _slozenost.Get<List<Model.Slozenost>>(null);
            cmbSlozenost.DisplayMember = "Naziv";
            cmbSlozenost.ValueMember = "SlozenostId";
            result.Insert(0, new Model.Slozenost { Naziv = "Odaberi" });
            cmbSlozenost.DataSource = result;
        }
        private async Task LoadSastojci()
        {
            sastojci = await _sastojak.Get<List<Model.Sastojak>>(null);
            cmbSastojak.DisplayMember = "Naziv";
            cmbSastojak.ValueMember = "SastojakId";
            sastojci.Insert(0, new Model.Sastojak { Naziv = "Odaberi" });
            cmbSastojak.DataSource = sastojci;
        }
        private async Task LoadMjernaKolicina()
        {
            mjerneKolicine = await _mjernakolicina.Get<List<Model.MjernaKolicina>>(null);
            cmbMjernaKoličina.DisplayMember = "Kolicina";
            cmbMjernaKoličina.ValueMember = "MjernaKolicinaId";
            mjerneKolicine.Insert(0, new Model.MjernaKolicina { Kolicina = 0 });
            cmbMjernaKoličina.DataSource = mjerneKolicine;
        }
        private async Task LoadMjernaJedinica()
        {
            mjerneJedinice = await _mjernajedinica.Get<List<Model.MjernaJedinica>>(null);
            cmbMjernaJedinica.DisplayMember = "Naziv";
            cmbMjernaJedinica.ValueMember = "MjernaJedinicaId";
            mjerneJedinice.Insert(0, new Model.MjernaJedinica { Naziv = "Odaberi" });
            cmbMjernaJedinica.DataSource = mjerneJedinice;
        }

        private void btnSlika_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;

                var file = File.ReadAllBytes(fileName);

                request.Slika = file;
                txtInputSlike.Text = fileName;

                Image image = Image.FromFile(fileName);
                pictureBox1.Image = image;
            }
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNaziv.Text))
            {
                errorProvider.SetError(txtNaziv, Properties.Resources.Validation_RequiredField);
                //e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtNaziv.Text, @"^[a-zA-Z ]+$"))
            {
                errorProvider.SetError(txtNaziv, Properties.Resources.NeispravanFormat);
                //e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtNaziv, null);
            }
        }

        private void txtVrijemePripreme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtVrijemePripreme.Text))
            {
                errorProvider.SetError(txtVrijemePripreme, Properties.Resources.Validation_RequiredField);
                //e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtVrijemePripreme.Text, @"^[0-9]+$"))
            {
                errorProvider.SetError(txtVrijemePripreme, Properties.Resources.NeispravanFormat);
                //e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtVrijemePripreme, null);
            }
        }

        private void txtVrijemeKuhanja_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtVrijemeKuhanja.Text))
            {
                errorProvider.SetError(txtVrijemeKuhanja, Properties.Resources.Validation_RequiredField);
                // e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtVrijemeKuhanja.Text, @"^[0-9]+$"))
            {
                errorProvider.SetError(txtVrijemeKuhanja, Properties.Resources.NeispravanFormat);
                //e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtVrijemeKuhanja, null);
            }
        }

        private void txtBrojLjudi_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBrojLjudi.Text))
            {
                errorProvider.SetError(txtBrojLjudi, Properties.Resources.Validation_RequiredField);
                //e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtBrojLjudi.Text, @"^[0-9]+$"))
            {
                errorProvider.SetError(txtBrojLjudi, Properties.Resources.NeispravanFormat);
                //e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtBrojLjudi, null);
            }
        }

        private void cmbKategorija_Validating(object sender, CancelEventArgs e)
        {
            if (cmbKategorija.SelectedValue == null || (int)cmbKategorija.SelectedValue == 0)
            {
                errorProvider.SetError(cmbKategorija, Properties.Resources.Validation_RequiredField);
                //e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbKategorija, null);
            }
        }

        private void cmbSlozenost_Validating(object sender, CancelEventArgs e)
        {

            if (cmbSlozenost.SelectedValue == null || (int)cmbSlozenost.SelectedValue == 0)
            {
                errorProvider.SetError(cmbSlozenost, Properties.Resources.Validation_RequiredField);
                // e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbSlozenost, null);
            }
        }

        private void cmbGrupaJela_Validating(object sender, CancelEventArgs e)
        {

            if (cmbGrupaJela.SelectedValue == null || (int)cmbGrupaJela.SelectedValue == 0)
            {
                errorProvider.SetError(cmbGrupaJela, Properties.Resources.Validation_RequiredField);
                // e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbGrupaJela, null);
            }
        }

        private void richTextBtxtTekstox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBtxtTekstox1.Text))
            {
                errorProvider.SetError(richTextBtxtTekstox1, Properties.Resources.Validation_RequiredField);
                // e.Cancel = true;
            }
            else if (!Regex.IsMatch(richTextBtxtTekstox1.Text, @"^[a-zA-Z ]+$"))
            {
                errorProvider.SetError(richTextBtxtTekstox1, Properties.Resources.NeispravanFormat);
                // e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(richTextBtxtTekstox1, null);
            }
        }

    }
}
