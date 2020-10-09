using Cookbook.MobileApp.ViewModels;
using Cookbook.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cookbook.MobileApp.Views.Posjetilac
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetaljiRecepta : ContentPage
    {
        APIService _recept = new APIService("Recept");
        ReceptDetaljiViewModel model = null;
        Recept recept = null;
        public DetaljiRecepta(Recept r)
        {
            InitializeComponent();
            BindingContext = model = new ReceptDetaljiViewModel(r);
            recept = r;
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DodajKomentar(recept));
        }
    }
}