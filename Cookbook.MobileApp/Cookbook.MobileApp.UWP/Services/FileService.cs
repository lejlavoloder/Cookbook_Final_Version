using Cookbook.MobileApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookbook.MobileApp.UWP.Services
{
  public class FileService:IFileService
    {
        public string GetStorageFolderPath()
        {
            return Windows.Storage.ApplicationData.Current.LocalFolder.Path;
        }
    }
}
