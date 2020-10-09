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
    public partial class UrediClanak : ContentPage
    {
        public APIService Clanak = new APIService("Clanak");
        public APIService Korisnik = new APIService("Korisnik");
        private Clanak c=null;
        public UrediClanakViewModel model { get; set; }
        public UrediClanak(Clanak Clanak)
        {
            this.InitializeComponent();
            this.BindingContext = model = new UrediClanakViewModel { clanak = Clanak };
            c = Clanak;
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
            this.VrstaClanka.SelectedItem = model.VrstaClankaList.FirstOrDefault(s => s.VrstaClankaId == model.clanak.VrstaClankaId);
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(this.Naziv.Text, @"^[a-zA-Z ]+$") && this.Naziv.Text.Length < 4)
            {
                await DisplayAlert("Greška", "Naziv se sastoji samo od slova", "OK" );
            }
            else if (!Regex.IsMatch(this.Tekst.Text, @"^[a-zA-Z ]+$") && this.Tekst.Text.Length < 10)
            {
                await DisplayAlert("Greška", "Tekst se sastoji samo od slova", "OK");
            }
            else if (this.VrstaClanka.SelectedItem == null)
            {
                await DisplayAlert("Greška", "Trebate odabrati članak", "OK");
            }
            else
            {
                try
                {
                    Korisnik korisnik = new Korisnik();
                    var username = APIService.Username;
                    List<Korisnik> lista = await Korisnik.Get<List<Korisnik>>(null);
                    foreach (var k in lista)
                    {
                        if (k.KorisnickoIme == username)
                        {
                            korisnik = k;
                            break;
                        }
                    }

                    ClanakInsertRequest req = new ClanakInsertRequest();
                    req.Naziv = this.Naziv.Text;
                    req.Tekst = this.Tekst.Text;
                    req.DatumObjave = this.DatumObjave.Date;
                    req.KorisnikId = korisnik.KorisnikId;
                    VrstaClanka c = this.VrstaClanka.SelectedItem as VrstaClanka;
                    req.VrstaClankaId = c.VrstaClankaId;

                    await Clanak.Update<dynamic>(model.clanak.ClanakId, req);
                    await Application.Current.MainPage.DisplayAlert("Poruka", "Uspješno uneseni podaci", "OK");
                    await Navigation.PushAsync(new PrikazClankaPage());
                }
                catch (Exception err)
                {
                    throw new Exception(err.Message);
                }
            }
        }
    }
}