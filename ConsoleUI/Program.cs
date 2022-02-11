using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entity.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryProductDal());
            carManager.Add(new Car { Id=6, BrandId=2,ColorId=5,DailyPrice=150001,Year="2017",Description="Test"});
            carManager.Add(new Car { Id=7, BrandId=4,ColorId=5,DailyPrice=210000,Year="2022",Description="Test 2"});

            carManager.Display();
            Console.WriteLine();
            carManager.Delete(carManager.GetById(2));

            carManager.Display();
            Console.WriteLine();

            carManager.Update(new Car { Id=7, BrandId=4,ColorId=12,Year="2022",DailyPrice=190000,Description="Updated"});

            carManager.Display();
            Console.WriteLine();
        }
    }
}
