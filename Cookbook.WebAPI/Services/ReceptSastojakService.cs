using AutoMapper;
using Cookbook.Model.Requests;
using Cookbook.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookbook.WebAPI.Services
{
    public class ReceptSastojakService:BaseCRUDService<Model.ReceptSastojak,ReceptSastojakSearchRequest,Database.ReceptSastojak,
        ReceptSastojakUpsertRequest,ReceptSastojakUpsertRequest>
    {
      public ReceptSastojakService(CookbookContext db, IMapper mapper):base(db,mapper) { }
        public override List<Model.ReceptSastojak> Get(ReceptSastojakSearchRequest search)
        {
            var q = _context.Set<Database.ReceptSastojak>().AsQueryable();

            if (search?.ReceptId.HasValue == true)
            {
                q = q.Where(s => s.Recept.ReceptId == search.ReceptId);
            }
            if (search?.SastojakId.HasValue == true)
            {
                q = q.Where(s => s.Sastojak.SastojakId == search.SastojakId);
            }

            var list = q.ToList();
            return _mapper.Map<List<Model.ReceptSastojak>>(list);
        }
   
    }
}
