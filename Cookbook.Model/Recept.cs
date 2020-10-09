using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.Model
{
   public class Recept
    {
        public int ReceptId { get; set; }
        public string Naziv { get; set; }
        public double VrijemePripreme { get; set; }
        public double VrijemeKuhanja { get; set; }
        public int BrojLjudi { get; set; }
        public string Tekst { get; set; }
        public int KorisnikId { get; set; }
        public string Korisnik { get; set; }
        public int KategorijaId { get; set; }
        public string Kategorija { get; set; }
        public int GrupaJelaId { get; set; }
        public string GrupaJela { get; set; }
        public int SlozenostId { get; set; }
        public string Slozenost { get; set; }
        public DateTime DatumObjave { get; set; }
        public byte[] Slika { get; set; }
        public bool Odobren { get; set; }
        public bool NijeOdobreno { get => !Odobren; }
        public decimal Ocjena { get; set; }
    }
}
