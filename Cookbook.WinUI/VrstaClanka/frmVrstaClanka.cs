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

namespace Cookbook.WinUI.VrstaClanka
{
    public partial class frmVrstaClanka : Form
    {
        private readonly APIService _apiService = new APIService("VrstaClanka");
        public frmVrstaClanka()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new VrstaClankaSearchRequest()
            {
                Naziv = txtKategorija.Text
            };
            var result = await _apiService.Get<List<Model.VrstaClanka>>(search);
            dgvVrstaClanka.AutoGenerateColumns = false;
            dgvVrstaClanka.DataSource = result;
        }

        private void dgvVrstaClanka_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvVrstaClanka.SelectedRows[0].Cells[0].Value;
            frmVrstaClankaDetalji frm = new frmVrstaClankaDetalji(int.Parse(id.ToString()));
            frm.Show();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

            frmVrstaClankaDetalji frm = new frmVrstaClankaDetalji();
            frm.Show();
        }
    }
}
