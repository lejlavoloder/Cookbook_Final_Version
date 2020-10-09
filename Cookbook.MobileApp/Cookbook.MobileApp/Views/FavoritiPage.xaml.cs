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
    public partial class FavoritiPage : ContentPage
    {
        FavoritiPrikazViewModel vm = null;
        public APIService _apiFavoriti = new APIService("Favoriti");
        public APIService _apiRecept = new APIService("Recept");
        public FavoritiPage()
        {
            InitializeComponent();
            BindingContext = vm = new FavoritiPrikazViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await vm.PrikazFavorita();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var item = btn.BindingContext as Favoriti;
            await _apiFavoriti.Delete<Favoriti>(item.FavoritiId);
            await DisplayAlert("OK", "Uspješno ste izbrisali svog favorita", "OK");
            await Navigation.PushAsync(new FavoritiPage());
        }
        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var item = btn.BindingContext as Favoriti;
            Recept r = await _apiRecept.GetById<Recept>(item.ReceptId);
            await Navigation.PushAsync(new ReceptFavoritiDetalji(item,r));
        }
    }
}