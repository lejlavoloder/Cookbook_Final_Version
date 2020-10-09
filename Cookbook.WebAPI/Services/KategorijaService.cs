using AutoMapper;
using Cookbook.Model.Requests;
using Cookbook.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookbook.WebAPI.Services
{
    public class KategorijaService:BaseCRUDService<Model.Kategorija,KategorijaSearchRequest,Database.Kategorija,KategorijaInsertRequest,KategorijaInsertRequest>
    {
        public KategorijaService(CookbookContext db, IMapper mapper ):base(db,mapper)
        {

        }
        public override List<Model.Kategorija> Get(KategorijaSearchRequest search)
        {
            var query = _context.Kategorija.AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                query = query.Where(n => n.Naziv.ToLower().StartsWith(search.Naziv) || n.Naziv.ToUpper().StartsWith(search.Naziv));
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.Kategorija>>(list);
        }
    }
}
