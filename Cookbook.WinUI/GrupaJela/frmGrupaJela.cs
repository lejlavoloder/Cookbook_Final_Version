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

namespace Cookbook.WinUI.GrupaJela
{
    public partial class frmGrupaJela : Form
    {
        private readonly APIService _apiService = new APIService("GrupaJela");
        public frmGrupaJela()
        {
            InitializeComponent();
            this.dgvGrupaJela.DataError +=
                new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvGrupaJela_DataError);
        }
        private void dgvGrupaJela_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;

        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new GrupaJelaSearchRequest()
            {
                Naziv=txtNaziv.Text
            };
            var result = await _apiService.Get<List<Model.GrupaJela>>(search);
            dgvGrupaJela.AutoGenerateColumns = false;
            dgvGrupaJela.DataSource = result;
        }

        private void dgvGrupaJela_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvGrupaJela.SelectedRows[0].Cells[0].Value;

            frmGrupaJelaDetalji frm = new frmGrupaJelaDetalji(int.Parse(id.ToString()));
            frm.Show();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmGrupaJelaDetalji frm = new frmGrupaJelaDetalji();
            frm.Show();
        }
    }
}
