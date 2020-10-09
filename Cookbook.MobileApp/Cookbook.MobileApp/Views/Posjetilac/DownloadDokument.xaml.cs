using Cookbook.MobileApp.ViewModels;
using Cookbook.Model;
using GalaSoft.MvvmLight.Ioc;
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
    public partial class DownloadDokument : ContentPage
    {
        private readonly DownloadViewModel VM;
        private readonly Dokument dokument;
        public DownloadDokument(Dokument dokument)
        {
            InitializeComponent();
            this.BindingContext = VM = SimpleIoc.Default.GetInstance<DownloadViewModel>();
            this.dokument = dokument;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            VM.Init(dokument);

            Navigation.PopAsync();
        }
    }
}