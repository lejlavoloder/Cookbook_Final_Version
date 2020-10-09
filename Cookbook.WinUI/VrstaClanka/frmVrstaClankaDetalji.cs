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

namespace Cookbook.WinUI.VrstaClanka
{
    public partial class frmVrstaClankaDetalji : Form
    {
        private readonly APIService _apiService = new APIService("VrstaClanka");
        private int? _id = null;
        public frmVrstaClankaDetalji(int? VrstaClankaId = null)
        {
            InitializeComponent();
            _id = VrstaClankaId;
        }
       
        private async void frmVrstaClankaDetalji_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var VrstaClanka = await _apiService.GetById<Model.VrstaClanka>(_id);
                txtNaziv.Text = VrstaClanka.Naziv;
            }
        }
    VrstaClankaInsertRequest request = new VrstaClankaInsertRequest();
       

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
                //e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtNaziv, null);
            }
        }

        private async void btnSacuvaj_Click_1(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                request.Naziv = txtNaziv.Text;

                if (_id.HasValue)
                {
                    await _apiService.Update<Model.VrstaClanka>(_id.Value, request);
                }
                else
                {
                    await _apiService.Insert<Model.VrstaClanka>(request);
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
    
    }
}
