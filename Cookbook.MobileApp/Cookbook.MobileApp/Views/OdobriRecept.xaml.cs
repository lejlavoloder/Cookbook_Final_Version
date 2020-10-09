using Cookbook.MobileApp.ViewModels;
using Cookbook.Model;
using Cookbook.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cookbook.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OdobriRecept : ContentPage
    {
        public APIService _apiRecept = new APIService("Recept");
        public APIService _apiNotifikacija = new APIService("Notifikacija");
        OdobriReceptViewModel model = null;
        public OdobriRecept()
        {
            InitializeComponent();
            BindingContext = model = new OdobriReceptViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.PrikazRecepata();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var item = btn.BindingContext as Recept;

            if (item.Odobren == false)
            {
                item.Odobren = true;

                await _apiRecept.Update<Recept>(item.ReceptId, item);
                await _apiNotifikacija.Insert<Notifikacija>(new NotifikacijaUpsertRequest
                {
                    DatumSlanja = DateTime.Now,
                    IsProcitano = false,
                    Sadrzaj = "Poštovani  " + item.Korisnik + " vaš recept je uspješno objavljen.",
                    ReceptId=item.ReceptId
                }); 

                await Application.Current.MainPage.DisplayAlert(" ", "Uspjesno ste odobrili recept korisnika: " + " " + item.Korisnik+
                    " za recept: " + item.Naziv, "OK");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert(" ", "Recept je vec odobren", "OK");
            }

            await model.PrikazRecepata();
        }
    }
}