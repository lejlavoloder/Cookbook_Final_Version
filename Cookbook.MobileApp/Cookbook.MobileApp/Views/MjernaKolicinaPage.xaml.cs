using Cookbook.MobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cookbook.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MjernaKolicinaPage : ContentPage
    {
        MjernaKolicinaViewModel model = null;
        public MjernaKolicinaPage()
        {
            InitializeComponent();
            BindingContext = model = new MjernaKolicinaViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DodajMjernuKolicinu());

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrikazMjerneKolicine());

        }
    }
}