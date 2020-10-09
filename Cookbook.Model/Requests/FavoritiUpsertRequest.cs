using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.Model.Requests
{
   public class FavoritiUpsertRequest
    { 
        public int KorisnikId { get; set; }
        public int ReceptId { get; set; }
    }
}
