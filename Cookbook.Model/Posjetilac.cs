using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.Model
{
   public class Posjetilac
    {
        public int PosjetilacId { get; set; }
        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public int BrojObjavljenihRecepata { get; set; }

    }
}
