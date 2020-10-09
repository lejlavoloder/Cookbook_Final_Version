using Cookbook.MobileApp.ViewModels;
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
    public partial class DodajSlozenost : ContentPage
    {
        SlozenostViewModel vm = null;
        public APIService _service = new APIService("Slozenost");
        public DodajSlozenost()
        {
            InitializeComponent();
            BindingContext = vm = new SlozenostViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(this.Naziv.Text, @"^[a-zA-Z ]+$") && this.Naziv.Text.Length < 4)
            {
                await DisplayAlert("Greška", "Naziv se sastoji samo od slova i mora da sadrži minimalno 4 karaktera", "OK");
            }
            else if (!Regex.IsMatch(this.Opis.Text, @"^[a-zA-Z ]+$") && this.Opis.Text.Length < 4)
            {
                await DisplayAlert("Greška", "Opis se sastoji samo od slova i mora da sadrži minimalno 4 karaktera", "OK");
            }
            else
            {
                try
                {
                    vm.Naziv = this.Naziv.Text;
                    vm.Opis = this.Opis.Text;
                    await vm.DodajSlozenost();
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