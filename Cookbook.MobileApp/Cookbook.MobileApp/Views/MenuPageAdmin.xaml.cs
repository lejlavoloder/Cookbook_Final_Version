using Cookbook.MobileApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cookbook.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPageAdmin : ContentPage
    {
        MainPageAdmin RootPage { get => Application.Current.MainPage as MainPageAdmin; }
        List<HomeMenuItemAdmin> menuItems;
        public MenuPageAdmin()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItemAdmin>
            {
                 new HomeMenuItemAdmin { Id = MenuItemTypeAdmin.Naslovna, Title = "Početna" },
                new HomeMenuItemAdmin { Id = MenuItemTypeAdmin.Administracija, Title = "Administracija" },
                new HomeMenuItemAdmin{Id=       MenuItemTypeAdmin.Recept, Title="Recept"},      
                new HomeMenuItemAdmin{Id= MenuItemTypeAdmin.UpravljanjeReceptima, Title="Upravljanje receptima"}, 
                new HomeMenuItemAdmin{  Id  =  MenuItemTypeAdmin.Članak, Title="Članak"},
                new HomeMenuItemAdmin{Id=      MenuItemTypeAdmin.MojiFavoriti, Title="Moji favoriti"},
                new HomeMenuItemAdmin{Id=       MenuItemTypeAdmin.Komentar, Title="Upravljanje komentarima"},
                new HomeMenuItemAdmin{Id=  MenuItemTypeAdmin.PrikazRegistrovanihPosjetilaca, Title="Registrovani posjetioci"},
                new HomeMenuItemAdmin{Id=      MenuItemTypeAdmin.UrediProfil, Title="Uredi profil"},
                new HomeMenuItemAdmin{  Id  =  MenuItemTypeAdmin.Odjava, Title="Odjava"},
            };
            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItemAdmin)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}