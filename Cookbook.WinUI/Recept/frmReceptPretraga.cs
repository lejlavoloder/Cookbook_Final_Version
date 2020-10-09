using Cookbook.Model.Requests;
using Cookbook.WinUI.Reporti;
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
    public partial class frmReceptPretraga : Form
    {
        private readonly APIService _kategorija = new APIService("Kategorija");
        private readonly APIService _grupajela = new APIService("GrupaJela");
        private readonly APIService _slozenost = new APIService("Slozenost");
        private readonly APIService _recept = new APIService("Recept");
        public frmReceptPretraga()
        {
            InitializeComponent();
        }

        private async void frmReceptPretraga_Load(object sender, EventArgs e)
        {
            await LoadKategorije();
            await LoadGrupaJela();
            await LoadSlozenost();
        }
        private async Task LoadKategorije()
        {
            var result = await _kategorija.Get<List<Model.Kategorija>>(null);
            cmbKategorija.DisplayMember = "Naziv";
            cmbKategorija.ValueMember = "KategorijaId";
            result.Insert(0, new Model.Kategorija
            {
                Naziv = "Odaberite"
            });
            cmbKategorija.SelectedItem = 0;
            cmbKategorija.DataSource = result;
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
            cmbGrupaJela.SelectedItem = 0;
            cmbGrupaJela.DataSource = result;
        }
        private async Task LoadSlozenost()
        {
            var result = await _slozenost.Get<List<Model.Slozenost>>(null);
            cmbSlozenost.DisplayMember = "Naziv";
            cmbSlozenost.ValueMember = "SlozenostId";
            result.Insert(0, new Model.Slozenost
            {   Naziv = "Odaberite"
            });
            cmbSlozenost.SelectedItem = 0;
            cmbSlozenost.DataSource = result;
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var idObj = cmbSlozenost.SelectedValue;
                var idObj1 = cmbKategorija.SelectedValue;
                var idObj2 = cmbGrupaJela.SelectedValue;
                if ((int.TryParse(idObj.ToString(), out int SlozenostId))
                    && (int.TryParse(idObj1.ToString(), out int KategorijaId))
                    && (int.TryParse(idObj2.ToString(), out int GrupaJelaId)))
                {
                    await LoadRecepti(SlozenostId, KategorijaId, GrupaJelaId);
                }
            }
        }
        private async Task LoadRecepti(int SlozenostId, int KategorijaId,int GrupaJelaId)
        {
            var result = await _recept.Get<List<Model.Recept>>(new ReceptSearchRequest()
            {
                GrupaJelaId=GrupaJelaId,
                KategorijaId=KategorijaId,
                SlozenostId=SlozenostId
            });
            dgvRecept.AutoGenerateColumns = false;
            dgvRecept.DataSource = result;
        }

        private void cmbKategorija_Validating(object sender, CancelEventArgs e)
        {
            if (cmbKategorija.ValueMember == null)
            {
                errorProvider.SetError(cmbKategorija, Properties.Resources.Validation_RequiredField);
                //  e.Cancel = true;
            }
            {
                errorProvider.SetError(cmbKategorija, null);
            }
        }

        private void cmbSlozenost_Validating(object sender, CancelEventArgs e)
        {
            if (cmbSlozenost.ValueMember == null)
            {
                errorProvider.SetError(cmbSlozenost, Properties.Resources.Validation_RequiredField);
                // e.Cancel = true;
            }
            {
                errorProvider.SetError(cmbSlozenost, null);
            }
        }

        private void cmbGrupaJela_Validating(object sender, CancelEventArgs e)
        {
            if (cmbGrupaJela.ValueMember == null)
            {
                errorProvider.SetError(cmbGrupaJela, Properties.Resources.Validation_RequiredField);
                // e.Cancel = true;
            }
            {
                errorProvider.SetError(cmbGrupaJela, null);
            }
        }

        private void dgvRecept_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            var id = dgvRecept.SelectedRows[0].Cells[0].Value;
            // var frm = new frmDetaljiRecepta(int.Parse(id.ToString()));
            var frm = new ReceptSastojakForm(int.Parse(id.ToString()));
            
            frm.Show();
        }

      
    }
}
