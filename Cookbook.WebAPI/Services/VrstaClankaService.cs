using AutoMapper;
using Cookbook.Model.Requests;
using Cookbook.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookbook.WebAPI.Services
{
    public class VrstaClankaService:
        BaseCRUDService<Model.VrstaClanka,VrstaClankaSearchRequest,Database.VrstaClanka,VrstaClankaInsertRequest,VrstaClankaInsertRequest>
    {
      public  VrstaClankaService(CookbookContext db, IMapper mapper)
            :base(db,mapper)
        {

        }
        public override List<Model.VrstaClanka> Get(VrstaClankaSearchRequest search)
        {
            var query = _context.VrstaClanka.AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                query = query.Where(n => n.Naziv.ToLower().StartsWith(search.Naziv) || n.Naziv.ToUpper().StartsWith(search.Naziv));
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.VrstaClanka>>(list);
        }
    }
}
