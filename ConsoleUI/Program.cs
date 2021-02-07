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

            Console.WriteLine("----------------------Listeleme İşlemleri.----------------------");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Araba Id:" + car.CarId + " Araba Marka:" 
                     + car.BrandId + " Günlük Ücret:" + car.DailyPrice + " Açıklama;" 
                     + car.Description + " Model Yılı:" + car.ModelYear);
            }

            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine("Marka Id:" + brand.BrandId + " Marka Adı:"
                     + brand.BrandName);
            }

            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine("Renk Id:" + color.ColorId + " Renk Adı:"
                     + color.ColorName );
            }

            Console.WriteLine("----------------------Marka id'si iki olan araçlar.----------------------");

            foreach (var car in carManager.GetCarsByBrandId(2))
            {
                Console.WriteLine("Araba Id:" + car.CarId + " Araba Marka:" 
                    + brandManager.GetById(car.BrandId).BrandName + " Günlük Ücret:" 
                    + car.DailyPrice + " Açıklama;" + car.Description + " Model Yılı:" + car.ModelYear);
            }

            Console.WriteLine("----------------------Araç Detayları----------------------");
            foreach (var carDetail in carManager.GetCarDetails())
            {
                Console.WriteLine("Araba Adı:" + carDetail.CarName + " Araba Marka:"
                    + carDetail.BrandName + " Günlük Ücret:" + carDetail.DailyPrice + " Araba Rengi;"
                    + carDetail.ColorName);
            }

            Console.WriteLine("----------------------Ekleme İşlemleri----------------------");
            Car car1 = new Car { CarId = 5, BrandId = 2, CarName = "G class", ColorId = 3, DailyPrice = 200, Description = "sjjas", ModelYear = 2000  };
            carManager.Add(car1);
 
            Brand brand1 = new Brand { BrandId=7,BrandName="Volvo"};
            brandManager.Add(brand1);

            Color color1 = new Color { ColorId=6,ColorName="Mor"};
            colorManager.Add(color1);

            Console.WriteLine("----------------------Silme İşlemleri----------------------");
            carManager.Delete(car1);
            brandManager.Delete(brand1);
            colorManager.Delete(color1);

          


        }
    }
}
