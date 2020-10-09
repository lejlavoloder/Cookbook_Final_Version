using Cookbook.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cookbook.WinUI.Recept
{
    public partial class frmDetaljiRecepta : Form
    {
        private readonly APIService _kategorija = new APIService("Kategorija");
        private readonly APIService _grupajela = new APIService("GrupaJela");
        private readonly APIService _slozenost = new APIService("Slozenost");
        private readonly APIService _recept = new APIService("Recept");
      

        private int? _id = null;
        public frmDetaljiRecepta(int?ReceptId=null)
        {
            InitializeComponent();
            _id = ReceptId;
        }
        private async void frmDetaljiRecepta_Load(object sender, EventArgs e)
        {
            await LoadGrupaJela();
            await LoadSlozenost();
            await LoadKategorija();
            if (_id.HasValue)
            {
                var recept = await _recept.GetById<Model.Recept>(_id);
                cmbGrupaJela.SelectedValue = int.Parse(recept.GrupaJelaId.ToString());
                cmbSlozenost.SelectedValue = int.Parse(recept.SlozenostId.ToString());
                cmbKategorija.SelectedValue = int.Parse(recept.KategorijaId.ToString());
                txtNaziv.Text = recept.Naziv;
                richTextBtxtTekstox1.Text = recept.Tekst;
                txtVrijemeKuhanja.Text = recept.VrijemeKuhanja.ToString();
                txtVrijemePripreme.Text = recept.VrijemePripreme.ToString();
                txtBrojLjudi.Text = recept.VrijemePripreme.ToString();
                dtObjave.Value = recept.DatumObjave;
            }
        }
        private async Task LoadGrupaJela()
        {
            var result = await _grupajela.Get<List<Model.GrupaJela>>(null);
            cmbGrupaJela.DisplayMember = "Naziv";
            cmbGrupaJela.ValueMember = "GrupaJelaId";
            result.Insert(0, new Model.GrupaJela
            {
                Naziv = "Odaberite"
            });
            cmbGrupaJela.DataSource = result;
        }
        private async Task LoadSlozenost()
        {
            var result = await _slozenost.Get<List<Model.Slozenost>>(null);
            cmbSlozenost.DisplayMember = "Naziv";
            cmbSlozenost.ValueMember = "SlozenostId";
            result.Insert(0, new Model.Slozenost
            {
                Naziv = "Odaberite"
            });
            cmbSlozenost.DataSource = result;
        }
        private async Task LoadKategorija()
        {
            var result = await _kategorija.Get<List<Model.Kategorija>>(null);
            cmbKategorija.DisplayMember = "Naziv";
            cmbKategorija.ValueMember = "KategorijaId";
            result.Insert(0, new Model.Kategorija
            {
                Naziv = "Odaberite"
            });
            cmbKategorija.DataSource = result;
        }

        private async void Sacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (_id.HasValue)
                {
                    try
                    {
                        ReceptUpsertRequest request = new ReceptUpsertRequest();
                        var idObj = cmbGrupaJela.SelectedValue;
                        var idObj1 = cmbKategorija.SelectedValue;
                        var idObj2 = cmbSlozenost.SelectedValue;
                        if ((int.TryParse(idObj.ToString(), out int GrupaJelaId))
                            && (int.TryParse(idObj1.ToString(), out int KategorijaId))
                            && (int.TryParse(idObj2.ToString(), out int SlozenostId)))
                        {
                            var recept = await _recept.GetById<Model.Recept>(_id);
                            request.KategorijaId = KategorijaId;
                            request.SlozenostId = SlozenostId;
                            request.GrupaJelaId = GrupaJelaId;
                            request.Tekst = richTextBtxtTekstox1.Text;
                            request.Naziv = txtNaziv.Text;
                            int.TryParse(txtBrojLjudi.Text, out var n);
                            request.BrojLjudi = n;
                            double.TryParse(txtVrijemeKuhanja.Text, out var c);
                            request.VrijemeKuhanja = c;
                            double.TryParse(txtVrijemePripreme.Text, out var d);
                            request.VrijemePripreme = d;
                            request.Odobren = true;
                            request.DatumObjave = dtObjave.Value;
                            request.KorisnikId = recept.KorisnikId;
                         //   request.ReceptId = recept.ReceptId;
                            request.Slika = recept.Slika;
                        }
                        await _recept.Update<Model.Recept>(_id.Value, request);
                        MessageBox.Show("Uspješno sačuvani podaci");
                        this.Close();
                    }

                    catch (Exception)
                    {
                        DialogResult r = MessageBox.Show("Nemate pravo pristupa");
                        if (r == DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                }
            }

        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNaziv.Text))
            {
                errorProvider.SetError(txtNaziv, Properties.Resources.Validation_RequiredField);
               // e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtNaziv.Text, @"^[a-zA-Z ]+$"))
            {
                errorProvider.SetError(txtNaziv, Properties.Resources.NeispravanFormat);
               // e.Cancel = true;
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
               // e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtVrijemePripreme.Text, @"^[0-9]+$"))
            {
                errorProvider.SetError(txtVrijemePripreme, Properties.Resources.NeispravanFormat);
              //  e.Cancel = true;
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
              //  e.Cancel = true;
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
               // e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtBrojLjudi.Text, @"^[0-9]+$"))
            {
                errorProvider.SetError(txtBrojLjudi, Properties.Resources.NeispravanFormat);
              //  e.Cancel = true;
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
               // e.Cancel = true;
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
              //  e.Cancel = true;
            }
            else if (!Regex.IsMatch(richTextBtxtTekstox1.Text, @"^[a-zA-Z ]+$"))
            {
                errorProvider.SetError(richTextBtxtTekstox1, Properties.Resources.NeispravanFormat);
                //e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(richTextBtxtTekstox1, null);
            }
        }
    }
}
