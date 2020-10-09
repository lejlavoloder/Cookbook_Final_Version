using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.Model
{
  public class Dokument
    {
        public int DokumentId { get; set; }
        public string NazivDokumenta { get; set; }
        public int KorisnikId { get; set; }
        public byte[] Sadrzaj { get; set; }
        public string FileName { get; set; }
    }
}
