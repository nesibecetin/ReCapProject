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
                Console.WriteLine("Marka eklendi.");
            }
            else
                Console.WriteLine("Daha uzun marka giriniz.");
        }

        public void Delete(Brand brand)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
