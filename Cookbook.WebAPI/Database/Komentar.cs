using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookbook.WebAPI.Database
{
    public partial class Komentar
    {
        public int KomentarId { get; set; }
        public string Sadrzaj { get; set; }
        public DateTime Datum { get; set; }
        public bool Odobreno { get; set; }
        public int ReceptId { get; set; }
        public Recept Recept { get; set; }
        public int KorisnikId { get; set; }
        public Korisnik Korisnik { get; set; }
    }
}
