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

namespace Cookbook.WinUI.Posjetitelj
{
    public partial class frmPosjetitelj : Form
    {
        APIService _apiService = new APIService("Posjetilac");
        public frmPosjetitelj()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new PosjetilacSearchRequest()
            {
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
            };

            var list = await _apiService.Get<List<Model.Posjetilac>>(search);
            dgvKorisnik.AutoGenerateColumns = false;
            dgvKorisnik.DataSource = list;
        }

        private void dgvKorisnik_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var korisnikId = int.Parse(dgvKorisnik.SelectedRows[0].Cells[0].Value.ToString());

            frmPosjetiteljDetalji frm = new frmPosjetiteljDetalji(korisnikId);
            frm.Show();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmPosjetiteljDetalji frm = new frmPosjetiteljDetalji();
            frm.Show();
        }
    }
}
