using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Cookbook.MobileApp.Services;
using Cookbook.MobileApp.Views;

namespace Cookbook.MobileApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

           // DependencyService.Register<MockDataStore>();
            MainPage = new ContentPage();
        }

        protected override void OnStart()
        {
            Bootstrap.Instance.Setup();
            MainPage = new LoginPage();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
