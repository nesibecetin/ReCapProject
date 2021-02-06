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
            void GetAll()
            {
                foreach (var car in carManager.GetAll())
                {
                    Console.WriteLine("Araba Id:" + car.CarId + " Araba Marka:" + car.BrandId + " Günlük Ücret:" + car.DailyPrice + " Açıklama;" + car.Description + " Model Yılı:" + car.ModelYear);
                    
                }
                Console.WriteLine("");
            }

            GetAll();
            Car car1 = new Car() {CarId=4,BrandId=4,DailyPrice=100,Description="4.araba",ModelYear=2001 };
            carManager.Add(car1);
            Console.WriteLine("");
            GetAll();

            Console.WriteLine("");
            Console.WriteLine(car1.Description);

            Console.WriteLine(car1.Description);

            carManager.Delete(car1);
            Console.WriteLine("");
            GetAll();


        }
    }
}
