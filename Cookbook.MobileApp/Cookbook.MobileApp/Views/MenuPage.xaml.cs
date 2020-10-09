using Cookbook.MobileApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cookbook.MobileApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { 
            get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {   new HomeMenuItem {Id = MenuItemType.Naslovna, Title="Početna" },
                new HomeMenuItem{Id=MenuItemType.Recepti, Title="Recepti"},     
                new HomeMenuItem{Id=MenuItemType.MojiRecepti, Title="Moji recepti"},
                new HomeMenuItem{Id=MenuItemType.MojiFavoriti, Title="Moji favoriti"},
                new HomeMenuItem{Id=MenuItemType.Članci, Title="Članci"},
                new HomeMenuItem{Id=MenuItemType.Dokumenti, Title="Dokumenti"},
                new HomeMenuItem{Id=MenuItemType.Obavijesti, Title="Obavijesti"},
                new HomeMenuItem{Id=MenuItemType.SistemPreporuke, Title="Sistem preporuke"},         
                new HomeMenuItem {Id = MenuItemType.UrediProfil, Title="Uredi profil" },
                new HomeMenuItem {Id = MenuItemType.Odjava, Title="Odjava" }
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}