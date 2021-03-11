﻿using Microsoft.AspNetCore.Http;
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
            string sourcepath = Path.Combine(Directory.GetCurrentDirectory(), formFile.FileName);
            try
            {
                if (formFile.Length > 0)
                {
                    using (Stream stream = new FileStream(sourcepath, FileMode.Create))
                    {
                        formFile.CopyTo(stream);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            var result = newPath(formFile);
            File.Move(sourcepath, result);
            return result;
          
            
        }
        public static string Update(string sourcepath, IFormFile formFile)
        {
            var result = newPath(formFile);
            if (formFile.Length > 0)
            {
                using (Stream stream = new FileStream(result, FileMode.Create))
                {
                    formFile.CopyTo(stream);
                }
            }
            File.Delete(sourcepath);
            return result;
        }
        public static void Delete(string path)
        {
            
             File.Delete(path);
       
        }
        public static string newPath(IFormFile formFile)
        {
           
            string path = Environment.CurrentDirectory + @"\wwwroot\Images";
            var newPath = Guid.NewGuid().ToString() + "_" + Path.GetExtension(formFile.FileName);

            string result = $@"{path}\{newPath}";
            return result;
        }
    }
}
