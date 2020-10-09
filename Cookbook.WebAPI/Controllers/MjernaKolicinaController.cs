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
  
    public class MjernaKolicinaController : BaseCRUDController<Model.MjernaKolicina, MjernaKolicinaSearchRequest, MjernaKolicinaUpsertRequest, MjernaKolicinaUpsertRequest>
    {
        public MjernaKolicinaController(ICRUDService<Model.MjernaKolicina, MjernaKolicinaSearchRequest, MjernaKolicinaUpsertRequest, MjernaKolicinaUpsertRequest> service)
            : base(service)
        {

        }
    }
}