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

namespace Cookbook.WinUI.MjernaKolicina
{
    public partial class frmMjernaKolicina : Form
    {
        private readonly APIService _apiService = new APIService("MjernaKolicina");
        public frmMjernaKolicina()
        {
            InitializeComponent();
        }
   
        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            MjernaKolicinaSearchRequest request = new MjernaKolicinaSearchRequest
            {
                Kolicina = txtNaziv.Text
            };
            double.TryParse(request.Kolicina, out var n);

            try
            {
                var result = await _apiService.Get<List<Model.MjernaKolicina>>(n);
                dgvMjernaKolicina.DataSource = result;
            }
            catch(Exception)
            {
                DialogResult r = MessageBox.Show("Nemate pravo pristupa");
                if (r == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void dgvMjernaKolicina_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvMjernaKolicina.SelectedRows[0].Cells[0].Value;
            var frm = new frmMjernaKolicinaDetalji(int.Parse(id.ToString()));
            frm.Show();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmMjernaKolicinaDetalji frm = new frmMjernaKolicinaDetalji();
            frm.Show();
        }
    }
}
