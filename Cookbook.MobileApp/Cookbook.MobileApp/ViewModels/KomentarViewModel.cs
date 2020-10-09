using Cookbook.Model;
using Cookbook.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Cookbook.MobileApp.ViewModels
{
  public class KomentarViewModel:BaseViewModel
    {
        private APIService _komentar = new APIService("Komentar");
        private APIService _korisnik = new APIService("Korisnik");
        public Komentar komentar { get; set; }
        public Recept recept { get; set; }
        public KomentarViewModel()
        {

        }
        public KomentarViewModel(Recept recept) : base()
        {
            DodajKomentarCommand = new Command(async () => await DodajKomentar());
            DodajKomentarCommandAdmin = new Command(async () => await DodajKomentarAdmin());
            PrikazKomentaraCommand = new Command(async () => await PrikazKomentara());
            this.recept = recept;
        }
        public Korisnik korisnik { get; set; }
        public ICommand DodajKomentarCommand { get; set; }
        public ICommand DodajKomentarCommandAdmin { get; set; }
        public ICommand PrikazKomentaraCommand { get; set; }
        public ObservableCollection<Komentar> KomentarList { get; set; } = new ObservableCollection<Komentar>();
        string _sadrzaj = string.Empty;
        public string Sadrzaj
        {
            get { return _sadrzaj; }
            set { SetProperty(ref _sadrzaj, value); }
        }
        public async Task PrikazKomentara()
        {
            var list = await _komentar.Get<IEnumerable<Komentar>>(null);
            KomentarList.Clear();
            foreach(var list1 in list)
            {
                if (list1.ReceptId == recept.ReceptId && list1.Odobreno==true)
                {
                    KomentarList.Add(list1);
                }
            }

        }
        public async Task DodajKomentar()
        {
            var username = APIService.Username;
            List<Korisnik> listKupci = await _korisnik.Get<List<Korisnik>>(null);
            foreach (var k in listKupci)
            {
                if (k.KorisnickoIme == username)
                {
                    korisnik = k;
                    break;
                }
            }
            KomentarUpsertRequest req = new KomentarUpsertRequest();
            req.KorisnikId = korisnik.KorisnikId;
            req.ReceptId = recept.ReceptId;
            req.Odobreno = false;
            req.Sadrzaj = _sadrzaj;
            req.Datum = DateTime.Now;

            await _komentar.Insert<Komentar>(req);
            await Application.Current.MainPage.DisplayAlert("Poruka", "Vaš komentar poslan je na odobravanje", "OK");

        }
        public async Task DodajKomentarAdmin()
        {
            var username = APIService.Username;
            List<Korisnik> listKupci = await _korisnik.Get<List<Korisnik>>(null);
            foreach (var k in listKupci)
            {
                if (k.KorisnickoIme == username)
                {
                    korisnik = k;
                    break;
                }
            }
            KomentarUpsertRequest req = new KomentarUpsertRequest();
            req.KorisnikId = korisnik.KorisnikId;
            req.ReceptId = recept.ReceptId;
            req.Odobreno = true;
            req.Sadrzaj = _sadrzaj;
            req.Datum = DateTime.Now;

            await _komentar.Insert<Komentar>(req);
            await Application.Current.MainPage.DisplayAlert("Poruka", "Komentar uspješno sačuvan", "OK");

        }
    }
}
