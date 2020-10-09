using Cookbook.MobileApp.ViewModels;
using Cookbook.Model;
using Cookbook.Model.Requests;
using Plugin.Media;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace Cookbook.MobileApp.Views.Posjetilac
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DodajReceptPage : ContentPage
    {
        private List<Layout<View>> stackLayouts = new List<Layout<View>>();
        APIService _apiKorisnik = new APIService("Korisnik");
        APIService _apiReceptSastojak = new APIService("ReceptSastojak");
        DodajReceptPosjetiocViewModel model = null;
        ObservableCollection<ReceptSastojak> ReceptSastojakList { get; set; } = new ObservableCollection<ReceptSastojak>();
        public DodajReceptPage()
        {
            InitializeComponent();
            BindingContext = model = new DodajReceptPosjetiocViewModel();
            stackLayouts = new List<Layout<View>>
            {
                prviPage,
                drugiPage,
                treciPage,
                cetvrtiPage,
                petiPage
            };
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
        private void prethodni_Clicked(object sender, EventArgs e)
        {
            var visibleStackIndex = stackLayouts.IndexOf(stackLayouts.FirstOrDefault(X => X.IsVisible));
            if (visibleStackIndex > 0)
            {
                stackLayouts[visibleStackIndex].IsVisible = false;
                stackLayouts[visibleStackIndex - 1].IsVisible = true;

                slijedeci.IsEnabled = true;

                if (visibleStackIndex - 1 == 0)
                    prethodni.IsEnabled = false;
            }
        }

        private void slijedeci_Clicked(object sender, EventArgs e)
        {
            var visibleStackIndex = stackLayouts.IndexOf(stackLayouts.FirstOrDefault(X => X.IsVisible));
            if (visibleStackIndex < stackLayouts.Count - 1)
            {
                stackLayouts[visibleStackIndex].IsVisible = false;
                stackLayouts[visibleStackIndex + 1].IsVisible = true;

                prethodni.IsEnabled = true;

                if (visibleStackIndex + 1 == stackLayouts.Count - 1)
                {
                    slijedeci.IsEnabled = false;
                }
                if (visibleStackIndex == 2)
                {
                    slijedeci.IsEnabled = false;
                }
            }

        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (ReceptSastojakList.Count() <= 1)
            {
                await DisplayAlert("Greška", "Potrebno je unijeti minimalno 2 sastojka", "OK");
            }
            else if (!Regex.IsMatch(this.Naziv.Text, @"^[a-zA-Z ]+$") && this.Naziv.Text.Length < 4)
            {
                await DisplayAlert("Greška", "Naziv se sastoji samo od slova", "OK");
            }
            else if (!Regex.IsMatch(this.Tekst.Text, @"^[a-zA-Z ]+$") && this.Tekst.Text.Length < 10)
            {
                await DisplayAlert("Greška", "Tekst se sastoji samo od slova", "OK");
            }
            else if (this.GrupaJelaPicker.SelectedItem == null)
            {
                await DisplayAlert("Greška", "Trebate odabrati grupu jela", "OK");
            }
            else if (this.KategorijaPicker.SelectedItem == null)
            {
                await DisplayAlert("Greška", "Trebate odabrati kategoriju jela", "OK");
            }
            else if (this.SlozenostPicker.SelectedItem == null)
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
                    List<Korisnik> lista = await _apiKorisnik.Get<List<Korisnik>>(null);
                    foreach (var k in lista)
                    {
                        if (k.KorisnickoIme == username)
                        {
                            korisnik = k;
                            break;
                        }
                    }
                    model.Naziv = this.Naziv.Text;
                    model.Tekst = this.Tekst.Text;
                    GrupaJela grupajela = this.GrupaJelaPicker.SelectedItem as GrupaJela;
                    model.GrupaJelaId = grupajela.GrupaJelaId;
                    Kategorija kategorija = this.KategorijaPicker.SelectedItem as Kategorija;
                    model.KategorijaId = kategorija.KategorijaId;
                    Slozenost slozenost = this.SlozenostPicker.SelectedItem as Slozenost;
                    model.SlozenostId = slozenost.SlozenostId;
                    model.DatumVrijemeObjave = DateTime.Now;
                    model.VrijemeKuhanja = Convert.ToInt32(this.VrijemeKuhanja.Text);
                    model.VrijemePripreme = Convert.ToInt32(this.VrijemePripreme.Text);
                   
                    model.BrojLjudi = Convert.ToInt32(this.BrojLjudi.Text);
                    await model.DodajRecept();
                    ReceptSastojakList.ForEach(x => x.ReceptId = model.recept.ReceptId);
                    foreach (var i in ReceptSastojakList)
                    {
                        ReceptSastojakUpsertRequest requestSastojak = new ReceptSastojakUpsertRequest()
                        {
                            SastojakId = i.SastojakId,
                            MjernaJedinicaId = i.MjernaJedinicaId,
                            MjernaKolicinaId = i.MjernaKolicinaId,
                            ReceptId = i.ReceptId

                        };
                        await _apiReceptSastojak.Insert<ReceptSastojak>(requestSastojak);
                    }
                    await Application.Current.MainPage.DisplayAlert("Poruka", "Uspješno ste pohranili recept", "OK");
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
        private async void dodajSastojak_Clicked(object sender, EventArgs e)
        {
            await model.DodajSastojak();
            cetvrtiPage.IsVisible = false;
            petiPage.IsVisible = true;
        }

        private async void SacuvajSastojak_Clicked(object sender, EventArgs e)
        {
            if (this.MjernaKolicinaPicker.SelectedItem == null)
            {
                await DisplayAlert("Greška", "Trebate odabrati mjernu kolicinu jela", "OK");
            }
            else if (this.MjernaJedinicaPicker.SelectedItem == null)
            {
                await DisplayAlert("Greška", "Trebate odabrati mjernu jedinicu", "OK");
            }
            else if (this.SastojakPicker.SelectedItem == null)
            {
                await DisplayAlert("Greška", "Trebate odabrati sastojak", "OK");
            }
            else
            {
                MjernaKolicina mjernakolicina = this.MjernaKolicinaPicker.SelectedItem as MjernaKolicina;
                MjernaJedinica mjernajedinica = this.MjernaJedinicaPicker.SelectedItem as MjernaJedinica;
                Sastojak sastojak = this.SastojakPicker.SelectedItem as Sastojak;
                ReceptSastojak receptsastojak = new ReceptSastojak
                {
                    MjernaJedinicaId = mjernajedinica.MjernaJedinicaId,
                    MjernaJedinica = mjernajedinica.Naziv,
                    SastojakId = sastojak.SastojakId,
                    Sastojak = sastojak.Naziv,
                    MjernaKolicinaId = mjernakolicina.MjernaKolicinaId,
                    MjernaKolicina = mjernakolicina.Kolicina
                };
                ReceptSastojakList.Add(receptsastojak);
                dataGrid.ItemsSource = ReceptSastojakList.Select(x => new
                {
                    x.MjernaKolicina,
                    x.MjernaJedinica,
                    x.Sastojak
                }).ToArray();
                this.SastojakPicker.SelectedItem = 0;
                this.MjernaJedinicaPicker.SelectedItem = 0;
                this.MjernaKolicinaPicker.SelectedItem = 0;
                cetvrtiPage.IsVisible = true;
                petiPage.IsVisible = false;
            }
        }
    }
}
