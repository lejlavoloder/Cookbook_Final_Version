using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.Model
{
   public class Komentar
    {
        public int KomentarId { get; set; }
        public string Sadrzaj { get; set; }
        public DateTime Datum { get; set; }
        public bool Odobreno { get; set; }
        public int KorisnikId { get; set; }
        public int ReceptId { get; set; }
        public bool NijeOdobreno { get => !Odobreno; }
        public string NazivRecepta { get; set; }
        public string Posjetioc { get; set; }

    }
}
