using Cookbook.MobileApp.ViewModels;
using Cookbook.Model;
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
    public partial class DetaljiReceptaPage : ContentPage
    {
        ReceptDetaljiViewModel model =null;
        public APIService _apiRecept = new APIService("Recept");
        public APIService _apiReceptSastojak = new APIService("ReceptSastojak");
        Recept recept=null;
        public DetaljiReceptaPage(Recept r)
        {
            InitializeComponent();
            BindingContext = model = new ReceptDetaljiViewModel(r);
            recept = r;
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
           
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var item = btn.BindingContext as ReceptSastojak;

            await Navigation.PushAsync(new UrediReceptSastojke(item));
        }

        private async  void Button_Clicked_1(object sender, EventArgs e)
        { 
            var btn = sender as Button;
            var item = btn.BindingContext as ReceptSastojak;
            Recept r = await _apiRecept.GetById<Recept>(item.ReceptId);
            await _apiReceptSastojak.Delete<ReceptSastojak>(item.ReceptSastojakId);
            await DisplayAlert("OK", "Uspješno ste izbrisali sastojak", "OK");
            await Navigation.PushAsync(new DetaljiReceptaPage(r));
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DodajKomentar(recept));
        }
    }
}