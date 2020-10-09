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

namespace Cookbook.WinUI.Slozenost
{
    public partial class frmSlozenost : Form
    {
        private readonly APIService _apiService = new APIService("Slozenost");
        public frmSlozenost()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new SlozenostSearchRequest()
            {
                Naziv = txtNaziv.Text
            };
            var result = await _apiService.Get<List<Model.Slozenost>>(search);
            dgvSlozenost.AutoGenerateColumns = false;
            dgvSlozenost.DataSource = result;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
           frmSlozenostDetalji frm = new frmSlozenostDetalji();
            frm.Show();
        }

        private void dgvSlozenost_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            var id = dgvSlozenost.SelectedRows[0].Cells[0].Value;

            frmSlozenostDetalji frm = new frmSlozenostDetalji(int.Parse(id.ToString()));
            frm.Show();
        }
    }
}
