using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            Console.WriteLine("---------------Initial List---------------");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            Car carToDelete = new Car { Id = 5, BrandId = 4, ColorId = 2, ModelYear = "2022", DailyPrice = 6000, Description = "Dacia Sandero" };
            carManager.Delete(carToDelete);

            Console.WriteLine("---------------After Deletion---------------");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("---------------Get By Id---------------");
            foreach (var item in carManager.GetById(4))
            {
                Console.WriteLine(item.Description);
            }

            Car newCar = new Car() { Id = 6, BrandId = 3, DailyPrice = 7000, ModelYear = "2021", ColorId = 3, Description = "Opel Astra" };
            carManager.Add(newCar);

            Console.WriteLine("---------------After Addition---------------");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
