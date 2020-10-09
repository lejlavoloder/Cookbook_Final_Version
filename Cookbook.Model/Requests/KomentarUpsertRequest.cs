using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.Model.Requests
{
   public class KomentarUpsertRequest
    {
        public string Sadrzaj { get; set; }
        public DateTime Datum { get; set; }
        public bool Odobreno { get; set; }
        public int KorisnikId { get; set; }
        public int ReceptId { get; set; }
    }
}
