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
            _carDal.Add(car);
            Console.WriteLine("id'si "+car.CarId+" olan araba eklendi.");
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine(car.CarId + " Araba silindi.");
        }

        public List<Car> GetAll()
        {
            var mesaj = "arabalar listelendi";
            try
            {
                return _carDal.GetAll();
            }
            catch (Exception)
            {

                throw;
            }
                             
        }

        public Car GetById(int CarId)
        {
            return _carDal.GetById(CarId);
            Console.WriteLine(" Araba silindi.");
        }


        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
