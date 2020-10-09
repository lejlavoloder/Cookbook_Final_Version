using Cookbook.MobileApp.ViewModels;
using Cookbook.Model;
using Cookbook.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cookbook.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UrediMjernuKolicinu : ContentPage
    {
        public APIService _service = new APIService("MjernaKolicina");
        private MjernaKolicina mjernakolicina = null;
        public UrediMjernuKolicinuViewModel model { get; set; }
        public UrediMjernuKolicinu(MjernaKolicina m)
        {
            InitializeComponent();
            BindingContext = model = new UrediMjernuKolicinuViewModel() { MjernaKolicina = m };
            mjernakolicina = m;

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(this.Kolicina.Text, @"^[0-9]+$"))
            {
                await DisplayAlert("Greška", "Polje količina se sastoji samo od brojeva!", "OK");
            }
            else
            {
                try
                {
                    MjernaKolicinaUpsertRequest req = new MjernaKolicinaUpsertRequest
                    {
                        Kolicina = Convert.ToDouble(this.Kolicina.Text)
                    };
                
                    await _service.Update<dynamic>(model.MjernaKolicina.MjernaKolicinaId, req);
                    await DisplayAlert("OK", "Uspješno uneseni podaci", "OK");
                    await  Navigation.PushAsync(new PrikazMjerneKolicine());

                }
                catch (Exception err)
                {
                    throw new Exception(err.Message);
                }
            }
        }
    }
}