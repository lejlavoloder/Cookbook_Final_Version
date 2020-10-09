using Cookbook.MobileApp.ViewModels;
using Cookbook.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cookbook.MobileApp.Views.Posjetilac
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DodajKomentar : ContentPage
    {
        private KomentarViewModel model = null;
        private Recept r = null;
        public DodajKomentar(Recept r)
        {
            InitializeComponent();
            BindingContext = model = new KomentarViewModel(r)
            {
                recept = r
            };
            r = r;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
         }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(this.Sadrzaj.Text, @"^[a-zA-Z ]+$") && this.Sadrzaj.Text.Length < 3)
            {
                await DisplayAlert("Greška", "Polje sadržaj se sastoji samo od slova i minimalno 4 karaktera", "OK");
            }
          else  {
                model.Sadrzaj = this.Sadrzaj.Text;
                await model.DodajKomentar();
                await Navigation.PushAsync(new PrikazRecepata());
            }
        }
    }
}