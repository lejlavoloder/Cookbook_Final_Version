using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.Model.Requests
{
  public  class ClanakSearchRequest
    {
        public int? VrstaClankaId { get; set; }
        public string Naziv { get; set; }
    }
}
