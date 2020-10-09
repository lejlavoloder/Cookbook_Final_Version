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

    public class MjernaJedinicaController :
        BaseCRUDController<Model.MjernaJedinica, MjernaJedinicaSearchRequest, MjernaJedinicaInsertRequest, MjernaJedinicaInsertRequest>
    {
        public MjernaJedinicaController(ICRUDService<Model.MjernaJedinica, MjernaJedinicaSearchRequest, MjernaJedinicaInsertRequest, MjernaJedinicaInsertRequest> service)
          : base(service)
        {
        }

    }
}