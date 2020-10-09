using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.Model
{
  public  class Favoriti
    {
        public int FavoritiId { get; set; }
        public int KorisnikId { get; set; }
        public int ReceptId { get; set; }
        public string Recept { get; set; }
    }
}
