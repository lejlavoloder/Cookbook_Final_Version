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
    public partial class PrikazSastojaka : ContentPage
    {
        public APIService _service = new APIService("Sastojak");
        public APIService _serviceReceptSastojak = new APIService("ReceptSastojak");

        SastojakViewModel vm = null;
        public PrikazSastojaka()
        {
            InitializeComponent();
            BindingContext = vm = new SastojakViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await vm.PrikazSastojaka();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var item = btn.BindingContext as Sastojak;

            await Navigation.PushAsync(new UrediSastojakPage(item));

        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var item = btn.BindingContext as Sastojak;
            var p = item.SastojakId;
            ReceptSastojakSearchRequest request = new ReceptSastojakSearchRequest();
            request.SastojakId = p;
            var listasastojaka = await _serviceReceptSastojak.Get<IEnumerable<ReceptSastojak>>(request);
            foreach (var i in listasastojaka)
            {
                await _serviceReceptSastojak.Delete<ReceptSastojak>(i.ReceptSastojakId);
            }
            await _service.Delete<Sastojak>(p);
            await DisplayAlert("OK", "Uspješno ste izbrisali sastojak", "OK");
            await Navigation.PushAsync(new PrikazSastojaka());
        }
    }
}