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
    public class NotifikacijaViewModel
    {
        private readonly APIService _apiNotifikacija = new APIService("Notifikacija");
        private readonly APIService _apiKorisnik = new APIService("Korisnik");
        private readonly APIService _apiRecept = new APIService("Recept");
        public NotifikacijaViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Notifikacija> NotifikacijaList { get; set; } = new ObservableCollection<Notifikacija>();
        public ObservableCollection<Recept> ReceptList { get; set; } = new ObservableCollection<Recept>();
        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            var list = await _apiNotifikacija.Get<IEnumerable<Notifikacija>>(null);
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
            ReceptList.Clear();
            var list2 = await _apiRecept.Get<IEnumerable<Recept>>(null);
            foreach (var b in list2)
            {
                if (b.KorisnikId == korisnik.KorisnikId)
                {
                    ReceptList.Add(b);
                }
            }
            NotifikacijaList.Clear();
            foreach (var notif in list)
            {
                foreach (var c in ReceptList)
                {
                    if (notif.ReceptId == c.ReceptId && notif.IsProcitano==false)
                    {
                        NotifikacijaList.Add(notif);
                    }
                }
            }
        }
        public async Task Procitano(Notifikacija n)
        {
            var entity = await _apiNotifikacija.Update<Notifikacija>(n.NotifikacijaId, new NotifikacijaUpsertRequest
            {
                DatumSlanja = n.DatumSlanja,
                Sadrzaj = n.Sadrzaj,
                IsProcitano = true,
                ReceptId = n.ReceptId
            });
            if (entity != null)
            {
                await Application.Current.MainPage.DisplayAlert(" ", "Notifikacija je oznacena kao procitana!", "OK");
            }
        }
    }
}