using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.Model.Requests
{
   public class DokumentUpsertRequest
    {
        public string NazivDokumenta { get; set; }
        public int KorisnikId { get; set; }
        public byte[] Sadrzaj { get; set; }
        public string FileName { get; set; }
    }
}
