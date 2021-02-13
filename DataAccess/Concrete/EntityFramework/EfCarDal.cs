using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities;
using Entities.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapProjectContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapProjectContext context=new ReCapProjectContext())
            {
                var result = from c in context.Cars
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             select new CarDetailDto()
                             { CarName=c.CarName,
                             BrandName=b.BrandName,
                             ColorName=co.ColorName,
                             DailyPrice= (int)c.DailyPrice,                             
                             };
                  
                return result.ToList();

            }
        }
    }
}
