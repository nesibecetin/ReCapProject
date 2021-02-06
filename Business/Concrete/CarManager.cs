using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if(car.DailyPrice>0){
             _carDal.Add(car);
                Console.WriteLine("Araç eklendi.");
            }
            else
                Console.WriteLine("Günlük fiyat giriniz.");
        }

        public void Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
          
            return _carDal.GetAll();           
            
        }

        public List<Car> GetAllById(int id)
        {
            return _carDal.GetAll(c => c.CarId == id);
        }


        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
