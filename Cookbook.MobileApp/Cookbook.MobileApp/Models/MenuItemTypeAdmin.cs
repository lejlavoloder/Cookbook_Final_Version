using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.MobileApp.Models
{
   public enum MenuItemTypeAdmin
    {
       Administracija,
        Recept,
       Naslovna,
        Komentar,
        VrstaClanka,
        Članak,
        Odjava,
        UpravljanjeReceptima,
        PrikazRegistrovanihPosjetilaca,
        UrediProfil,
       MojiFavoriti
    }
    public class HomeMenuItemAdmin
    {
        public MenuItemTypeAdmin Id { get; set; }
        public string Title { get; set; }
    }
}
