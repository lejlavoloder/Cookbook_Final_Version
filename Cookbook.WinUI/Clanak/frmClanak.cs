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

namespace Cookbook.WinUI.Clanak
{
    public partial class frmClanak : Form
    {
        private readonly APIService _clanak = new APIService("Clanak");
        private readonly APIService _vrstaclanka = new APIService("VrstaClanka");
        public frmClanak()
        {
            InitializeComponent();
        }

        private async void cmbVrstaClanka_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbVrstaClanka.SelectedValue;
            if (int.TryParse(idObj.ToString(), out int id))
            {
                await LoadClanci(id);
            }
        }
        private async Task LoadClanci(int id)
        {
            var result = await _clanak.Get<List<Model.Clanak>>(new ClanakSearchRequest()
            {
               VrstaClankaId=id
            });
            dgvClanak.AutoGenerateColumns = false;
            dgvClanak.DataSource = result;
        }
        private async Task LoadClanke()
        {
            var result = await _vrstaclanka.Get<List<Model.VrstaClanka>>(null);
            cmbVrstaClanka.DisplayMember = "Naziv";
            cmbVrstaClanka.ValueMember = "VrstaClankaId";
            result.Insert(0, new Model.VrstaClanka());
            cmbVrstaClanka.DataSource = result;
        }

        private async void frmClanak_Load(object sender, EventArgs e)
        {
            await LoadClanke();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmClanakDetalji frm = new frmClanakDetalji();
            frm.Show();
        }

        private void dgvClanak_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            var id = dgvClanak.SelectedRows[0].Cells[0].Value;
            var frm = new frmClanakDetalji(int.Parse(id.ToString()));
            frm.Show();
        }
    }
}
