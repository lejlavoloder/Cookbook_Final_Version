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

namespace Cookbook.MobileApp.Views.Posjetilac
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MojiRecepti : ContentPage
    {
        public APIService _apiRecept = new APIService("Recept");
        public APIService _apiReceptSastojak = new APIService("ReceptSastojak");
        public APIService _apiKomentar = new APIService("Komentar");
        public APIService _apiOcjena = new APIService("Ocjena");
        public APIService _apiFavoriti = new APIService("Favoriti");
        MojiReceptiViewModel model = null;
        public MojiRecepti()
        {
            InitializeComponent();
            BindingContext = model = new MojiReceptiViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var item = btn.BindingContext as Recept;
            Navigation.PushAsync(new UrediRecept(item));
        }

        private async void Button_Clicked_4(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var item = btn.BindingContext as Recept;

            var p = item.ReceptId;

            KomentarSearchRequest komentar = new KomentarSearchRequest();
            OcjenaSearchRequest ocjena = new OcjenaSearchRequest();
            ReceptSastojakSearchRequest sastojak = new ReceptSastojakSearchRequest();
            FavoritiSearchRequest favoriti = new FavoritiSearchRequest();
            komentar.ReceptId = p;
            ocjena.ReceptId = p;
            sastojak.ReceptId = p;
            favoriti.ReceptId = p;

            var listakomentara = await _apiKomentar.Get<IEnumerable<Komentar>>(komentar);
            var listaocjena = await _apiOcjena.Get<IEnumerable<Ocjena>>(ocjena);
            var listareceptsastojaka = await _apiReceptSastojak.Get<IEnumerable<ReceptSastojak>>(sastojak);
            var listafavorita = await _apiFavoriti.Get<IEnumerable<Favoriti>>(favoriti);
            foreach (var y in listakomentara)
            {
                await _apiKomentar.Delete<Komentar>(y.KomentarId);
            }
            foreach (var y in listaocjena)
            {
                await _apiOcjena.Delete<Ocjena>(y.OcjenaId);
            }
            foreach (var y in listareceptsastojaka)
            {
                await _apiReceptSastojak.Delete<ReceptSastojak>(y.ReceptSastojakId);
            }
            foreach (var y in listafavorita)
            {
                await _apiFavoriti.Delete<Favoriti>(y.FavoritiId);
            }
            await _apiRecept.Delete<Recept>(item.ReceptId);
            await DisplayAlert("OK", "Uspješno ste izbrisali recept", "OK");
            await Navigation.PushAsync(new MojiRecepti());
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Recept;
            await Navigation.PushAsync(new MojReceptDetalj(item));
        }
    }
}