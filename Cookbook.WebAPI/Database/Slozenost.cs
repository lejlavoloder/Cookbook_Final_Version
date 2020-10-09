using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookbook.WebAPI.Database
{
    public partial class Slozenost
    {
        public Slozenost()
        {
            Recept = new HashSet<Recept>();
        }
        public int SlozenostId { get; set; }
        public string Naziv{ get; set; }
        public string Opis { get; set; }
        public ICollection<Recept> Recept { get; set; }
    }
}
