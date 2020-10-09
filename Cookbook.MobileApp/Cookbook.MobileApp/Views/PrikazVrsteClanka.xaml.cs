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
    public partial class PrikazVrsteClanka : ContentPage
    {
        public APIService _service = new APIService("VrstaClanka");
        public APIService _apiClanak = new APIService("Clanak");


        VrstaClankaViewModel vm = null;
        public PrikazVrsteClanka()
        {
            InitializeComponent();
            BindingContext = vm = new VrstaClankaViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await vm.PrikazVrsteClanka();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var item = btn.BindingContext as VrstaClanka;

            await Navigation.PushAsync(new UrediVrstuClanka(item));

        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var item = btn.BindingContext as VrstaClanka;
            var p = item.VrstaClankaId;

            ClanakSearchRequest request = new ClanakSearchRequest();
            request.VrstaClankaId = p;
            var listaclanaka = await _apiClanak.Get<IEnumerable<Clanak>>(request);
            foreach (var y in listaclanaka)
            {
                await _apiClanak.Delete<Clanak>(y.ClanakId);
            }
            await _service.Delete<VrstaClanka>(item.VrstaClankaId);
            await DisplayAlert("OK", "Uspješno ste izbrisali vrstu članka", "OK");
            await Navigation.PushAsync(new PrikazVrsteClanka());
        }
    }
}