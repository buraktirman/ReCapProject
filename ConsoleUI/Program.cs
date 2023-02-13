using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarsByColorId(2))
            {
                Console.WriteLine(car.Description);
            }

            Car newCar = new Car { BrandId = 4, ColorId = 5, DailyPrice = 2500, ModelYear = "2023", Description = "Mercedes C180" };
            carManager.Add(newCar);

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            Color color = new Color { Name = "Pink" };
        }
    }
}
