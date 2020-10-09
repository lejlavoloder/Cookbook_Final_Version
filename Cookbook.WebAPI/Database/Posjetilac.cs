using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookbook.WebAPI.Database
{
    public partial class Posjetilac
    {
        public Posjetilac()
        {
            Ocjena = new HashSet<Ocjena>();
        }
        public int PosjetilacId { get; set; }
        public DateTime DatumRegistracije { get; set; }
        public int KorisnikId { get; set; }
        public Korisnik Korisnik { get; set; }
        public ICollection<Ocjena> Ocjena { get; set; }
    }
}
