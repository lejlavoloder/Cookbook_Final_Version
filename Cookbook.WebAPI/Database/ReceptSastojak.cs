using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookbook.WebAPI.Database
{
    public partial class ReceptSastojak
    {
        public int ReceptSastojakId { get; set; }
        public int ReceptId { get; set; }
        public Recept Recept { get; set; }
        public int SastojakId { get; set; }
        public Sastojak Sastojak { get; set; }
        public int MjernaJedinicaId { get; set; }
        public MjernaJedinica MjernaJedinica { get; set; }
        public int MjernaKolicinaId { get; set; }
        public MjernaKolicina MjernaKolicina { get; set; }
    }
}
