using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utilities.FileHelper
{
    public class FileHelper
    {
        public static string Add(IFormFile formFile)
        {
            var result = newPath(formFile);
               
            try
            {
               
                if (formFile.Length > 0)
                {
                    using (var stream = new FileStream(result.newPath, FileMode.Create))
                    {
                        formFile.CopyTo(stream);
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }

            
            
            return result.path2;
          
            
        }
        public static string Update(string sourcepath, IFormFile formFile)
        {
            var result = newPath(formFile);
            if (formFile.Length > 0)
            {
                using (Stream stream = new FileStream(result.newPath, FileMode.Create))
                {
                    formFile.CopyTo(stream);
                }
            }
            File.Delete(sourcepath);
            return result.path2;
        }
        public static void Delete(string path)
        {
            
             File.Delete(path);
       
        }
        public static (string newPath,string path2 ) newPath(IFormFile formFile)
        {
           
            string path = Environment.CurrentDirectory + @"\wwwroot\Images";
            var newPath = Guid.NewGuid().ToString() + "_" + Path.GetExtension(formFile.FileName);

            string result = $@"{path}\{newPath}";
            return (result, newPath);

        }
    }
}
