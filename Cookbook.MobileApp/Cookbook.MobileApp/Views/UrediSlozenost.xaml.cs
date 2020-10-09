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
    public partial class UrediSlozenost : ContentPage
    {
        public APIService _service = new APIService("Slozenost");
        private Slozenost s= null;
        public UrediSlozenostViewModel model { get; set; }
        public UrediSlozenost(Slozenost ss)
        {
            InitializeComponent();
            BindingContext = model = new UrediSlozenostViewModel { Slozenost = ss };
            s = ss;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(this.Naziv.Text, @"^[a-zA-Z ]+$") && this.Naziv.Text.Length < 4)
            {
                await DisplayAlert("Greška", "Naziv se sastoji samo od slova i minimalno 4 karaktera", "OK");
            }
            if (!Regex.IsMatch(this.Opis.Text, @"^[a-zA-Z ]+$") && this.Opis.Text.Length < 5)
            {
                await DisplayAlert("Greška", "Opis se sastoji samo od slova i minimalno 4 karaktera", "OK");
            }
            else
            {
                try
                {
                    SlozenostUpsertRequest req = new SlozenostUpsertRequest()
                    {

                        Naziv = this.Naziv.Text,
                        Opis = this.Opis.Text
                    };

                    await _service.Update<dynamic>(model.Slozenost.SlozenostId, req);
                    await DisplayAlert("OK", "Uspješno uneseni podaci", "OK");
                    await Navigation.PushAsync(new PrikazSlozenosti());
                }
                catch (Exception err)
                {
                    throw new Exception(err.Message);
                }
            }
        }
    }
}