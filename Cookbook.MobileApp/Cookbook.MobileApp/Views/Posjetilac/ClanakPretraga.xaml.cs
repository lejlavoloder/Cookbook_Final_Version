using Cookbook.MobileApp.ViewModels;
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
    public partial class ClanakPretraga : ContentPage
    {
        ClanakViewModel model = null;
        public ClanakPretraga()
        {
            InitializeComponent();
            BindingContext = model = new ClanakViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.PretragaClanaka();
        }

    }
}