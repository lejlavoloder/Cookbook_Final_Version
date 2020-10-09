using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookbook.WebAPI.Database
{
    public partial class Notifikacija
    {
        public int NotifikacijaId { get; set; }
        public int ReceptId { get; set; } 
        public Recept Recept { get; set; }
        public string Sadrzaj { get; set; }
        public DateTime DatumSlanja { get; set; }
        public bool IsProcitano { get; set; }

    }
}
