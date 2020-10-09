using Cookbook.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cookbook.WinUI.Kategorija
{
    public partial class frmKategorijaDetalji : Form
    {
        private readonly APIService _apiService = new APIService("Kategorija");
        private int? _id = null;
        public frmKategorijaDetalji(int? KategorijaId = null)
        {
            InitializeComponent();
            _id = KategorijaId;
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var request = new KategorijaInsertRequest()
                {
                    Naziv = txtNaziv.Text
                };
                if (_id.HasValue)
                {
                    await _apiService.Update<Model.Kategorija>(_id.Value, request);
                }
                else
                {
                    await _apiService.Insert<Model.Kategorija>(request);
                }
                MessageBox.Show("Uspješno sačuvani podaci");
                this.Close();
            }
        }

        private async void frmKategorijaDetalji_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var kategorija = await _apiService.GetById<Model.Kategorija>(_id);
                txtNaziv.Text = kategorija.Naziv;
            }
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNaziv.Text))
            {
                errorProvider.SetError(txtNaziv, Properties.Resources.Validation_RequiredField);
               // e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtNaziv.Text, @"^[a-zA-Z ]+$"))
            {
                errorProvider.SetError(txtNaziv, Properties.Resources.NeispravanFormat);
               // e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtNaziv, null);
            }
        }
    }
}
