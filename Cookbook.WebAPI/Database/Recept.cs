using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookbook.WebAPI.Database
{
    public partial class Recept
    {
        public Recept()
        {
            ReceptSastojak = new HashSet<ReceptSastojak>();
            Komentar = new HashSet<Komentar>();
            Ocjena = new HashSet<Ocjena>();
            Notifikacija = new HashSet<Notifikacija>();
            Favoriti = new HashSet<Favoriti>();
        }
        public int ReceptId { get; set; }
        public string Naziv { get; set; }
        public double VrijemePripreme { get; set; }
        public double VrijemeKuhanja { get; set; }
        public int BrojLjudi{ get; set; }
        public string Tekst { get; set; }
        public int KorisnikId { get; set; }
        public Korisnik Korisnik { get; set; }
        public int KategorijaId { get; set; }
        public Kategorija Kategorija { get; set; }
        public int GrupaJelaId { get; set; }
        public GrupaJela GrupaJela { get; set; }
        public int SlozenostId { get; set; }
        public Slozenost Slozenost { get; set; }
        public DateTime DatumObjave { get; set; }
        public byte[] Slika { get; set; }
        public bool Odobren { get; set; }
        public ICollection <ReceptSastojak> ReceptSastojak { get; set; }
        public ICollection<Komentar> Komentar { get; set; }
        public ICollection<Ocjena> Ocjena { get; set; }
        public ICollection<Notifikacija> Notifikacija { get; set; }
        public ICollection<Favoriti> Favoriti { get; set; }
    }
}
