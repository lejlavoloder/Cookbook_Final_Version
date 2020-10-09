using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cookbook.Model.Requests;
using Cookbook.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cookbook.WebAPI.Controllers
{
    [Route("api/[controller]")]

    [ApiController]
    public class NotifikacijaController : BaseCRUDController<Model.Notifikacija, NotifikacijaSearchRequest, NotifikacijaUpsertRequest, NotifikacijaUpsertRequest>
    {
        public NotifikacijaController(ICRUDService<Model.Notifikacija, NotifikacijaSearchRequest, NotifikacijaUpsertRequest, NotifikacijaUpsertRequest> service) : base(service){
    
    
    }
    }
}
