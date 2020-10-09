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
    
    public class VrstaClankaController : BaseCRUDController<Model.VrstaClanka,VrstaClankaSearchRequest,VrstaClankaInsertRequest,VrstaClankaInsertRequest>
    {
        public VrstaClankaController(ICRUDService<Model.VrstaClanka, VrstaClankaSearchRequest, VrstaClankaInsertRequest, VrstaClankaInsertRequest> service)
       :base(service) {

        }
    }
}