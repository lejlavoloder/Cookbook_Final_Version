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
    public class PosjetilacController : ControllerBase
    {
        private readonly IKupacService _service;

        public PosjetilacController(IKupacService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Posjetilac> Get([FromQuery]PosjetilacSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpPost]
        public Model.Posjetilac Insert(PosjetilacUpsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public Model.Posjetilac Update(int id, [FromBody]PosjetilacUpsertRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Model.Posjetilac GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}
