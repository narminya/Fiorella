using Fiorella.Areas.Admin.Constants;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.Areas.Admin.Utils
{
    public static class FileUtils
    {

        public static string FileCreate(IFormFile file) {


            string path = Path.Combine(FileConstants.ImagePath, Guid.NewGuid() + file.FileName);
            FileStream fs = new FileStream(path, FileMode.Create);
            file.CopyTo(fs);
            fs.Close();
            return file.FileName;
        }

        public static void FileDelete(string path)
        {
        
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }


    }
}
