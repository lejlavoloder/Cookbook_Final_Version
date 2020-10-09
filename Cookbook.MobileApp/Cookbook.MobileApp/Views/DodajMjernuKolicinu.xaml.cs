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
    public partial class DodajMjernuKolicinu : ContentPage
    {
        MjernaKolicinaViewModel vm = null;
        public DodajMjernuKolicinu()
        {
            InitializeComponent();
            BindingContext = vm = new MjernaKolicinaViewModel();
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
                    vm.Kolicina = Convert.ToInt32(this.Kolicina.Text);
                    await vm.DodajMjernuKolicinu();
                    await Navigation.PushAsync(new PrikazMjerneKolicine());
                }
                catch (Exception err)
                {
                    throw new Exception(err.Message);
                }
            }
        }
    }
}