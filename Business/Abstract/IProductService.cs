using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Car> GetAll();
        Car GetById(int id);

        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
        void Display();
    }
}
