using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cookbook.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cookbook.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PreporukaController : ControllerBase
    {
        private readonly IPreporukaService _service;
        public PreporukaController(IPreporukaService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public List<Model.Recept>Get(int id)
        {
            return _service.GetPreporuka(id);
        }
    }
}
