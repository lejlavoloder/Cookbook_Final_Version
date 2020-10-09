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
    public partial class MjernaJedinicaPage : ContentPage
    {
        MjernaJedinicaViewModel vm = null;
        public MjernaJedinicaPage()
        {
            InitializeComponent();
            BindingContext = vm = new MjernaJedinicaViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DodajMjernuJedinicu());

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrikazMjerneJedinice());

        }
    }
}