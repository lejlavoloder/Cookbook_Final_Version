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
    public partial class PrikazRegistrovanihPosjetioca : ContentPage
    {
        PrikazRegistrovanihPosjetiocaViewModel model = null;
        public PrikazRegistrovanihPosjetioca()
        {
            InitializeComponent();
            BindingContext = model = new PrikazRegistrovanihPosjetiocaViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();

            await model.PrikazPosjetilaca();
        }
    }
}