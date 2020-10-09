using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookbook.WebAPI.Database
{
    public partial class MjernaJedinica
    {
        public MjernaJedinica()
        {
            ReceptSastojak = new HashSet<ReceptSastojak>();
        }
        public int MjernaJedinicaId { get; set; }
        public string Naziv { get; set; }
        public ICollection<ReceptSastojak> ReceptSastojak { get; set; }
    }
}
