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
    public partial class PrikazMjerneJedinice : ContentPage

    {
        public APIService _service = new APIService("MjernaJedinica");

        MjernaJedinicaViewModel vm = null;
        public PrikazMjerneJedinice()
        {
            InitializeComponent();
            BindingContext = vm = new MjernaJedinicaViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await vm.PrikazMjerneJedinice();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var item = btn.BindingContext as MjernaJedinica;

            await Navigation.PushAsync(new UrediMjernuJedinicu(item));

        }
    }
}