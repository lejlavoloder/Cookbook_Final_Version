using AutoMapper;
using Cookbook.Model.Requests;
using Cookbook.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookbook.WebAPI.Services
{
    public class MjernaKolicinaService:BaseCRUDService<Model.MjernaKolicina,MjernaKolicinaSearchRequest, Database.MjernaKolicina,MjernaKolicinaUpsertRequest,MjernaKolicinaUpsertRequest>
    {
      public MjernaKolicinaService(CookbookContext _db, IMapper mapper):base(_db, mapper)
        {

        }
        public override List<Model.MjernaKolicina> Get(MjernaKolicinaSearchRequest search)
        {
            var query = _context.MjernaKolicina.AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Kolicina))
            {
                query = query.Where(n =>n.Kolicina==double.Parse(search.Kolicina));
            }
            query = query.OrderBy(n=>n.Kolicina);
            var list = query.ToList();
            return _mapper.Map<List<Model.MjernaKolicina>>(list);
        }
    }
}
