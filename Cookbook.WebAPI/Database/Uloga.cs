using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookbook.WebAPI.Database
{
    public partial class Uloga
    {
        public Uloga()
        {
            KorisnikUloga = new HashSet<KorisnikUloga>();
        }
        public int UlogaId { get; set; }
        public string Naziv { get; set; }

        public ICollection<KorisnikUloga> KorisnikUloga { get; set; }
    }
}
