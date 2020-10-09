using AutoMapper;
using Cookbook.Model.Requests;
using Cookbook.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookbook.WebAPI.Services
{
    public class NotifikacijaService:BaseCRUDService<Model.Notifikacija, NotifikacijaSearchRequest,Database.Notifikacija, NotifikacijaUpsertRequest, NotifikacijaUpsertRequest>
    {
        public NotifikacijaService(CookbookContext context, IMapper mapper):base(context,mapper) { 
        }
    }
}
