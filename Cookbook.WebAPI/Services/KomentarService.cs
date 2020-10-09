using AutoMapper;
using Cookbook.Model.Requests;
using Cookbook.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookbook.WebAPI.Services
{
    public class KomentarService :BaseCRUDService<Model.Komentar, KomentarSearchRequest, Database.Komentar, KomentarUpsertRequest, KomentarUpsertRequest>
    {
        public KomentarService(CookbookContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Komentar> Get(KomentarSearchRequest search)
        {
            var q = _context.Set<Database.Komentar>().AsQueryable();
            if (!string.IsNullOrEmpty(search?.Naziv) && search?.ReceptId.HasValue == true)
            {
                q = q.Where(s => s.Recept.Naziv.Equals(search.Naziv) && s.ReceptId == search.ReceptId);
            }
            else
            {
                if (!string.IsNullOrEmpty(search?.Naziv))
                {
                    q = q.Where(x => x.Recept.Naziv.ToLower().StartsWith(search.Naziv) || x.Recept.Naziv.ToUpper().StartsWith(search.Naziv));
                }
                if (search?.ReceptId.HasValue == true)
                {
                    q = q.Where(s => s.Recept.ReceptId == search.ReceptId);
                }
            }
            if (search?.KorisnikId.HasValue == true)
            {
                q = q.Where(s => s.Korisnik.KorisnikId == search.KorisnikId);
            }

            q = q.OrderBy(x => x.Recept.Naziv);
            var list = q.ToList();
            return _mapper.Map<List<Model.Komentar>>(list);
        }
    }
}
