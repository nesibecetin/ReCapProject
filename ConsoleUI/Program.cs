using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities;
using System;

namespace ConsoleUI
{
    class Program
    {
       
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            void Listele()
            {
                foreach (var car in carManager.GetAll())
                {
                    Console.WriteLine("Car Id:" + car.CarId + " Araba Marka:" + car.BrandId + " Günlük Ücret:" + car.DailyPrice + " Açıklama;" + car.Description + " Model Yılı:" + car.ModelYear);
                    
                }
                Console.WriteLine("");
            }

            Listele();
            Car car1 = new Car() {CarId=4,BrandId=4,DailyPrice=100,Description="4.araba",ModelYear=2001 };
            carManager.Add(car1);
            Console.WriteLine("");
            Listele();
            carManager.GetById(2);
            carManager.Delete(car1);
            Console.WriteLine("");
            Listele();


        }
    }
}
