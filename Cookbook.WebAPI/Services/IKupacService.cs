using Cookbook.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookbook.WebAPI.Services
{
  public  interface IKupacService
    {
        List<Model.Posjetilac> Get(PosjetilacSearchRequest request);

        Model.Posjetilac GetById(int id);

        Model.Posjetilac Insert(PosjetilacUpsertRequest request);

        Model.Posjetilac Update(int id, PosjetilacUpsertRequest request);

  
    }
}
