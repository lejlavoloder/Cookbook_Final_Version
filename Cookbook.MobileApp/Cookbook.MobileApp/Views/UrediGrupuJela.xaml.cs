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
    public partial class UrediGrupuJela : ContentPage
    {
        public APIService _service = new APIService("GrupaJela");
        private GrupaJela g= null;
        public UrediGrupuJelaViewModel model { get; set; }
        public UrediGrupuJela(GrupaJela grupa)
        {
            InitializeComponent();
            BindingContext = model = new UrediGrupuJelaViewModel { GrupaJela = grupa };
            g = grupa;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(this.Naziv.Text, @"^[a-zA-Z ]+$") && this.Naziv.Text.Length<4)
            {
                await DisplayAlert("Greška", "Naziv se sastoji samo od slova i minimalno 4 karaktera", "OK");
            }
            if (!Regex.IsMatch(this.Opis.Text, @"^[a-zA-Z ]+$") && this.Opis.Text.Length<5)
            {
                await DisplayAlert("Greška", "Opis se sastoji samo od slova i minimalno 4 karaktera", "OK");
            }
            else
            {
                try
                {
                    GrupaJelaUpsertRequest req = new GrupaJelaUpsertRequest()
                    {

                        Naziv = this.Naziv.Text,
                        Opis=this.Opis.Text
                    };

                    await _service.Update<dynamic>(model.GrupaJela.GrupaJelaId, req);
                    await DisplayAlert("OK", "Uspješno uneseni podaci", "OK");
                    await Navigation.PushAsync(new PrikazGrupeJela());
                }
                catch (Exception err)
                {
                    throw new Exception(err.Message);
                }
            }
        }
    }
}