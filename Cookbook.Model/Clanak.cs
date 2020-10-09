using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.Model
{
   public class Clanak
    {
        public int ClanakId { get; set; }
        public string Naziv { get; set; }
        public string Tekst { get; set; }
        public DateTime DatumObjave { get; set; }
        public int VrstaClankaId { get; set; }
        public string VrstaClanka { get; set; }
        public int KorisnikId { get; set; }
    }
}
