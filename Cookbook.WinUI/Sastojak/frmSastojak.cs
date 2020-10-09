using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cookbook.Model.Requests;
using Flurl;
using Flurl.Http;

namespace Cookbook.WinUI.Sastojak
{
    public partial class frmSastojak : Form
    {
        private readonly APIService _apiService = new APIService("sastojak");
        public frmSastojak()
        {
            InitializeComponent();
        }


        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new SastojakSearchRequest()
            {
                Naziv = txtPretraga.Text
            };
            var result = await _apiService.Get<List<Model.Sastojak>>(search);
            dgvSastojak.AutoGenerateColumns = false;
            dgvSastojak.DataSource = result;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmSastojakDetalji frm = new frmSastojakDetalji();
            frm.Show();
        }

        private void dgvSastojak_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvSastojak.SelectedRows[0].Cells[0].Value;

       frmSastojakDetalji frm = new frmSastojakDetalji(int.Parse(id.ToString()));
            frm.Show();
        }
     
    }
}
