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
    public partial class SlozenostPage : ContentPage
    {
        SlozenostViewModel vm = null;
        public SlozenostPage()
        {
            InitializeComponent();
            BindingContext = vm = new SlozenostViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            //  await vm.Init();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DodajSlozenost());

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrikazSlozenosti());

        }
    }
}