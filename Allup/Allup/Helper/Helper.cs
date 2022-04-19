using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.Helper
{
    public class Helper
    {
        public static void DeleteFile(string filename, IWebHostEnvironment env, params string[] folders) {

            string path = env.WebRootPath;

            foreach (var folder in folders)
            {
                path = Path.Combine(path, folder);
            }

            path = Path.Combine(path, filename);

            if (File.Exists(path)) {

                File.Delete(path);
            }
        }
    }
}
