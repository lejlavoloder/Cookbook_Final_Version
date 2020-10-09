using Cookbook.Model;
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
    public partial class frmDodajSastojak : Form
    {
        private readonly APIService _sastojak = new APIService("Sastojak");
        private readonly APIService _mjernajedinica = new APIService("MjernaJedinica");
        private readonly APIService _mjernakolicina = new APIService("MjernaKolicina");
        private readonly APIService _receptsastojak = new APIService("ReceptSastojak");
        private readonly APIService _recept = new APIService("Recept");
    
        public frmDodajSastojak()
        {
            InitializeComponent();
        }
        ReceptSastojakUpsertRequest request = new ReceptSastojakUpsertRequest();
        private async void button1_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var idObj = cmbSastojak.SelectedValue;
                var idObj1 = cmbMjernaKoličina.SelectedValue;
                var idObj2 = cmbMjernaJedinica.SelectedValue;
                var idObj3 = cmbRecept.SelectedValue;
                if (int.TryParse(idObj.ToString(), out int SastojakId) && (int.TryParse(idObj1.ToString(), out int MjernaKolicinaId)) &&
                    (int.TryParse(idObj2.ToString(), out int MjernaJedinicaId)) &&
                     (int.TryParse(idObj3.ToString(), out int ReceptId)))
                {
                    ReceptSastojakUpsertRequest request = new ReceptSastojakUpsertRequest()
                    {
                        SastojakId = SastojakId,
                        MjernaJedinicaId = MjernaJedinicaId,
                        MjernaKolicinaId = MjernaKolicinaId,
                        ReceptId=ReceptId
                     
                    };
                    var entity = await _receptsastojak.Insert<Model.ReceptSastojak>(request);
                    MessageBox.Show("Uspješno sačuvani podaci");
                    this.Close();
                }
            }
        }

        private async void frmDodajSastojak_Load(object sender, EventArgs e)
        {
           await LoadRecepti();
           await LoadSastojci();
           await LoadMjernaKolicina();
           await LoadMjernaJedinica();
           
        }
        private async Task LoadRecepti()
        {
            var result = await _recept.Get<List<Model.Recept>>(null);
            cmbRecept.DisplayMember = "Naziv";
            cmbRecept.ValueMember = "ReceptId";
            result.Insert(0, new Model.Recept
            {
                Naziv = "Odaberite"
            });
            cmbRecept.DataSource = result;
        }
        private async Task LoadSastojci()
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
        private  async Task LoadMjernaKolicina()
        {
            var result = await _mjernakolicina.Get<List<Model.MjernaKolicina>>(null);
            cmbMjernaKoličina.DisplayMember = "Kolicina";
            cmbMjernaKoličina.ValueMember = "MjernaKolicinaId";
            cmbMjernaKoličina.SelectedItem = null;
            cmbMjernaKoličina.SelectedText = "--Odaberite--";
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

        private async void cmbRecept_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbRecept.SelectedValue;
            if (int.TryParse(idObj.ToString(), out int id))
            {
                await LoadReceptii(id);
            }
        }
        private async Task LoadReceptii(int id)
        {
           var result = await _receptsastojak.Get<List<Model.ReceptSastojak>>(new ReceptSastojakSearchRequest()
            {
                ReceptId = id
            });
            dgvReceptSastojak.AutoGenerateColumns = false;
            dgvReceptSastojak.DataSource = result;
        }

        private void cmbRecept_Validating(object sender, CancelEventArgs e)
        {
            if (cmbRecept.SelectedValue == null || (int)cmbRecept.SelectedValue == 0)
            {
                errorProvider.SetError(cmbRecept, Properties.Resources.Validation_RequiredField);
                // e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbRecept, null);
            }
        }

        private void cmbSastojak_Validating(object sender, CancelEventArgs e)
        {
            if (cmbSastojak.SelectedValue == null || (int)cmbSastojak.SelectedValue == 0)
            {
                errorProvider.SetError(cmbSastojak, Properties.Resources.Validation_RequiredField);
                //e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbSastojak, null);
            }
        }

        private void cmbMjernaJedinica_Validating(object sender, CancelEventArgs e) {
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
                // e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbMjernaKoličina, null);
            }
        }

        private void dgvReceptSastojak_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvReceptSastojak.SelectedRows[0].Cells[0].Value;
            var frm = new frmUrediSastojak (int.Parse(id.ToString()));
            frm.Show();
        }
    }
}
