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

namespace Cookbook.WinUI
{
    public partial class Login : Form
    {
        private readonly APIService _service = new APIService("Korisnik");
        APIService _servicelogin = new APIService("Posjetilac");
        public Login()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            APIService.Username = txtKorisnickoIme.Text;
            APIService.Password = txtLozinka.Text;
            string username = txtKorisnickoIme.Text;
            try
            {
                await _service.Get<dynamic>(null);
                List<Model.Posjetilac> lista = await _servicelogin.Get<List<Model.Posjetilac>>
                    (new PosjetilacSearchRequest { KorisnickoIme = username });
                if (lista.Count > 0)
                {
                    Application.Restart();
                }
                else
                {
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Authentikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}

