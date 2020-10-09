using Cookbook.MobileApp.ViewModels;
using Cookbook.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cookbook.MobileApp.Views.Posjetilac
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PretragaRecepata : ContentPage
    {
        ReceptViewModel model = null;
        public PretragaRecepata()
        {
            InitializeComponent();
            BindingContext = model = new ReceptViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.PretragaRecepata();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Recept;
            await Navigation.PushAsync(new DetaljiRecepta(item));
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var item = btn.BindingContext as Recept;
            await Navigation.PushAsync(new OcijeniReceptPage(item));
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var item = btn.BindingContext as Recept;
            FavoritiViewModel model = new FavoritiViewModel();
            model.r = item;
            await model.Init();
        }
    }
}