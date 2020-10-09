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

namespace Cookbook.WinUI.Slozenost
{
    public partial class frmSlozenostDetalji : Form
    {
        private readonly APIService _apiService = new APIService("Slozenost");
        private int? _id = null;
        public frmSlozenostDetalji(int? SlozenostId = null)
        {
            InitializeComponent();
            _id = SlozenostId;
        }
        SlozenostUpsertRequest request = new SlozenostUpsertRequest();
        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                request.Naziv = txtNaziv.Text;
                request.Opis = txtOpis.Text;

                if (_id.HasValue)
                {
                    await _apiService.Update<Model.Slozenost>(_id.Value, request);
                }
                else
                {
                    await _apiService.Insert<Model.Slozenost>(request);
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

        private async void frmSlozenostDetalji_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var slozenost = await _apiService.GetById<Model.Slozenost>(_id);
                txtNaziv.Text = slozenost.Naziv;
                txtOpis.Text = slozenost.Opis;
            }
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNaziv.Text))
            {
                errorProvider.SetError(txtNaziv, Properties.Resources.Validation_RequiredField);
                //e.Cancel = true;
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
                // e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtOpis, null);
            }
        }
    }
}
