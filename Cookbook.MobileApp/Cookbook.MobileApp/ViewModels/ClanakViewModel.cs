using Cookbook.Model;
using Cookbook.Model.Requests;
using Cookbook.MobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Windows.Input;
using System.Collections.ObjectModel;
using Cookbook.MobileApp.Views;

namespace Cookbook.MobileApp.ViewModels
{//mogu li ti otvorit tudji kod hajde
  public class ClanakViewModel:BaseViewModel
    {
        private readonly APIService _clanak = new APIService("Clanak");
        private readonly APIService _vrstaclanka = new APIService("VrstaClanka");
        private APIService _korisnik = new APIService("Korisnik");
        public ClanakViewModel() {
            InitCommand = new Command(async () =>await Init());
            DodajClanakCommand = new Command(async () => await DodajClanak());
            PrikazClanakaCommand = new Command(async () => await PrikazClanaka());
            PretragaClanakaCommand = new Command(async () => await PretragaClanaka());
        }
        public ICommand InitCommand { get; set; }
        public ICommand DodajClanakCommand { get; set; }
        public ICommand PrikazClanakaCommand { get; set; }
        public ICommand PretragaClanakaCommand { get; set; }

        public ObservableCollection<Clanak> ClanakList { get; set; } = new ObservableCollection<Clanak>();
       
        public ObservableCollection<VrstaClanka> VrstaClankaList { get; set; } = new ObservableCollection<VrstaClanka>();
        VrstaClanka _selectedVrstaClanka = null;
       
        public VrstaClanka SelectedVrstaClanka
        {
            get { return _selectedVrstaClanka; }
            set
            {
                SetProperty(ref _selectedVrstaClanka, value);
                if (value != null)
                {
                    PretragaClanakaCommand.Execute(null);
                }
            }
        }
        public async Task PretragaClanaka()
        {
            if (VrstaClankaList.Count() == 0)
            {
                var vrstaclankalist = await _vrstaclanka.Get<List<VrstaClanka>>(null);
                foreach(var i in vrstaclankalist)
                {
                    VrstaClankaList.Add(i);
                }
            }
            if (SelectedVrstaClanka != null)
            {
                ClanakSearchRequest request = new ClanakSearchRequest();
                request.VrstaClankaId = SelectedVrstaClanka.VrstaClankaId;
                var list = await _clanak.Get<List<Clanak>>(request);
                ClanakList.Clear();
                foreach(var b in list)
                {
                    ClanakList.Add(b);
                }
            }
        }
        public async Task Init()
        {
            var list = await _vrstaclanka.Get<List<VrstaClanka>>(null);
            VrstaClankaList.Clear();
            foreach (var z in list)
            {
                VrstaClankaList.Add(z);
            }
           
        }
        public async Task DodajClanak()
        {
            IsBusy = true;
            Korisnik korisnik = new Korisnik();
            var username = APIService.Username;
            List<Korisnik> lista = await _korisnik.Get<List<Korisnik>>(null);
            foreach (var k in lista)
            {
                if (k.KorisnickoIme == username)
                {
                    korisnik = k;
                    break;
                }
            }
            await _clanak.Insert<Clanak>(new ClanakInsertRequest()
            {
                Naziv = _naziv,
                Tekst=_tekst,
                DatumObjave=_datumNovosti,
                VrstaClankaId=_vrstaclankaid,
                KorisnikId=korisnik.KorisnikId
            });
          
            //DisplayAlert("Poruka", "Uspješno sačuvani podaci", "OK");

            //Device.BeginInvokeOnMainThread(async () => { await Application.Current.MainPage.DisplayAlert("Poruka", "Uspjesno sacuvani podaci", "Ok"); });
            //Application.Current.MainPage = new PrikazClankaPage();
        }
        public async Task PrikazClanaka()
        {
            var list = await _clanak.Get<IEnumerable<Clanak>>(null);
            ClanakList.Clear();
            foreach (var s in list)
            {
                ClanakList.Add(s);
            }
        }
        DateTime _datumNovosti = DateTime.Now;
        public DateTime DatumVrijemeObjave
        {
            get { return _datumNovosti; }
            set { SetProperty(ref _datumNovosti, value); }
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
        int _vrstaclankaid = 0;
        public int VrstaClankaId
        {
            get { return _vrstaclankaid; }
            set { SetProperty(ref _vrstaclankaid, value); }
        }
    }
}
