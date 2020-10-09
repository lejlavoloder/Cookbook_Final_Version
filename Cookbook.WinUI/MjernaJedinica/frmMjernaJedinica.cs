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

namespace Cookbook.WinUI.MjernaJedinica
{
    public partial class frmMjernaJedinica : Form
    {
        private readonly APIService _apiService = new APIService("MjernaJedinica");
        public frmMjernaJedinica()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new MjernaJedinicaSearchRequest()
            {
                Naziv = txtMjernaJedinica.Text
            };
            var result = await _apiService.Get<List<Model.MjernaJedinica>>(search);
            dgvMjernaJedinica.AutoGenerateColumns = false;
            dgvMjernaJedinica.DataSource = result;
        }

        private void dgvMjernaJedinica_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvMjernaJedinica.SelectedRows[0].Cells[0].Value;

            frmMjernaJedinicaDetalji frm = new frmMjernaJedinicaDetalji(int.Parse(id.ToString()));
            frm.Show();
        }

      
    }
}
