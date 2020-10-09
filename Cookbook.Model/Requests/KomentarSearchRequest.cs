using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.Model.Requests
{
  public class KomentarSearchRequest
    {
        public int? ReceptId { get; set; }
        public int? KorisnikId { get; set; }
        public string Naziv { get; set; }
    }
}
