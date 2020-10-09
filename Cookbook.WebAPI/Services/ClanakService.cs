using AutoMapper;
using Cookbook.Model.Requests;
using Cookbook.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookbook.WebAPI.Services
{
    public class ClanakService:BaseCRUDService<Model.Clanak,ClanakSearchRequest, Database.Clanak,ClanakInsertRequest,ClanakInsertRequest>
    {
        public ClanakService(CookbookContext db, IMapper mapper):base(db,mapper)
        {

        }
        public override List<Model.Clanak> Get(ClanakSearchRequest search)
        {
            var query = _context.Clanak.AsQueryable();
            if (!string.IsNullOrEmpty(search?.Naziv) && search?.VrstaClankaId.HasValue==true)
            {
                query = query.Where(s => s.Naziv.Equals(search.Naziv) && s.VrstaClankaId == search.VrstaClankaId);
            }
            else
            {
                    if (!string.IsNullOrEmpty(search?.Naziv))
                    {
                        query = query.Where(x => x.Naziv.ToLower().StartsWith(search.Naziv) || x.Naziv.ToUpper().StartsWith(search.Naziv));
                    }
                    if (search?.VrstaClankaId.HasValue == true)
                    {
                    query = query.Where(s => s.VrstaClanka.VrstaClankaId == search.VrstaClankaId);
                    }
                }
            var list = query.ToList();
            return _mapper.Map<List<Model.Clanak>>(list);
        }
    }
}
