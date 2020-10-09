using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.Model
{
  public class Notifikacija
    {
        public int NotifikacijaId { get; set; }
        public int ReceptId { get; set; }
        public string Sadrzaj { get; set; }
        public string Recept { get; set; }
        public DateTime DatumSlanja { get; set; }
        public bool IsProcitano { get; set; }
    }
}
