using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Cookbook.MobileApp.Models;
using Cookbook.Model;

namespace Cookbook.MobileApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
        
    { 
        public APIService _korisnik = new APIService("Korisnik");
        Dictionary<int, NavigationPage> MenuPages 
            = new Dictionary<int, NavigationPage>();

        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;
        }

        public MainPage(MenuItemType type)
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;
            _ = NavigateFromMenu((int)type);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Naslovna:
                        MenuPages.Add(id, new NavigationPage(new MapPage()));
                        break; 
                    case (int)MenuItemType.Recepti:
                        MenuPages.Add(id, new NavigationPage(new Posjetilac.ReceptPage()));
                        break;   
                    case (int)MenuItemType.MojiRecepti:
                        MenuPages.Add(id, new NavigationPage(new Posjetilac.MojiRecepti()));
                        break;
                    case (int)MenuItemType.MojiFavoriti:
                        MenuPages.Add(id, new NavigationPage(new FavoritiPage()));
                        break;
                    case (int)MenuItemType.Članci:
                        MenuPages.Add(id, new NavigationPage(new Posjetilac.ClanakPage()));
                        break;
                    case (int)MenuItemType.Dokumenti:
                        MenuPages.Add(id, new NavigationPage(new Posjetilac.DokumentPage()));
                        break;
                    case (int)MenuItemType.Obavijesti:
                        MenuPages.Add(id, new NavigationPage(new Posjetilac.PrikazNotifikacija()));
                        break;
                    case (int)MenuItemType.SistemPreporuke:
                        MenuPages.Add(id, new NavigationPage(new Posjetilac.SistemPreporuke()));
                        break;
                    case (int)MenuItemType.UrediProfil:
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
                        MenuPages.Add(id, new NavigationPage(new UrediProfilPage(korisnik)));
                        break;
                    case (int)MenuItemType.Odjava:
                        MenuPages.Add(id, new NavigationPage(new LoginPage()));
                        break;
                  
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}