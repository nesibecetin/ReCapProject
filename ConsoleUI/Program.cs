using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager((new EfBrandDal()));
            ColorManager colorManager = new ColorManager(new EfColorDal());
            void GetAll()
            {
                foreach (var car in carManager.GetAll())
                {
                    Console.WriteLine("Araba Id:" + car.CarId + " Araba Marka:" + car.BrandId + " Günlük Ücret:" + car.DailyPrice + " Açıklama;" + car.Description + " Model Yılı:" + car.ModelYear);
                }
            }
            GetAll();
            Console.WriteLine("----------------------Marka id'si iki olan araçlar.----------------------");
            foreach (var car in carManager.GetCarsByBrandId(2))
            {
                Console.WriteLine("Araba Id:" + car.CarId + " Araba Marka:" + brandManager.GetById(car.BrandId).BrandName + " Günlük Ücret:" + car.DailyPrice + " Açıklama;" + car.Description + " Model Yılı:" + car.ModelYear);
            }
            Console.WriteLine("----------------------4.Araç Eklendikten Sonra----------------------");
            carManager.Add(new Car { CarId=5,BrandId=2,ColorId=3,DailyPrice=100,Description="sjjas",ModelYear=2000});
            GetAll();
            brandManager.Add(new Brand {BrandId=6,BrandName="s" });



        }
    }
}
