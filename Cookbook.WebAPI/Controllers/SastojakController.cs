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

    public class SastojakController :
        BaseCRUDController<Model.Sastojak, SastojakSearchRequest, SastojakInsertRequest, SastojakInsertRequest>
    {
        public SastojakController(ICRUDService<Model.Sastojak, SastojakSearchRequest, SastojakInsertRequest, SastojakInsertRequest> service)
          : base(service)
        {
        }

    }
}