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

    public class KategorijaController :
        BaseCRUDController<Model.Kategorija,KategorijaSearchRequest,KategorijaInsertRequest,KategorijaInsertRequest>
    {
        public KategorijaController(ICRUDService<Model.Kategorija,KategorijaSearchRequest,KategorijaInsertRequest,KategorijaInsertRequest>service)
            :base(service)
        {

        }
    }
}