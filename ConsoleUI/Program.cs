using Business.Concrete;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {


            ColorManager colorManager = new ColorManager(new EfColorDal());



            Console.WriteLine("----------------------Listeleme İşlemleri.----------------------");

            CarList();

            BrandList();

            Console.WriteLine("----------------------Ekleme İşlemleri----------------------");
            CarAdd();



            //Brand brand1 = new Brand { BrandId = 7, BrandName = "Volvo" };
            //brandManager.Add(brand1);

            //Color color1 = new Color { ColorId = 6, ColorName = "Mor" };
            //colorManager.Add(color1);

            //Console.WriteLine("----------------------Silme İşlemleri----------------------");
            //carManager.Delete(car1);
            //brandManager.Delete(brand1);
            //colorManager.Delete(color1);




        }

        private static void CarAdd()
        {
            
            CarManager carManager = new CarManager(new EfCarDal());
            Car car1 = new Car { CarId = 5, BrandId = 2, CarName = "G class", ColorId = 3, DailyPrice = 200, Description = "sjjas", ModelYear = 2000 };
            carManager.Add(car1);
        }

        private static void BrandList()
        {
            BrandManager brandManager = new BrandManager((new EfBrandDal()));
            var result = brandManager.GetAll();
            if (result.isSuccess == true)
            {
                foreach (var brand in brandManager.GetAll().Data)
                {
                    Console.WriteLine("Marka Id:" + brand.BrandId + " Marka Adı:"
                         + brand.BrandName);
                }
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        

      

        private static void CarList()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetAll();
            if (result.isSuccess == true)
            {
                foreach (var car in carManager.GetAll().Data)
                {
                    Console.WriteLine("Araba Id:" + car.CarId + " Araba Marka:"
                         + car.BrandId + " Günlük Ücret:" + car.DailyPrice + " Açıklama;"
                         + car.Description + " Model Yılı:" + car.ModelYear);

                }
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
