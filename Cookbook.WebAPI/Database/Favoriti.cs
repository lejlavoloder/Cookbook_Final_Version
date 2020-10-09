using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookbook.WebAPI.Database
{
    public partial class Favoriti
    {
        public int FavoritiId { get; set; }
        public int KorisnikId { get; set; }
        public Korisnik Korisnik { get; set; }
        public int ReceptId { get; set; }
        public Recept Recept { get; set; }
    }
}
