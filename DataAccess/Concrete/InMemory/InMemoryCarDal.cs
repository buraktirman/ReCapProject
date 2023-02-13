using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car{Id = 1, BrandId = 1, ColorId = 2, ModelYear = "2014",DailyPrice = 2400, Description = "Hyundai Accent Blue"},
                new Car{Id = 2, BrandId = 1, ColorId = 1, ModelYear = "2020",DailyPrice = 4000, Description = "Hyundai Kona"},
                new Car{Id = 3, BrandId = 2, ColorId = 4, ModelYear = "2013",DailyPrice = 3750, Description = "Renault Kadjar"},
                new Car{Id = 4, BrandId = 3, ColorId = 3, ModelYear = "2015",DailyPrice = 1600, Description = "Opel Corsa"},
                new Car{Id = 5, BrandId = 4, ColorId = 2, ModelYear = "2022",DailyPrice = 6000, Description = "Dacia Sandero"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => car.Id == c.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => car.Id == c.Id);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
