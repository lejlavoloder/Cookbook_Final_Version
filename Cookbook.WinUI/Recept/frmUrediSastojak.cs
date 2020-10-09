using Cookbook.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cookbook.WinUI.Recept
{
    public partial class frmUrediSastojak : Form
    {
        private readonly APIService _sastojak = new APIService("Sastojak");
        private readonly APIService _receptSastojak = new APIService("ReceptSastojak");
        private readonly APIService _mjernakolicina = new APIService("MjernaKolicina");
        private readonly APIService _mjernajedinica = new APIService("MjernaJedinica");

        private int? _id = null;
        public frmUrediSastojak(int? ReceptSastojakId = null)
        {
            InitializeComponent();
            _id = ReceptSastojakId;
        }

        private async void frmUrediSastojak_Load(object sender, EventArgs e)
        {
            await LoadMjernaKolicina();
            await LoadMjernaJedinica();
            await LoadSastojak();
            if (_id.HasValue)
            {
                var recept = await _receptSastojak.GetById<Model.ReceptSastojak>(_id);
                cmbSastojak.SelectedValue = int.Parse(recept.SastojakId.ToString());
                cmbMjernaKoličina.SelectedValue = int.Parse(recept.MjernaKolicinaId.ToString());
                cmbMjernaJedinica.SelectedValue = int.Parse(recept.MjernaJedinicaId.ToString());
           
            }
        }
        private async Task LoadMjernaKolicina()
        {
            var result = await _mjernakolicina.Get<List<Model.MjernaKolicina>>(null);
            cmbMjernaKoličina.DisplayMember = "Kolicina";
            cmbMjernaKoličina.ValueMember = "MjernaKolicinaId";
            result.Insert(0, new Model.MjernaKolicina());
            cmbMjernaKoličina.DataSource = result;
        }
        private async Task LoadMjernaJedinica()
        {
            var result = await _mjernajedinica.Get<List<Model.MjernaJedinica>>(null);
            cmbMjernaJedinica.DisplayMember = "Naziv";
            cmbMjernaJedinica.ValueMember = "MjernaJedinicaId";
            result.Insert(0, new Model.MjernaJedinica
            {
                Naziv = "Odaberite"
            });
            cmbMjernaJedinica.DataSource = result;
        }
        private async Task LoadSastojak()
        {
            var result = await _sastojak.Get<List<Model.Sastojak>>(null);
            cmbSastojak.DisplayMember = "Naziv";
            cmbSastojak.ValueMember = "SastojakId";
            result.Insert(0, new Model.Sastojak
            {
                Naziv = "Odaberite"
            });
            cmbSastojak.DataSource = result;
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (_id.HasValue)
                {
                    try
                    {
                        ReceptSastojakUpsertRequest request = new ReceptSastojakUpsertRequest();
                        var idObj = cmbMjernaJedinica.SelectedValue;
                        var idObj1 = cmbMjernaKoličina.SelectedValue;
                        var idObj2 = cmbSastojak.SelectedValue;
                        if ((int.TryParse(idObj.ToString(), out int MjernaJedinicaId))
                            && (int.TryParse(idObj1.ToString(), out int MjernaKolicinaId))
                            && (int.TryParse(idObj2.ToString(), out int SastojakId)))
                        {
                            var recept = await _receptSastojak.GetById<Model.ReceptSastojak>(_id);
                            request.MjernaJedinicaId = MjernaJedinicaId;
                            request.MjernaKolicinaId =MjernaKolicinaId;
                            request.SastojakId = SastojakId;
                            request.ReceptId = recept.ReceptId;
                        }
                        await _receptSastojak.Update<Model.ReceptSastojak>(_id.Value, request);
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

        private void cmbSastojak_Validating(object sender, CancelEventArgs e)
        {
            if (cmbSastojak.SelectedValue == null || (int)cmbSastojak.SelectedValue == 0)
            {
                errorProvider.SetError(cmbSastojak, Properties.Resources.Validation_RequiredField);
                // e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbSastojak, null);
            }

        }

        private void cmbMjernaJedinica_Validating(object sender, CancelEventArgs e)
        {
            if (cmbMjernaJedinica.SelectedValue == null || (int)cmbMjernaJedinica.SelectedValue == 0)
            {
                errorProvider.SetError(cmbMjernaJedinica, Properties.Resources.Validation_RequiredField);
                // e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbMjernaJedinica, null);
            }
        }

        private void cmbMjernaKoličina_Validating(object sender, CancelEventArgs e)
        {
            if (cmbMjernaKoličina.SelectedValue == null || (int)cmbMjernaKoličina.SelectedValue == 0)
            {
                errorProvider.SetError(cmbMjernaKoličina, Properties.Resources.Validation_RequiredField);
                //e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbMjernaKoličina, null);
            }
        }
    }
}

