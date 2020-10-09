using Cookbook.MobileApp.Views.Posjetilac;
using Cookbook.Model;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Cookbook.MobileApp.ViewModels
{
    public class SistemPreporukeViewModel : BaseViewModel
    {
        private readonly APIService _apiServicePreporuke = new APIService("Preporuka");
        private readonly APIService _apiServiceKorisnik = new APIService("Korisnik");

        public ObservableCollection<Recept> ReceptList { get; set; } = new ObservableCollection<Recept>();

        public SistemPreporukeViewModel()
        {
            InitCommand = new Command(async () => await Init());
         }
        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            Korisnik korisnik = new Korisnik();
            var username = APIService.Username;
            List<Korisnik> lista = await _apiServiceKorisnik.Get<List<Korisnik>>(null);
            foreach (var k in lista)
            {
                if (k.KorisnickoIme == username)
                {
                    korisnik = k;
                    break;
                }
            }

            var list = await _apiServicePreporuke.GetById<List<Recept>>(korisnik.KorisnikId);
            ReceptList.Clear();

            foreach (var item in list)
            {
                if (item.Odobren == true)
                {
                    ReceptList.Add(item);
                }
            }
        }

    }
    
}
