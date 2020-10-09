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
    public partial class UrediVrstuClanka : ContentPage
    {

        public APIService _service = new APIService("VrstaClanka");
        private VrstaClanka _vrsta = null;
        public UrediVrstuClankaViewModel model { get; set; }
        public UrediVrstuClanka(VrstaClanka v)
        {
            InitializeComponent();
            BindingContext = model = new UrediVrstuClankaViewModel() { VrstaClanka = v };
            _vrsta = v;
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
           
            else
            {
                try
                {
                    VrstaClankaInsertRequest req = new VrstaClankaInsertRequest()
                    {
                        Naziv = this.Naziv.Text,
                    };

                    await _service.Update<dynamic>(model.VrstaClanka.VrstaClankaId, req);
                    await DisplayAlert("OK", "Uspješno uneseni podaci", "OK");
                    await Navigation.PushAsync(new PrikazVrsteClanka());
                }
                catch (Exception err)
                {
                    throw new Exception(err.Message);
                }
            }
        }
    }
}