using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookbook.WebAPI.Database
{
    public partial class Clanak
    {
        public int ClanakId { get; set; }
        public string Naziv { get; set; }
        public string Tekst { get; set; }
        public DateTime DatumObjave { get; set; }
        public int VrstaClankaId { get; set; }
        public VrstaClanka VrstaClanka { get; set; }
        public int KorisnikId { get; set; }
        public Korisnik Korisnik { get; set; }
    }
}
