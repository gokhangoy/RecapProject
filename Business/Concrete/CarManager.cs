using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : IProductService
    {
        IProductDal _productDal;

        public CarManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Car car)
        {
            _productDal.Add(car);
        }

        public void Delete(Car car)
        {
            _productDal.Delete(car);
        }

        public void Display()
        {
            _productDal.Display();
        }

        public List<Car> GetAll()
        {
            return _productDal.GetAll();
        }

        public Car GetById(int id)
        {
            return _productDal.GetById(id);
        }

        public void Update(Car car)
        {
            _productDal.Update(car);
        }
    }
}
