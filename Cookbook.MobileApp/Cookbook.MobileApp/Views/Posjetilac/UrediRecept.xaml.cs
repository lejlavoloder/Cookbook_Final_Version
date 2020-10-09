using Cookbook.MobileApp.ViewModels;
using Cookbook.Model;
using Cookbook.Model.Requests;
using Plugin.Media;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cookbook.MobileApp.Views.Posjetilac
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UrediRecept : ContentPage
    {
        public APIService Recept = new APIService("Recept");
        public APIService Korisnik = new APIService("Korisnik");
        private Recept cookbook = null;
        public UrediReceptViewModel model { get; set; }
        public UrediRecept(Recept r)
        {
            InitializeComponent();
            this.BindingContext = model = new UrediReceptViewModel { recept = r };
            cookbook = r;
            model.Slika = r.Slika;
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.UcitajKategoriju();
            this.kategorija.SelectedItem = model.KategorijaList.FirstOrDefault(s => s.KategorijaId == model.recept.KategorijaId);
            await model.UcitajSlozenost();
            this.slozenost.SelectedItem = model.SlozenostList.FirstOrDefault(s => s.SlozenostId == model.recept.SlozenostId);
            await model.UcitajGrupuJela();
            this.grupajela.SelectedItem = model.GrupaJelaList.FirstOrDefault(s => s.GrupaJelaId == model.recept.GrupaJelaId);

        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(this.Naziv.Text, @"^[a-zA-Z ]+$") && this.Naziv.Text.Length < 4)
            {
                await DisplayAlert("Greška", "Naziv se sastoji samo od slova", "OK");
            }
            else if (!Regex.IsMatch(this.Tekst.Text, @"^[a-zA-Z ]+$") && this.Tekst.Text.Length < 10)
            {
                await DisplayAlert("Greška", "Tekst se sastoji samo od slova", "OK");
            }
            else if (this.grupajela.SelectedItem == null)
            {
                await DisplayAlert("Greška", "Trebate odabrati grupu jela", "OK");
            }
            else if (this.kategorija.SelectedItem == null)
            {
                await DisplayAlert("Greška", "Trebate odabrati kategoriju jela", "OK");
            }
            else if (this.slozenost.SelectedItem == null)
            {
                await DisplayAlert("Greška", "Trebate odabrati slozenost jela", "OK");
            }
            else if (!Regex.IsMatch(this.BrojLjudi.Text, @"^[0-9]+$"))
            {
                await DisplayAlert("Greška", "Broj ljudi se označava brojem", "OK");
            }

            else if (!Regex.IsMatch(this.VrijemePripreme.Text, @"^[0-9]+$"))
            {
                await DisplayAlert("Greška", "Vrijeme pripreme se piše u minutama", "OK");
            }
            else if (!Regex.IsMatch(this.VrijemeKuhanja.Text, @"^[0-9]+$"))
            {
                await DisplayAlert("Greška", "Vrijeme kuhanja se piše u minutama", "OK");
            }
            else
            {
                try
                {
                    Korisnik korisnik = new Korisnik();
                    var username = APIService.Username;
                    List<Korisnik> lista = await Korisnik.Get<List<Korisnik>>(null);
                    foreach (var k in lista)
                    {
                        if (k.KorisnickoIme == username)
                        {
                            korisnik = k;
                            break;
                        }
                    }

                    ReceptUpsertRequest req = new ReceptUpsertRequest();

                    req.Naziv = this.Naziv.Text;
                    req.Tekst = this.Tekst.Text;
                    req.DatumObjave = this.DatumObjave.Date;
                    GrupaJela grupajela = this.grupajela.SelectedItem as GrupaJela;
                    req.GrupaJelaId = grupajela.GrupaJelaId;
                    Kategorija kategorija = this.kategorija.SelectedItem as Kategorija;
                    req.KategorijaId = kategorija.KategorijaId;
                    Slozenost slozenost = this.slozenost.SelectedItem as Slozenost;
                    req.SlozenostId = slozenost.SlozenostId;
                    req.KorisnikId = korisnik.KorisnikId;
                    req.Slika = model.Slika;
                    req.Odobren = true;
                    req.VrijemeKuhanja = Convert.ToInt32(this.VrijemeKuhanja.Text);
                    req.VrijemePripreme = Convert.ToInt32(this.VrijemePripreme.Text);
                    req.BrojLjudi = Convert.ToInt32(this.BrojLjudi.Text);
                    await Recept.Update<dynamic>(model.recept.ReceptId, req);
                    await Application.Current.MainPage.DisplayAlert("Poruka", "Uspješno uneseni podaci", "OK");
                    await Navigation.PushAsync(new PrikazRecepataPage());
                }
                catch (Exception err)
                {
                    throw new Exception(err.Message);
                }
            }
        }
        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                await DisplayAlert(" ", "Format slike nije podržan!", "OK");
                return;
            }

            var file = await CrossMedia.Current.PickPhotoAsync();
            if (file == null)
                return;

            Stream stream = file.GetStream();

            using (MemoryStream ms = new MemoryStream())
            {
                stream.CopyTo(ms);
                model.Slika = ms.ToArray();
            }
        }
    }
}
