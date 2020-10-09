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
    public partial class UrediKategorijuPage : ContentPage
    {
        public APIService _service = new APIService("Kategorija");
        private Kategorija k = null;
        public UrediKategorijuViewModel model { get; set; }
        public UrediKategorijuPage(Kategorija kategorija)
        {
            InitializeComponent();
            BindingContext = model = new UrediKategorijuViewModel() {Kategorija=kategorija};
            k = kategorija;
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
            else
            {
                try
                {
                    KategorijaInsertRequest req = new KategorijaInsertRequest()
                    {

                        Naziv = this.Naziv.Text,
                    };

                    await _service.Update<dynamic>(model.Kategorija.KategorijaId, req);
                    await DisplayAlert("OK", "Uspješno uneseni podaci", "OK");
                    await Navigation.PushAsync(new PrikazKategorije());
                }
                catch (Exception err)
                {
                    throw new Exception(err.Message);
                }
            }
        }
    }
}