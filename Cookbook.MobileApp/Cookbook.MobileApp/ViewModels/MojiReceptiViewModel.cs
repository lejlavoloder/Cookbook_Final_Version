using Cookbook.MobileApp.ViewModels;
using Cookbook.Model;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Cookbook.MobileApp.ViewModels { 
    public class MojiReceptiViewModel : BaseViewModel
    {
        public APIService _apiKorisnik = new APIService("Korisnik");
        public APIService _apiRecept = new APIService("Recept");

        public MojiReceptiViewModel()
        {
            InitCommand = new Command(async () => await Init());
           }
        public ICommand InitCommand { get; set; }      
        public ObservableCollection<Recept> ReceptList { get; set; } = new ObservableCollection<Recept>();
       
        public async Task Init()
        {
            IsBusy = true;
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
            var recepti = await _apiRecept.Get<IEnumerable<Recept>>(null);
            foreach(var a in recepti)
            {
                if (a.KorisnikId == korisnik.KorisnikId)
                {
                    ReceptList.Add(a);
                }
            }
           
        }
    }
}
