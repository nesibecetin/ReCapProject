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
        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter=null)
        {
            using (ReCapProjectContext context=new ReCapProjectContext())
            {
                var result = from c in filter == null ? context.Cars : context.Set<Car>().Where(filter)
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             select new CarDetailDto()
                             {CarId=c.CarId,
                             Description=c.Description,
                             CarName=c.CarName,
                             BrandName=b.BrandName,
                             ColorName=co.ColorName,
                             DailyPrice= (int)c.DailyPrice,
                             ImagePath = context.CarImages.Where(x => x.CarId == c.CarId).FirstOrDefault().ImagePath
                             };
                  
                return result.ToList();

            }

          
        }
    }
}
