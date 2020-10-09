using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.Model.Requests
{
 public class ReceptSearchRequest
    {
     
        public string Naziv { get; set; }
        public int? KategorijaId { get; set; }
        public int? GrupaJelaId { get; set; }
        public int? SlozenostId { get; set; }
      
    }
}
