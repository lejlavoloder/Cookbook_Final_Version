using Cookbook.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookbook.WebAPI.Services
{
   public interface IPreporukaService
    {
        List<Recept> GetPreporuka(int id);
    }
}
