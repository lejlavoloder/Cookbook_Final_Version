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
    public class FavoritiPrikazViewModel
    {
        public FavoritiPrikazViewModel()
        {
            PrikazFavoritaCommand = new Command(async () => await PrikazFavorita());
        }
        public ICommand PrikazFavoritaCommand { get; set; }
        public ObservableCollection<Favoriti> FavoritiList { get; set; } = new ObservableCollection<Favoriti>();
        public APIService _apiFavoriti = new APIService("Favoriti");
        public APIService _apiKorisnik = new APIService("Korisnik");
        public async Task PrikazFavorita()
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
            var list = await _apiFavoriti.Get<IEnumerable<Favoriti>>(null);
            FavoritiList.Clear();
            foreach (var favoriti in list)
            {
                if (favoriti.KorisnikId == korisnik.KorisnikId)
                {
                    FavoritiList.Add(favoriti);
                }
            }
        }
    }
}
    
