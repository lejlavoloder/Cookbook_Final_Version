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
using Cookbook.WinUI.Properties;
namespace Cookbook.WinUI.Sastojak
{
    public partial class frmSastojakDetalji : Form
    {
        private readonly APIService _apiService = new APIService("Sastojak");
        private int? _id = null;
        public frmSastojakDetalji(int? SastojakId=null)
        {
            InitializeComponent();
            _id = SastojakId;
        }
     
        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var request = new SastojakInsertRequest()
                {
                    Naziv = txtNaziv.Text
                };
                if (_id.HasValue)
                {
                   await _apiService.Update<Model.Sastojak>(_id.Value, request);
                }
                else
                {
                   await _apiService.Insert<Model.Sastojak>(request);
                }
                MessageBox.Show("Uspješno sačuvani podaci");
                this.Close();
            }
     
        }

        private  async void frmSastojakDetalji_Load(object sender, EventArgs e)
        {
           
                if (_id.HasValue)
                {
                    var sastojak = await _apiService.GetById<Model.Sastojak>(_id);
                    txtNaziv.Text = sastojak.Naziv;
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
                //e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtNaziv, null);
            }
        }  
    }
}
