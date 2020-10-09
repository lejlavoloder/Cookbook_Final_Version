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
    public partial class PrikazMjerneKolicine : ContentPage
    {
        public APIService _apiService = new APIService("MjernaKolicina");
        MjernaKolicinaViewModel vm = null;
        public PrikazMjerneKolicine()
        {
            InitializeComponent();
            BindingContext = vm = new MjernaKolicinaViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await vm.PrikazMjerneKolicine();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var item = btn.BindingContext as MjernaKolicina;

          await Navigation.PushAsync(new UrediMjernuKolicinu(item));
        }
    }
}