using DataAccess.Abstract;
using Entity.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Car> _cars;

        public InMemoryProductDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1, BrandId=1,ColorId=1,Year="2015",DailyPrice=125000,Description="White Polo"},
                new Car{Id=2, BrandId=1,ColorId=2,Year="2018",DailyPrice=150000,Description="Black Ford"},
                new Car{Id=3, BrandId=2,ColorId=3,Year="2012",DailyPrice=115000,Description="Gray Volvo"},
                new Car{Id=4, BrandId=3,ColorId=4,Year="2020",DailyPrice=165000,Description="Light Blue Renault"},
                new Car{Id=5, BrandId=4,ColorId=5,Year="2022",DailyPrice=200000,Description="White TOGG"},
            };
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(item => item.Id == id);
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = new Car();

            carToDelete = _cars.SingleOrDefault(item => item.Id == car.Id);

            _cars.Remove(carToDelete);
        }

        public void Update(Car car)
        {
            Car carToUpdate = new Car();

            carToUpdate = _cars.SingleOrDefault(item => item.Id == car.Id);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }

        public void Display()
        {
            foreach (var item in _cars)
            {
                Console.Write(item.Id);
                Console.Write("\t" + item.BrandId);
                Console.Write("\t" + item.ColorId);
                Console.Write("\t" + item.Year);
                Console.Write("\t" + item.DailyPrice);
                Console.Write("\t" + item.Description);
                Console.WriteLine();
            }
        }
    }
}
