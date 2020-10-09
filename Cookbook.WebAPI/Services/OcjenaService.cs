using AutoMapper;
using Cookbook.Model.Requests;
using Cookbook.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookbook.WebAPI.Services
{
    public class OcjenaService:BaseCRUDService<Model.Ocjena, OcjenaSearchRequest,Database.Ocjena,OcjenaUpsertRequest, OcjenaUpsertRequest>
    {
        public OcjenaService(CookbookContext db, IMapper mapper):base(db, mapper)
        {

        }
        public override List<Model.Ocjena> Get(OcjenaSearchRequest search)
        {
            var q = _context.Set<Database.Ocjena>().AsQueryable();

            if (search?.ReceptId.HasValue == true && search?.PosjetilacId.HasValue == true)
            {
                q = q.Where(s => s.Recept.ReceptId == search.ReceptId && s.Posjetilac.PosjetilacId==search.PosjetilacId);
            }
          
            var list = q.ToList();
            return _mapper.Map<List<Model.Ocjena>>(list);
        }
    }
}
