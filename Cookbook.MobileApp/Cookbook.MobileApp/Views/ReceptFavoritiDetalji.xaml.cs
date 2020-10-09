using Cookbook.MobileApp.ViewModels;
using Cookbook.Model;
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
    public partial class ReceptFavoritiDetalji : ContentPage
    {
        ReceptFavoritiDetaljiViewModel model = null;
      
        public ReceptFavoritiDetalji(Favoriti f, Recept recept)
        {
            InitializeComponent();
            BindingContext = model = new ReceptFavoritiDetaljiViewModel(recept, f);
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
    }
}