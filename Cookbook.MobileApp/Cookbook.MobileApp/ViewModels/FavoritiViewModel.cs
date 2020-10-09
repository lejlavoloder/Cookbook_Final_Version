using Cookbook.Model;
using Cookbook.Model.Requests;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Cookbook.MobileApp.ViewModels
{
    public class FavoritiViewModel : BaseViewModel
    {
        public Recept r { get; set; }
        public APIService _apiKorisnik = new APIService("Korisnik");
        public APIService _apiFavoriti = new APIService("Favoriti");
        bool primljeno = false;
        public ICommand InitCommand { get; set; }
       public FavoritiViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public async Task Init()
        {
            var list = await _apiFavoriti.Get<List<Favoriti>>(null);
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
            foreach (var g in list)
            {
                if(g.ReceptId==r.ReceptId && g.KorisnikId == korisnik.KorisnikId)
                {
                    primljeno = true;
                }
            }
            if (primljeno == true)
            {
                await Application.Current.MainPage.DisplayAlert("Poruka", "Ovaj recept već imate u favoritima", "OK");
            }
            else
            {
                FavoritiUpsertRequest req =  new FavoritiUpsertRequest();
                req.KorisnikId = korisnik.KorisnikId;
                req.ReceptId = r.ReceptId;
                await _apiFavoriti.Insert<Favoriti>(req);
                await Application.Current.MainPage.DisplayAlert("Poruka", "Recept je pohranjen za vašeg favorita", "OK");
            }
        }
    } 
    }