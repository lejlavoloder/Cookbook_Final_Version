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
    public partial class UrediReceptSastojke : ContentPage
    {
        public APIService _apiReceptSastojak = new APIService("ReceptSastojak");
        public APIService _apiRecept = new APIService("Recept");
        public APIService Korisnik = new APIService("Korisnik");
        private ReceptSastojak receptsastojak = null;
        private Recept recept = null;
        public UrediReceptSastojkeViewModel model { get; set; }
        public UrediReceptSastojke(ReceptSastojak sastojak)
        {
            this.InitializeComponent();
            this.BindingContext = model = new UrediReceptSastojkeViewModel { receptsastojak = sastojak };
            receptsastojak = sastojak;
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
            this.sastojak.SelectedItem = model.SastojakList.FirstOrDefault(s => s.SastojakId == model.receptsastojak.SastojakId);
            await model.UcitajJedinicu();
            this.mjernajedinica.SelectedItem = model.MjernaJedinicaList.FirstOrDefault(s => s.MjernaJedinicaId == model.receptsastojak.MjernaJedinicaId);
            await model.UcitajKolicinu();
            this.mjernakolicina.SelectedItem = model.MjernaKolicinaList.FirstOrDefault(s => s.MjernaKolicinaId == model.receptsastojak.MjernaKolicinaId);
            recept = await _apiRecept.GetById<Recept>(receptsastojak.ReceptId);
           
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
         
            if (this.sastojak.SelectedItem == null)
            {
                await DisplayAlert("Greška", "Trebate odabrati sastojak", "OK");
            }

            else if (this.mjernajedinica.SelectedItem == null)
            {
                await DisplayAlert("Greška", "Trebate odabrati mjernu jedinicu", "OK");
            }

            else if (this.mjernakolicina.SelectedItem == null)
            {
                await DisplayAlert("Greška", "Trebate odabrati mjernu količinu", "OK");
            }
            else
            {
                try
                {
                    ReceptSastojakUpsertRequest req = new ReceptSastojakUpsertRequest();
                    MjernaJedinica mjernajedinica = this.mjernajedinica.SelectedItem as MjernaJedinica;
                    req.MjernaJedinicaId = mjernajedinica.MjernaJedinicaId;
                    MjernaKolicina mjernakolicina = this.mjernakolicina.SelectedItem as MjernaKolicina;
                    req.MjernaKolicinaId = mjernakolicina.MjernaKolicinaId;
                    Sastojak sastojak = this.sastojak.SelectedItem as Sastojak;
                    req.SastojakId = sastojak.SastojakId;
                    req.ReceptId = recept.ReceptId;
                    await _apiReceptSastojak.Update<dynamic>(model.receptsastojak.ReceptSastojakId, req);
                    await Application.Current.MainPage.DisplayAlert("Poruka", "Uspješno uneseni podaci", "OK");
                    await Navigation.PushAsync(new DetaljiReceptaPage(recept));
                }
                catch (Exception err)
                {
                    throw new Exception(err.Message);
                }
            }
        }
    }
}