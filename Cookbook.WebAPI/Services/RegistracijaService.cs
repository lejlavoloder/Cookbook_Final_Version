using AutoMapper;
using Cookbook.Model.Requests;
using Cookbook.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookbook.WebAPI.Services
{
    public class RegistracijaService:BaseCRUDService<Model.Korisnik,KorisnikSearchRequest,Database.Korisnik,KorisniciInsertRequest,KorisniciInsertRequest>
    {
        public RegistracijaService(CookbookContext db, IMapper mapper):base(db,mapper)
        {

        } 
    }
}
