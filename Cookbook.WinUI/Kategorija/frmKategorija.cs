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

namespace Cookbook.WinUI.Kategorija
{
    public partial class frmKategorija : Form
    {
        private readonly APIService _apiService = new APIService("kategorija");
        public frmKategorija()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {

            var search = new KategorijaSearchRequest()
            {
                Naziv = txtKategorija.Text
            };
            var result = await _apiService.Get<List<Model.Kategorija>>(search);
            dgvKategorija.AutoGenerateColumns = false;
            dgvKategorija.DataSource = result;
        }

        private void dgvKategorija_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvKategorija.SelectedRows[0].Cells[0].Value;
            frmKategorijaDetalji frm = new frmKategorijaDetalji(int.Parse(id.ToString()));
            frm.Show();
        }

       
    }
}
