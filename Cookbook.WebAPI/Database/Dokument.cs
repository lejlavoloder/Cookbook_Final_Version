using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookbook.WebAPI.Database
{
    public partial class Dokument
    {
        public int DokumentId { get; set; }
        public string NazivDokumenta { get; set; }
        public int KorisnikId { get; set; }
        public Korisnik Korisnik { get; set; }
        public byte[] Sadrzaj { get; set; }
        public string FileName { get; set; }
    }
}
