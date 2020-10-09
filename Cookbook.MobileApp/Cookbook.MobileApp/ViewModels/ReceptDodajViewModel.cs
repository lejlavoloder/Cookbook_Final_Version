using Cookbook.Model;
using Cookbook.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Cookbook.MobileApp.ViewModels
{
    public class ReceptDodajViewModel : BaseViewModel
    {
        private readonly APIService _apisastojak = new APIService("Sastojak");
        private readonly APIService _apimjernakolicina = new APIService("MjernaKolicina");
        private readonly APIService _apimjernajedinica = new APIService("MjernaJedinica");
        private readonly APIService _apigrupajela = new APIService("GrupaJela");
        private readonly APIService _apikategorija = new APIService("Kategorija");
        private readonly APIService _apislozenost = new APIService("Slozenost");
        private readonly APIService _apikorisnik = new APIService("Korisnik");
        private readonly APIService _apirecept = new APIService("Recept");
        private readonly APIService _apireceptSastojak = new APIService("ReceptSastojak");
        public Recept recept { get; set; }
        public ReceptDodajViewModel()
        {
            InitCommand = new Command(async () => await Init());
            DodajReceptCommand = new Command(async () => await DodajRecept());
            DodajSastojakCommand = new Command(async () => await DodajSastojak());
            byte[] defaultPhoto = File.ReadAllBytes("no-photo.png");
            Slika = defaultPhoto;
        }
        public ObservableCollection<GrupaJela> GrupaJelaList { get; set; } = new ObservableCollection<GrupaJela>();
        public ObservableCollection<MjernaJedinica> MjernaJedinicaList { get; set; } = new ObservableCollection<MjernaJedinica>();
        public ObservableCollection<MjernaKolicina> MjernaKolicinaList { get; set; } = new ObservableCollection<MjernaKolicina>();
        public ObservableCollection<Sastojak> SastojakList { get; set; } = new ObservableCollection<Sastojak>();
        public ObservableCollection<Kategorija> KategorijaList { get; set; } = new ObservableCollection<Kategorija>();
        public ObservableCollection<Slozenost> SlozenostList { get; set; } = new ObservableCollection<Slozenost>();
        public ObservableCollection<ReceptSastojak> ReceptSastojakList { get; set; } = new ObservableCollection<ReceptSastojak>();
        public ICommand InitCommand { get; set; }
        public ICommand DodajSastojakCommand { get; set; }
        public ICommand DodajReceptCommand { get; set; }
        public async Task Init()
        {
            var list = await _apigrupajela.Get<List<GrupaJela>>(null);
            GrupaJelaList.Clear();
            foreach (var z in list)
            {
                GrupaJelaList.Add(z);
            }

            var list1 = await _apislozenost.Get<List<Slozenost>>(null);
            SlozenostList.Clear();
            foreach (var h in list1)
            {
                SlozenostList.Add(h);
            }

            var list2 = await _apikategorija.Get<List<Kategorija>>(null);
            KategorijaList.Clear();
            foreach (var h in list2)
            {
                KategorijaList.Add(h);
            }
        }
        public async Task DodajSastojak()
        {
            var list = await _apisastojak.Get<IEnumerable<Sastojak>>(null);
            SastojakList.Clear();
            foreach(var b in list)
            {
                SastojakList.Add(b);
            }
            var list1 = await _apimjernajedinica.Get<IEnumerable<MjernaJedinica>>(null);
            MjernaJedinicaList.Clear();
            foreach (var b in list1)
            {
                MjernaJedinicaList.Add(b);
            }
            var list2 = await _apimjernakolicina.Get<IEnumerable<MjernaKolicina>>(null);
            MjernaKolicinaList.Clear();
            foreach (var b in list2)
            {
                MjernaKolicinaList.Add(b);
            }
        }
        DateTime _datumObjave = DateTime.Now;
        public DateTime DatumVrijemeObjave
        {
            get { return _datumObjave; }
            set { SetProperty(ref _datumObjave, value); }
        }
        string _naziv = string.Empty;
        public string Naziv
        {
            get { return _naziv; }
            set { SetProperty(ref _naziv, value); }
        }
        string _tekst = string.Empty;
        public string Tekst
        {
            get { return _tekst; }
            set { SetProperty(ref _tekst, value); }
        }
        int _kategorijaid = 0;
        public int KategorijaId
        {
            get { return _kategorijaid; }
            set { SetProperty(ref _kategorijaid, value); }
        }
        int _slozenostid = 0;
        public int SlozenostId
        {
            get { return _slozenostid; }
            set { SetProperty(ref _slozenostid, value); }
        }
        int _grupajelaid = 0;
        public int GrupaJelaId
        {
            get { return _grupajelaid; }
            set { SetProperty(ref _grupajelaid, value); }
        }
        int _brojljudi = 0;
        public int BrojLjudi
        {
            get { return _brojljudi; }
            set { SetProperty(ref _brojljudi, value); }
        }
        double _vrijemepripreme = 0;
        public double VrijemePripreme
        {
            get { return _vrijemepripreme; }
            set { SetProperty(ref _vrijemepripreme, value); }
        }
        double _vrijemekuhanja = 0;
        public double VrijemeKuhanja
        {
            get { return _vrijemekuhanja; }
            set { SetProperty(ref _vrijemekuhanja, value); }
        }
        byte[] _slika = new byte[0];
        public byte[] Slika
        {
            get { return _slika; }
            set { SetProperty(ref _slika, value); }
        }

        List<ReceptSastojak> _sastojci = null;
        public List<ReceptSastojak> Sastojci
        {
            get { return _sastojci; }
            set { SetProperty(ref _sastojci, value); }
        }
        public async Task DodajRecept()
        {
            IsBusy = true;
            Korisnik korisnik = new Korisnik();
            var username = APIService.Username;
            List<Korisnik> lista = await _apikorisnik.Get<List<Korisnik>>(null);
            foreach (var k in lista)
            {
                if (k.KorisnickoIme == username)
                {
                    korisnik = k;
                    break;
                }
            }
            var result = await _apirecept.Insert<Recept>(new ReceptUpsertRequest()
            {
                Naziv = _naziv,
                Tekst = _tekst,
                DatumObjave = _datumObjave,
                GrupaJelaId = _grupajelaid,
                KategorijaId = _kategorijaid,
                SlozenostId = _slozenostid,
                Odobren = true,
                Slika = _slika,
                BrojLjudi = _brojljudi,
                VrijemeKuhanja = _vrijemekuhanja,
                VrijemePripreme = _vrijemepripreme,
                KorisnikId = korisnik.KorisnikId
            });
            recept = result;
           
            }
        }

    }
