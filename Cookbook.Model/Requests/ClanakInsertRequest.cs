using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cookbook.Model.Requests
{
    public class ClanakInsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string Naziv { get; set; }
        public string Tekst { get; set; }
        public DateTime DatumObjave { get; set; }
        public int VrstaClankaId { get; set; }
        public int KorisnikId { get; set; }
    }
}
