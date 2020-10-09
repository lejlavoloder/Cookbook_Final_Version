using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.Model
{
    public class Ocjena
    {
        public int OcjenaId { get; set; }
        public decimal ocjena { get; set; }
        public int ReceptId { get; set; }
        public string Recept { get; set; }
        public int PosjetilacId { get; set; }
        public string Posjetilac { get; set; }
    }
}
