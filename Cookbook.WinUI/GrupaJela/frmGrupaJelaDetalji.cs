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

namespace Cookbook.WinUI.GrupaJela
{
    public partial class frmGrupaJelaDetalji : Form
    {
        private readonly APIService _apiService = new APIService("GrupaJela");
        private int? _id = null;

        public frmGrupaJelaDetalji(int? GrupaJelaId = null)
        {
            InitializeComponent();
            _id = GrupaJelaId;
        }

        GrupaJelaUpsertRequest request = new GrupaJelaUpsertRequest();
        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                request.Naziv = txtNaziv.Text;
                request.Opis = txtOpis.Text;
       
                if (_id.HasValue)
                {
                    await _apiService.Update<Model.GrupaJela>(_id.Value, request);
                }
                else
                {
                    await _apiService.Insert<Model.GrupaJela>(request);
                }
                MessageBox.Show("Uspješno sačuvani podaci");
                this.Close();
            }
            else
            {
                MessageBox.Show("Operacija nije uspjela");
                this.Close();
            }

        }

        private async void frmGrupaJelaDetalji_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var grupajela = await _apiService.GetById<Model.GrupaJela>(_id);
                txtNaziv.Text = grupajela.Naziv;
                txtOpis.Text = grupajela.Opis;
            }
            }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNaziv.Text))
            {
                errorProvider.SetError(txtNaziv, Properties.Resources.Validation_RequiredField);
              //  e.Cancel = true;
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

        private void txtOpis_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtOpis.Text))
            {
                errorProvider.SetError(txtOpis, Properties.Resources.Validation_RequiredField);
               // e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtOpis.Text, @"^[a-zA-Z -]+$"))
            {
                errorProvider.SetError(txtOpis, Properties.Resources.NeispravanFormat);
              //  e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtOpis, null);
            }
        }
    }
}
