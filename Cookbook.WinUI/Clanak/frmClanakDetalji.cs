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

namespace Cookbook.WinUI.Clanak
{
    public partial class frmClanakDetalji : Form
    {
        private readonly APIService _clanak = new APIService("Clanak");
        private readonly APIService _vrstaclanka = new APIService("VrstaClanka");
        private int? _id = null;
        public frmClanakDetalji(int? ClanakId = null)
        {
            InitializeComponent();
            _id = ClanakId;
        }

        private async void frmClanakDetalji_Load(object sender, EventArgs e)
        {
            await LoadClanci();
            if (_id.HasValue)
            {
                var clanak = await _clanak.GetById<Model.Clanak>(_id);
                txtNaziv.Text = clanak.Naziv;
                richTextBtxtTekstox1.Text = clanak.Tekst;
                dtObjave.Value = clanak.DatumObjave;
                cmbVrstaClanka.SelectedValue = int.Parse(clanak.VrstaClankaId.ToString());
            }
        }
        private async Task LoadClanci()
        {
            var result = await _vrstaclanka.Get<List<Model.VrstaClanka>>(null);
            cmbVrstaClanka.DisplayMember = "Naziv";
            cmbVrstaClanka.ValueMember = "VrstaClankaId";
            //cmbVrstaClanka.SelectedItem = null;
            result.Insert(0, new Model.VrstaClanka());
            //cmbVrstaClanka.SelectedText = "--Odaberite--";
            cmbVrstaClanka.DataSource = result;
        }

        ClanakInsertRequest request = new ClanakInsertRequest();
        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {

            if (txtNaziv.Text == "" || richTextBtxtTekstox1.Text == "" || VrstaClankaId == null || dtObjave.Text == "")
                MessageBox.Show("Morate popuniti sva polja!");

            else
            {
                if (this.ValidateChildren())
                {
                    var idObj = cmbVrstaClanka.SelectedValue;
                    if (int.TryParse(idObj.ToString(), out int VrstaClankaId))
                    {
                        request.VrstaClankaId = VrstaClankaId;
                        request.Naziv = txtNaziv.Text;
                        request.Tekst = richTextBtxtTekstox1.Text;
                        request.DatumObjave = dtObjave.Value;
                        request.KorisnikId = 1;
                    }
                    if (_id.HasValue)
                    {
                        try
                        {
                            await _clanak.Update<Model.Clanak>(_id.Value, request);
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
                            await _clanak.Insert<Model.Clanak>(request);
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
        }

        private async void cmbVrstaClanka_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbVrstaClanka.SelectedValue;
            if (int.TryParse(idObj.ToString(), out int id))
            {
                await LoadClanci(id);
            }
        }
        private async Task LoadClanci(int VrstaClankaId)
        {
            var result = await _clanak.Get<List<Model.Clanak>>(new ClanakSearchRequest()
            {
               VrstaClankaId=VrstaClankaId
            });
            dgvClanci.DataSource = result;
 
        }

        private void dgvClanci_MouseDoubleClick(object sender, MouseEventArgs e)
        {
                var id = dgvClanci.SelectedRows[0].Cells[0].Value;

                frmClanakDetalji frm = new frmClanakDetalji(int.Parse(id.ToString()));
                frm.Show();

            }

        private void cmbVrstaClanka_Validating(object sender, CancelEventArgs e)      
        { 
            if (cmbVrstaClanka.SelectedValue == null || (int)cmbVrstaClanka.SelectedValue==0)
            {
                errorProvider.SetError(cmbVrstaClanka, Properties.Resources.Validation_RequiredField);
              //  e.Cancel = true;
            }
         else   {
                errorProvider.SetError(cmbVrstaClanka, null);
            }
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {

            if (String.IsNullOrEmpty(txtNaziv.Text))
            {   // e.Cancel = true;
                errorProvider.SetError(txtNaziv, Properties.Resources.Validation_RequiredField );
               
            }
            else if (!Regex.IsMatch(txtNaziv.Text, @"^[a-zA-Z ]+$"))
            { //e.Cancel = true;
                errorProvider.SetError(txtNaziv, Properties.Resources.NeispravanFormat);
               
            }
            else
            {
                errorProvider.SetError(txtNaziv, null);
            }
        }

        private void richTextBtxtTekstox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBtxtTekstox1.Text))
            {
                errorProvider.SetError(richTextBtxtTekstox1, Properties.Resources.Validation_RequiredField);
                //e.Cancel = true;
            }
            else if (!Regex.IsMatch(richTextBtxtTekstox1.Text, @"^[a-zA-Z ]+$"))
            {
                errorProvider.SetError(richTextBtxtTekstox1, Properties.Resources.NeispravanFormat);
                //e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(richTextBtxtTekstox1, null);
            }
        }
    }
    }
    
   
