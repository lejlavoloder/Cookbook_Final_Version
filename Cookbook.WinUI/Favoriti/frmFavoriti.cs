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

namespace Cookbook.WinUI.Favoriti
{
    public partial class frmFavoriti : Form
    {

        APIService _apiService = new APIService("Favoriti");
        public frmFavoriti()
        {
            InitializeComponent();
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            var search = new FavoritiSearchRequest()
            {
                Recept = txtNaziv.Text
            };

            var list = await _apiService.Get<List<Model.Favoriti>>(search);
            dgvFavoriti.AutoGenerateColumns = false;
            dgvFavoriti.DataSource = list;
        }

        private void dgvFavoriti_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvFavoriti.SelectedRows[0].Cells[0].Value;

            frmFavoritiDetalji frm = new frmFavoritiDetalji(int.Parse(id.ToString()));
            frm.Show();
        }
    }
}
  
