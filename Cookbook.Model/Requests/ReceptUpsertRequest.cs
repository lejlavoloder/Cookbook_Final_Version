using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.Model.Requests
{
 public class ReceptUpsertRequest
    {
       // public int ReceptId { get; set; }
        public string Naziv { get; set; }
        public double VrijemePripreme { get; set; }
        public double VrijemeKuhanja { get; set; }
        public int BrojLjudi { get; set; }
        public string Tekst { get; set; }
        public int KorisnikId { get; set; }
        public int KategorijaId { get; set; }
        public int GrupaJelaId { get; set; }
        public int SlozenostId { get; set; }
        public DateTime DatumObjave { get; set; }
        public byte[] Slika { get; set; }
        public bool Odobren { get; set; }
    }
}
