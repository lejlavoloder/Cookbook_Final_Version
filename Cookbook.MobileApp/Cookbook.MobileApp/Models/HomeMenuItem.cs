using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.MobileApp.Models
{
    public enum MenuItemType
    {
        UrediProfil,
        MojiFavoriti,
        Naslovna,
        Recepti,
        Članci,
        Dokumenti,
        Obavijesti,
        MojiRecepti,
        SistemPreporuke,
        Odjava
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
