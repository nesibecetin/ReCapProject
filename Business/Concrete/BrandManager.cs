using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager:IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            if (brand.BrandName.Length > 2)
            {
                _brandDal.Add(brand);
                Console.WriteLine(brand.BrandName+" Marka eklendi.");
            }
            else
                Console.WriteLine("Daha uzun marka giriniz.");
        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            Console.WriteLine(brand.BrandName+" Marka Silindi.");
        }

        public List<Brand> GetAll()
        {

            return _brandDal.GetAll();

        }

      
        public Brand GetById(int id)
        {
            return _brandDal.Get(b => b.BrandId == id);
        }

        public void Update(Brand brand)
        {
            _brandDal.Update(brand);
        }
    }
}
