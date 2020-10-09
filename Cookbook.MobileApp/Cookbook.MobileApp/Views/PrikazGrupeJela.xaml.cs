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
    public partial class PrikazGrupeJela : ContentPage
    {
        public APIService _service = new APIService("GrupaJela");
        public APIService _serviceRecept = new APIService("Recept");
        public APIService _serviceReceptSastojak = new APIService("ReceptSastojak");
        public APIService _serviceFavoriti = new APIService("Favoriti");
        public APIService _serviceKomentar = new APIService("Komentar");
        public APIService _serviceOcjena = new APIService("Ocjena");
        public APIService _serviceNotifikacija = new APIService("Notifikacija");

        GrupaJelaViewModel vm = null;
        public PrikazGrupeJela()
        {
            InitializeComponent();
            BindingContext = vm = new GrupaJelaViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await vm.PrikazGrupeJela();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var item = btn.BindingContext as GrupaJela;

            await Navigation.PushAsync(new UrediGrupuJela(item));

        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var item = btn.BindingContext as GrupaJela;
            var p = item.GrupaJelaId;
            ReceptSearchRequest searchrecept = new ReceptSearchRequest();
            searchrecept.GrupaJelaId = p;
            var listarecepata = await _serviceRecept.Get<IEnumerable<Recept>>(searchrecept);
            foreach (var y in listarecepata)
            {
                var receptid = y.ReceptId;
                ReceptSastojakSearchRequest receptsastojakrequest = new ReceptSastojakSearchRequest();
                receptsastojakrequest.ReceptId = receptid;
                var list1 = await _serviceReceptSastojak.Get<IEnumerable<ReceptSastojak>>(receptsastojakrequest);
                foreach (var a in list1)
                {
                    await _serviceReceptSastojak.Delete<ReceptSastojak>(a.ReceptSastojakId);
                }
                FavoritiSearchRequest favoritirequest = new FavoritiSearchRequest();
                favoritirequest.ReceptId = receptid;
                var list2 = await _serviceFavoriti.Get<IEnumerable<Favoriti>>(favoritirequest);
                foreach (var b in list2)
                {
                    await _serviceFavoriti.Delete<Favoriti>(b.FavoritiId);
                }
                NotifikacijaSearchRequest notifikacijarequest = new NotifikacijaSearchRequest();
                notifikacijarequest.ReceptId = receptid;
                var list3 = await _serviceNotifikacija.Get<IEnumerable<Notifikacija>>(notifikacijarequest);
                foreach (var c in list3)
                {
                    await _serviceNotifikacija.Delete<Notifikacija>(c.NotifikacijaId);
                }
                OcjenaSearchRequest ocjenarequest = new OcjenaSearchRequest();
                ocjenarequest.ReceptId = receptid;
                var list4 = await _serviceOcjena.Get<IEnumerable<Ocjena>>(ocjenarequest);
                foreach (var a in list4)
                {
                    await _serviceOcjena.Delete<IEnumerable<Ocjena>>(a.OcjenaId);
                }
                KomentarSearchRequest komentarrequest = new KomentarSearchRequest();
                komentarrequest.ReceptId = receptid;
                var list5 = await _serviceKomentar.Get<IEnumerable<Komentar>>(komentarrequest);
                foreach (var b in list5)
                {
                    await _serviceKomentar.Delete<Komentar>(b.KomentarId);
                }
                await _serviceRecept.Delete<Recept>(y.ReceptId);
            }
            await _service.Delete<GrupaJela>(p);
            await DisplayAlert("OK", "Uspješno ste izbrisali grupu jela", "OK");
            await Navigation.PushAsync(new PrikazGrupeJela());
        }
    }
}