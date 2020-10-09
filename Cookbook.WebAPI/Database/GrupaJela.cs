using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookbook.WebAPI.Database
{
    public partial class GrupaJela
    {
        public GrupaJela()
        {
            Recept = new HashSet<Recept>();
        }
        public int GrupaJelaId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public ICollection<Recept> Recept { get; set; }
    }
}
