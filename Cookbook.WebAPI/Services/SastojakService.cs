using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Cookbook.Model;
using Cookbook.WebAPI.Database;
using Cookbook.Model.Requests;
namespace Cookbook.WebAPI.Services
{
    public class SastojakService :
        BaseCRUDService<Model.Sastojak, SastojakSearchRequest, Database.Sastojak, SastojakInsertRequest, SastojakInsertRequest>
    {
        public SastojakService(CookbookContext context, IMapper mapper) : base(context, mapper)
        {

        }
        public override List<Model.Sastojak> Get(SastojakSearchRequest search)
        {
            var query = _context.Sastojak.AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                query = query.Where(n => n.Naziv.ToLower().StartsWith(search.Naziv) || n.Naziv.ToUpper().StartsWith(search.Naziv));
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.Sastojak>>(list);
        }
    }
}