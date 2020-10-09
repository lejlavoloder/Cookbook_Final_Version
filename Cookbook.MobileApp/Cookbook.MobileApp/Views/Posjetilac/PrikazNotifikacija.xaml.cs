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
    public partial class PrikazNotifikacija : ContentPage
    {
        private NotifikacijaViewModel model = null;
        public PrikazNotifikacija()
        {
            InitializeComponent();
            BindingContext = model = new NotifikacijaViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Notifikacija;
            await model.Procitano(item);


            await Navigation.PushAsync(new PrikazNotifikacija());
        }

    }
}