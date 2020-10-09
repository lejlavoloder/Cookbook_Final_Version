using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookbook.WebAPI.Database
{
    public partial class MjernaKolicina
    {
        public MjernaKolicina()
        {
            ReceptSastojak = new HashSet<ReceptSastojak>();
        }
        public int MjernaKolicinaId { get; set; }
        public double Kolicina { get; set; }
        public ICollection<ReceptSastojak> ReceptSastojak { get; set; }
    }
}
