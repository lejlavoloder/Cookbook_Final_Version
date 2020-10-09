using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookbook.WebAPI.Database
{
    public partial class Korisnik
    {
        public Korisnik()
        {
            KorisnikUloga = new HashSet<KorisnikUloga>();
            Clanak = new HashSet<Clanak>();
            Posjetilac = new HashSet<Posjetilac>();
            Recept = new HashSet<Recept>();
            Favoriti = new HashSet<Favoriti>();
            Komentar = new HashSet<Komentar>();
            Dokument = new HashSet<Dokument>();
        }
        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }

        public ICollection<KorisnikUloga> KorisnikUloga { get; set; }
        public ICollection<Clanak> Clanak { get; set; }
        public ICollection<Posjetilac> Posjetilac { get; set; }
        public ICollection<Recept> Recept { get; set; }
        public ICollection<Favoriti> Favoriti { get; set; }
        public ICollection<Komentar> Komentar { get; set; }
        public ICollection<Dokument> Dokument { get; set; }
    }
}
