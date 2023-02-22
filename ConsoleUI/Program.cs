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
            //CarTest();
            //BrandTest();
            //ColorTest();
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            colorManager.Add(new Color { Name = "Yellow" });
            colorManager.Delete(new Color { Id = 5, Name = "Orange" });
            colorManager.Update(new Color { Id = 1, Name = "Pink" });

            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.Name);
            }

            Console.WriteLine("---------------------------------------------");

            foreach (var color in colorManager.GetById(4))
            {
                Console.WriteLine(color.Name);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            carManager.Add(new Car {BrandId = 3, ColorId = 3, ModelYear = "2020", Description = "Audi A6", DailyPrice = 4500 });
            carManager.Delete(new Car { Id = 1002 });
            carManager.Update(new Car { Id = 3, Description = "Mercedes C200", DailyPrice = 2400, ModelYear = "2018", ColorId = 4, BrandId = 4 });

            foreach (var car in carManager.GetCarsByColorId(2))
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("---------------------------------------------");

            Car newCar = new Car { BrandId = 4, ColorId = 5, DailyPrice = 2500, ModelYear = "2023", Description = "Mercedes C180" };
            carManager.Add(newCar);

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            foreach (var car in carManager.GetCarsByColorId(3))
            {
                Console.WriteLine(car.Description);
            }

            foreach (var car in carManager.GetCarsByBrandId(5))
            {
                Console.WriteLine(car.Description);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            brandManager.Add(new Brand { Name = "Range Rover" });
            brandManager.Delete(new Brand { Id = 1002, Name = "Range Rover" });
            brandManager.Update(new Brand { Id = 4, Name = "Mercedes Benz" });

            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.Name);
            }

            Console.WriteLine("---------------------------------------------");

            foreach (var brand in brandManager.GetById(4))
            {
                Console.WriteLine(brand.Name);
            }
        }
    }
}
