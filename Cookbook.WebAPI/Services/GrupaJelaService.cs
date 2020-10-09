using AutoMapper;
using Cookbook.Model.Requests;
using Cookbook.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookbook.WebAPI.Services
{
    public class GrupaJelaService:BaseCRUDService<Model.GrupaJela,GrupaJelaSearchRequest,Database.GrupaJela,
        GrupaJelaUpsertRequest,GrupaJelaUpsertRequest>
    {
        public GrupaJelaService(CookbookContext db, IMapper mapper):base(db, mapper)
        {
        }
        public override List<Model.GrupaJela> Get(GrupaJelaSearchRequest search)
        {
            var query = _context.GrupaJela.AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                query = query.Where(x => x.Naziv.ToLower().StartsWith(search.Naziv) || x.Naziv.ToUpper().StartsWith(search.Naziv));

            }

            var list = query.ToList();
            return _mapper.Map<List<Model.GrupaJela>>(list);
        }
    }
}
