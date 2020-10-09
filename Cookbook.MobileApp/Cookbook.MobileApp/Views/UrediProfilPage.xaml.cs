using Cookbook.MobileApp.ViewModels;
using Cookbook.Model;
using Cookbook.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cookbook.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UrediProfilPage : ContentPage
    {
        public APIService _korisnik = new APIService("Korisnik");
        public KorisnickiProfilViewModel korisnickiprofil { get; set; }
        public UrediProfilPage(Korisnik k)
        {
            InitializeComponent();
            BindingContext = korisnickiprofil = new KorisnickiProfilViewModel { korisnik = k };
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(this.Ime.Text, @"^[a-zA-Z]+$") && this.Ime.Text.Length < 3)
            {
                await DisplayAlert("Greška", "Ime se sastoji samo od slova i minimalno 3 karaktera", "OK");
            }
            else if (!Regex.IsMatch(this.Prezime.Text, @"^[a-zA-Z]+$") && this.Prezime.Text.Length < 3)
            {
                await DisplayAlert("Greška", "Prezime se sastoji samo od slova i minimalno 3 karaktera", "OK");
            }
            else if (!Regex.IsMatch(this.Telefon.Text, @"^[+]{1}\d{3}[ ]?\d{2}[ ]?\d{3}[ ]?\d{3}"))
            {
                await DisplayAlert("Greška", "Format telefona je: +123 45 678 910", "OK");
            }
            else if (!Regex.IsMatch(this.Email.Text, @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?"))
            {
                await DisplayAlert("Greška", "Neispravan format email-a!", "OK");
            }
            else if (!Regex.IsMatch(this.KorisnickoIme.Text, @"^(?=.{4,40}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$"))
            {
                await DisplayAlert("Greška", "Neispravan format ili dužina korisničkog imena (4-40)", "OK");
            }
            else if (string.IsNullOrWhiteSpace(this.Password.Text))
            {
                await DisplayAlert("Greška", "Morate unijeti novu ili staru lozinku", "OK");
            }
            else if (this.Password.Text != this.PasswordPotvrda.Text)
            {
                await DisplayAlert("Greška", "Lozinke moraju biti iste", "OK");

            }
            else if (this.Password.Text.Length < 4)
            {
                await DisplayAlert("Greška", "Lozinka ne smije biti kraća od 4 karaktera", "OK");
            }
            else
            {
                try
                {
                    KorisnikInsertRequest req = new KorisnikInsertRequest()
                    {
                        Ime = this.Ime.Text,
                        Prezime = this.Prezime.Text,
                        KorisnickoIme = this.KorisnickoIme.Text,
                        Password = this.Password.Text,
                        PasswordPotvrda = this.PasswordPotvrda.Text,
                        Telefon = this.Telefon.Text,
                        Email = this.Email.Text,
                    };
                    var lozinka = APIService.Password;
                    var korisnicko = APIService.Username;
                    await _korisnik.Update<Korisnik>(korisnickiprofil.korisnik.KorisnikId, req);
                    await DisplayAlert("OK", "Uspješno uneseni podaci", "OK");
                    if (lozinka != this.Password.Text || korisnicko != this.KorisnickoIme.Text)
                    {
                        App.Current.MainPage = new LoginPage();
                    }
                }
                catch (Exception err)
                {
                    throw new Exception(err.Message);
                }
            }
        }

    }
}
