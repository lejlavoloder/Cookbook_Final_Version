using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookbook.WebAPI.Database
{
    public class Ocjena
    {
        public int OcjenaId { get; set; }
        public double ocjena { get; set; }
        public int ReceptId { get; set; }
        public Recept Recept { get; set; }
        public int PosjetilacId { get; set; }
        public Posjetilac Posjetilac { get; set; }
    }
}
