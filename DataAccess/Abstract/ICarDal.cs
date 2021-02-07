using Core.DataAccess;
using Entities;
using Entities.IDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
        List<CarDetailDto> GetCarDetails();
        
    }
}
