using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.Model.Requests
{
  public  class NotifikacijaUpsertRequest
    {
        public int ReceptId { get; set; }
        public string Sadrzaj { get; set; }
        public DateTime DatumSlanja { get; set; }
        public bool IsProcitano { get; set; }

    }
}
