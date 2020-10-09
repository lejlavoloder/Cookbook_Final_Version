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
    public partial class OcijeniReceptPage : ContentPage
    {
        public APIService _recept = new APIService("Recept");
        public APIService _posjetilac = new APIService("Posjetilac");
        public OcijeniReceptViewModel model { get; set; }
        private Recept r = null;
        public OcijeniReceptPage(Recept recept)
        {
            InitializeComponent();
            BindingContext = model = new OcijeniReceptViewModel { recept = recept };
            r = recept;
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
           await model.Init();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (!decimal.TryParse(this.Ocjena.Text, out decimal Ocjena) || Ocjena < 1 || Ocjena > 10)
            {
                await DisplayAlert("Greška", "Ocjena mora biti između 1 i 10.", "OK");
                return;
            }

            Model.Posjetilac posjetilac = new Model.Posjetilac();
            var username = APIService.Username;
            List<Model.Posjetilac> lista = await _posjetilac.Get<List<Model.Posjetilac>>(null);
            foreach (var posjetilac1 in lista)
            {
                if (posjetilac1.KorisnickoIme == username)
                {
                    posjetilac = posjetilac1;
                    break;
                }
            }
            model.Ocjena = Ocjena;
            model.ReceptId = r.ReceptId;
            model.PosjetilacId = posjetilac.PosjetilacId;

            await model.DodajOcjenu();
            await Navigation.PushAsync(new PrikazRecepata());
        }

    }
}

