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
    public partial class frmFavoritiDetalji : Form
    {
        private readonly APIService _recepti = new APIService("Recept");
        private readonly APIService _favoriti = new APIService("Favoriti");
        private int? _id = null;
        public frmFavoritiDetalji(int? FavoritiId = null)
        {
            InitializeComponent();
            _id = FavoritiId;
        }

        private async void frmFavoritiDetalji_Load(object sender, EventArgs e)
        {
            await LoadRecepti();
            if (_id.HasValue)
            {
                var recept = await _favoriti.GetById<Model.Favoriti>(_id);
                cmbRecept.SelectedValue = int.Parse(recept.ReceptId.ToString());

            }
        }
        private async Task LoadRecepti()
        {
            var result = await _recepti.Get<List<Model.Recept>>(null);
            cmbRecept.DisplayMember = "Naziv";

            List<Model.Recept> recepti = new List<Model.Recept>();
            cmbRecept.ValueMember = "ReceptId";
            result.Insert(0, new Model.Recept
            {
                Naziv = "Odaberite"
            });
            cmbRecept.DataSource = result;
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            FavoritiUpsertRequest request = new FavoritiUpsertRequest();
            if (ValidateChildren())
            {
                var idObj = cmbRecept.SelectedValue;
                if (int.TryParse(idObj.ToString(), out int ReceptId))
                {
                    request.KorisnikId = 1;
                    request.ReceptId = ReceptId;
                }
                if (_id.HasValue)
                {
                    try
                    {
                        await _favoriti.Update<Model.Favoriti>(_id.Value, request);
                        MessageBox.Show("Uspješno sačuvani podaci");
                        this.Close();
                    }

                    catch (Exception)
                    {
                        DialogResult r = MessageBox.Show("Nemate pravo pristupa");
                        if (r == DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                }
                else
                {
                    try
                    {
                        await _favoriti.Insert<Model.Favoriti>(request);
                        MessageBox.Show("Uspješno sačuvani podaci");
                        this.Close();
                    }

                    catch (Exception)
                    {
                        DialogResult r = MessageBox.Show("Nemate pravo pristupa");
                        if (r == DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Operacija nije uspjela");
                this.Close();
            }
        }

        private void cmbRecept_Validating(object sender, CancelEventArgs e)
        {
            if (cmbRecept.SelectedValue == null || (int)cmbRecept.SelectedValue == 0)
            {
                errorProvider.SetError(cmbRecept, Properties.Resources.Validation_RequiredField);
                //e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbRecept, null);
            }
        }
    }
}
