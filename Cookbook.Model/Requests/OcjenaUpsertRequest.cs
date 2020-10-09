using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.Model.Requests
{
 public  class OcjenaUpsertRequest
    {
       public decimal ocjena { get; set; }
       public int PosjetilacId { get; set; }
       public int ReceptId { get; set; }
    }
}
