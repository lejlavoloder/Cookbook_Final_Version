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



namespace Cookbook.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DodajClanak : ContentPage
    {
        
        ClanakViewModel model = null;
        public DodajClanak()
        {
            InitializeComponent();
            BindingContext = model = new ClanakViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();                
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(this.Naziv.Text, @"^[a-zA-Z ]+$") && this.Naziv.Text.Length < 4)
            {
               await DisplayAlert("Greška", "Polje naziv se sastoji samo od slova i minimalno 4 karaktera", "OK");
            }
            else if (!Regex.IsMatch(this.Tekst.Text, @"^[a-zA-Z ]+$") && this.Tekst.Text.Length < 10)
            {
                await DisplayAlert("Greška", "Polje tekst se sastoji samo od slova i minimalno 10 karaktera ", "OK");
            }
           else if (this.VrstaClankaPicker.SelectedItem == null)
            {
                await DisplayAlert("Greška", "Morate odabrati vrstu članka", "OK");
            }
            else
            {
                try
                {
                   model.Naziv = this.Naziv.Text;
                   VrstaClanka c = this.VrstaClankaPicker.SelectedItem as VrstaClanka;
                   model.VrstaClankaId = c.VrstaClankaId;
                   model.Tekst = this.Tekst.Text;
                   model.DatumVrijemeObjave = DateTime.Now;
                    await model.DodajClanak();
                    await Application.Current.MainPage.DisplayAlert("Poruka", "Uspješno ste pohranili članak", "OK");
                    await Navigation.PushAsync(new PrikazClankaPage()); 
                }
                catch (Exception err)
                {
                    throw new Exception(err.Message);
                }
            }
        }
    }
}