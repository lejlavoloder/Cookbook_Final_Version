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
    public partial class UrediMjernuJedinicu : ContentPage
    {

        public APIService _service = new APIService("MjernaJedinica");
        private MjernaJedinica m = null;
        public UrediMjernuJedinicuViewModel model { get; set; }
        public UrediMjernuJedinicu(MjernaJedinica mjernajedinica)
        {
            InitializeComponent();
            BindingContext = model = new UrediMjernuJedinicuViewModel() { MjernaJedinica = mjernajedinica };
            m = mjernajedinica;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(this.Naziv.Text, @"^[a-zA-Z ]+$") && this.Naziv.Text.Length<3)
            {
                await DisplayAlert("Greška", "Naziv se sastoji samo od slova i minimalno 3 karaktera", "OK");
            }
            else
            {
                try
                {
                    MjernaJedinicaInsertRequest req = new MjernaJedinicaInsertRequest()
                    {

                        Naziv = this.Naziv.Text,
                    };

                    await _service.Update<dynamic>(model.MjernaJedinica.MjernaJedinicaId, req);
                    await DisplayAlert("OK", "Uspješno uneseni podaci", "OK");
                    await Navigation.PushAsync(new PrikazMjerneJedinice());
                }
                catch (Exception err)
                {
                    throw new Exception(err.Message);
                }
            }
        }
    }
}