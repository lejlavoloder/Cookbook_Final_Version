using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Cookbook.Model.Requests;
using Cookbook.WebAPI.Services;
namespace Cookbook.WebAPI.Controllers
{

    public class GrupaJelaController : BaseCRUDController<Model.GrupaJela,GrupaJelaSearchRequest,GrupaJelaUpsertRequest,GrupaJelaUpsertRequest>
    {
        public GrupaJelaController(ICRUDService<Model.GrupaJela,GrupaJelaSearchRequest,GrupaJelaUpsertRequest,GrupaJelaUpsertRequest>service)
            :base(service)
        {

        }
    }
}