using AutoMapper;
using Cookbook.Model.Requests;
using Cookbook.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookbook.WebAPI.Services
{
    public class ReceptService : BaseCRUDService<Model.Recept, ReceptSearchRequest, Database.Recept, ReceptUpsertRequest, ReceptUpsertRequest>
    {
        public ReceptService(CookbookContext db, IMapper mapper) : base(db, mapper)
        {

        }
        public override List<Model.Recept> Get(ReceptSearchRequest search)
        {
            var q = _context.Set<Database.Recept>().AsQueryable()
                .Where(x => search == null || ((search.SlozenostId == null || x.SlozenostId == search.SlozenostId) &&
               (search.KategorijaId == null || search.KategorijaId == x.KategorijaId) &&
               (search.GrupaJelaId == null || search.GrupaJelaId == x.GrupaJelaId))); ;
            
            var list = q.ToList();
            var list1 = _mapper.Map<List<Model.Recept>>(list);
       
            foreach(var ocjena in list1)
            {
                ocjena.Ocjena = Math.Round(_context.Ocjena.Where(b => b.ReceptId == ocjena.ReceptId)
                    .Average(x => (decimal?)x.ocjena) ?? new decimal(0),2); 
           
            }
            return list1;
        }

    }

}
