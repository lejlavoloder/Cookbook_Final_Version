using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookbook.WebAPI.Database
{
    public partial class Kategorija
    {
        public Kategorija()
        {
            Recept = new HashSet<Recept>();
        }
        public int KategorijaId { get; set; }
        public string Naziv { get; set; }
        public ICollection<Recept> Recept { get; set; }
    }
}
