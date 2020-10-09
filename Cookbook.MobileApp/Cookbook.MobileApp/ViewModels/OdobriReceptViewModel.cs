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
  public class OdobriReceptViewModel
    {
        APIService _apiRecept = new APIService("Recept");
        APIService _apiKorisnik = new APIService("Korisnik");
        public OdobriReceptViewModel()
        {
            PrikazRecepataCommand = new Command(async () => await PrikazRecepata());
        }
        public ICommand PrikazRecepataCommand { get; set; }
        public ObservableCollection<Recept> ReceptList { get; set; } = new ObservableCollection<Recept>();
        public async Task PrikazRecepata()
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
            var list = await _apiRecept.Get<List<Recept>>(null);
            ReceptList.Clear();
            foreach (var p in list)
            {
                if (p.KorisnikId != korisnik.KorisnikId)
                {
                    ReceptList.Add(p);
                }
            }
        }

    }
}
