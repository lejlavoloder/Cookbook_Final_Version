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
    public partial class SastojakPage : ContentPage
    {
        SastojakViewModel model = null;
        public SastojakPage()
        {
            InitializeComponent();
            BindingContext = model = new SastojakViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            //  await vm.Init();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DodajSastojak());

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrikazSastojaka());

        }
    }
}