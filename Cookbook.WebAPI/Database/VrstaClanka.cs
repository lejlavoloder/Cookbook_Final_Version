using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookbook.WebAPI.Database
{
    public partial class VrstaClanka
    {
        public VrstaClanka()
        {
            Clanak = new HashSet<Clanak>();
        }
        public int VrstaClankaId { get; set; }
        public string Naziv { get; set; }
        public ICollection<Clanak> Clanak { get; set; }
    }
}
