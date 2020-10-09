﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cookbook.Model.Requests;
using Cookbook.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cookbook.WebAPI.Controllers
{
  
    public class SlozenostController :BaseCRUDController<Model.Slozenost,SlozenostSearchRequest,SlozenostUpsertRequest,SlozenostUpsertRequest>
    {
        public SlozenostController(ICRUDService<Model.Slozenost, SlozenostSearchRequest, SlozenostUpsertRequest, SlozenostUpsertRequest> service)
            : base(service)
        {

        }
    }
}