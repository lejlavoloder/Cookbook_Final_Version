using AutoMapper;
using Cookbook.Model.Requests;
using Cookbook.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookbook.WebAPI.Services
{
    public class FavoritiService:BaseCRUDService<Model.Favoriti,FavoritiSearchRequest,Database.Favoriti,FavoritiUpsertRequest,FavoritiUpsertRequest>
    {
        public FavoritiService(CookbookContext db, IMapper mapper):base(db,mapper)
        {

        }
        public override List<Model.Favoriti> Get(FavoritiSearchRequest search)
        {
            var query = _context.Favoriti.AsQueryable();


            if (!string.IsNullOrWhiteSpace(search?.Recept))
            {
                query = query.Where(n => n.Recept.Naziv.ToLower().StartsWith(search.Recept) || 
                n.Recept.Naziv.ToUpper().StartsWith(search.Recept));
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.Favoriti>>(list);
        }

    }
}
