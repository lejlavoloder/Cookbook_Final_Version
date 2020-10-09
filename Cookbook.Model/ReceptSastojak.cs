using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.Model
{
  public class ReceptSastojak
    {
        public int ReceptSastojakId { get; set; }
        public int ReceptId { get; set; }
        public string Recept { get; set; }
        public int SastojakId { get; set; }  
        public string Sastojak { get; set; }
        public int MjernaJedinicaId { get; set; }   
        public string MjernaJedinica { get; set; }
        public int MjernaKolicinaId { get; set; }
        public double MjernaKolicina { get; set; }
        
    }
}
