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

namespace Cookbook.WinUI.MjernaKolicina
{
    public partial class frmMjernaKolicinaDetalji : Form
    {
        private readonly APIService _apiService = new APIService("MjernaKolicina");
        private int? _id = null;
        public frmMjernaKolicinaDetalji(int?MjernaKolicinaId=null)
        {
            InitializeComponent();
            _id = MjernaKolicinaId;
        }

        private async void frmMjernaKolicinaDetalji_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var mjernakolicina = await _apiService.GetById<Model.MjernaKolicina>(_id);
             
                txtKolicina.Text = mjernakolicina.Kolicina.ToString();
            }
        }
        MjernaKolicinaUpsertRequest request = new MjernaKolicinaUpsertRequest();
        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                double.TryParse(txtKolicina.Text, out var n);
                try
                {
                    request.Kolicina = n;
                }
                catch
                {
                    DialogResult r = MessageBox.Show("Nemate pravo pristupa");
                    if (r == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                if (_id.HasValue)
                {
                    await _apiService.Update<Model.MjernaKolicina>(_id.Value, request);
                }
                else
                {
                    await _apiService.Insert<Model.MjernaKolicina>(request);
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

        private void txtKolicina_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtKolicina.Text))
            {
                errorProvider.SetError(txtKolicina, Properties.Resources.Validation_RequiredField);
                //e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtKolicina.Text, @"^[0-9]+$"))
            {
                errorProvider.SetError(txtKolicina, Properties.Resources.NeispravanFormat);
                //e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtKolicina, null);
            }
        }
    }
}
