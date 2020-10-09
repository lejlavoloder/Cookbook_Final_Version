using Cookbook.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Cookbook.MobileApp.ViewModels
{
    public class PrikazKomentaraViewModel : BaseViewModel
    {
      public  PrikazKomentaraViewModel()
        {
            InitCommand = new Command(async () => await UcitajRecepte());
            InitCommand1 = new Command(async () => await UcitajKorisnike());
            PrikazKomentaraCommand = new Command(async () => await PrikazKomentara());
        }
    public ICommand PrikazKomentaraCommand { get; set; }
    public ICommand InitCommand { get; set; }
    public ICommand InitCommand1 { get; set; }

    private APIService _komentar = new APIService("Komentar");
    private APIService _recept = new APIService("Recept");
    private APIService _korisnik = new APIService("Korisnik");
        public ObservableCollection<Komentar> KomentarList { get; set; } = new ObservableCollection<Komentar>();
        public ObservableCollection<Recept>ReceptList { get; set; } = new ObservableCollection<Recept>();
        public ObservableCollection<Korisnik> KorisnikList { get; set; } = new ObservableCollection<Korisnik>();

        public Recept recept { get; set; }
        public Komentar komentar { get; set; }


        public async Task UcitajRecepte()
        {
            var list = await _recept.Get<List<Recept>>(null);
            ReceptList.Clear();
            foreach (var p in list)
            {
                ReceptList.Add(p);
            }
        }

        public async Task UcitajKorisnike()
        {
            var list = await _korisnik.Get<List<Korisnik>>(null);
            KorisnikList.Clear();
            foreach (var k in list)
            {
                KorisnikList.Add(k);
            }
        }
        public async Task PrikazKomentara()
        {
            var list = await _komentar.Get<IEnumerable<Komentar>>(null);
            KomentarList.Clear();
            foreach (var komentar in list)
            {
                KomentarList.Add(komentar);
            }
        }
        string _sadrzaj = string.Empty;
        public string Sadrzaj
        {
            get { return _sadrzaj; }
            set { SetProperty(ref _sadrzaj, value); }
        }

        int _korisnikId = 0;
        public int KorisnikId
        {
            get { return _korisnikId; }
            set { SetProperty(ref _korisnikId, value); }
        }

        int _receptId = 0;
        public int ReceptId
        {
            get { return _receptId; }
            set { SetProperty(ref _receptId, value); }
        }

    }
}

