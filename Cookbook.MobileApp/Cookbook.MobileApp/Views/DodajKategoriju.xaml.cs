using  Cookbook.Model.Requests;
using Cookbook.MobileApp.ViewModels;
using Cookbook.MobileApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Text.RegularExpressions;

namespace Cookbook.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DodajKategoriju : ContentPage
    {
        KategorijaViewModel vm = null;
        public APIService _service = new APIService("Kategorija");
        public DodajKategoriju()
        {
            InitializeComponent();
            BindingContext = vm = new KategorijaViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(this.Naziv.Text, @"^[a-zA-Z ]+$") && this.Naziv.Text.Length<4)
            {
                await DisplayAlert("Greška", "Naziv se sastoji samo od slova i mora da sadrži minimalno 4 karaktera", "OK");
            }
            else
            {
                try
                {
                    vm.Naziv = this.Naziv.Text;
                    await vm.DodajKategoriju();
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