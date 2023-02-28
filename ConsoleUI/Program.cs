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
            //UserTest();
            //CustomerTest();
            //RentalTest();
        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var rentalResult1 = rentalManager.Add(new Rental { CarId = 2, CustomerId = 1, RentDate = new DateTime(2023, 02, 21) });

            if (rentalResult1.Success)
            {
                Console.WriteLine(rentalResult1.Message);
            }
            else
            {
                Console.WriteLine(rentalResult1.Message);
            }

            Console.WriteLine("---------------------------------------------");

            var rentalResult2 = rentalManager.Add(new Rental { CarId = 2, CustomerId = 1, RentDate = new DateTime(2023, 02, 25), ReturnDate = new DateTime(2023, 02, 28) });

            if (rentalResult2.Success)
            {
                Console.WriteLine(rentalResult2.Message);
            }
            else
            {
                Console.WriteLine(rentalResult2.Message);
            }
        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            var customerResult1 = customerManager.Add(new Customer { CompanyName = "Vindum LLC", UserId = 1 });

            if (customerResult1.Success)
            {
                Console.WriteLine(customerResult1.Message);
            }
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());

            var userResult1 = userManager.Add(new User { FirstName = "Burak", LastName = "Tırman", Email = "burak@gmail.com", Password = "123456" });
            if (userResult1.Success)
            {
                Console.WriteLine(userResult1.Message);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            var colorResult1 = colorManager.Add(new Color { Name = "Cyan" });

            if (colorResult1.Success)
            {
                Console.WriteLine(colorResult1.Message);
            }
            else
            {
                Console.WriteLine(colorResult1.Message);
            }

            Console.WriteLine("---------------------------------------------");

            var colorResult2 = colorManager.Delete(new Color { Id = 2002, Name = "Purple" });

            if (colorResult2.Success)
            {
                Console.WriteLine(colorResult2.Message);
            }
            else
            {
                Console.WriteLine(colorResult2.Message);
            }

            Console.WriteLine("---------------------------------------------");

            var colorResult3 = colorManager.Update(new Color { Id = 1, Name = "Red" });

            if (colorResult3.Success)
            {
                Console.WriteLine(colorResult3.Message);
            }
            else
            {
                Console.WriteLine(colorResult3.Message);
            }

            Console.WriteLine("---------------------------------------------");

            var colorResult4 = colorManager.GetAll();

            if (colorResult4.Success)
            {
                foreach (var color in colorResult4.Data)
                {
                    Console.WriteLine(color.Name);
                }
                Console.WriteLine(colorResult4.Message);
            }
            else
            {
                Console.WriteLine(colorResult4.Message);
            }

            Console.WriteLine("---------------------------------------------");

            var colorResult5 = colorManager.GetById(1002);

            if (colorResult5.Success)
            {
                foreach (var color in colorResult5.Data)
                {
                    Console.WriteLine(color.Name);
                }
                Console.WriteLine(colorResult5.Message);
            }
            else
            {
                Console.WriteLine(colorResult5.Message);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var carResult1 = carManager.Add(new Car { BrandId = 4, ColorId = 4, DailyPrice = 2500, ModelYear = "2023", Description = "Mercedes C180" });

            if (carResult1.Success)
            {
                Console.WriteLine(carResult1.Message);
            }
            else
            {
                Console.WriteLine(carResult1.Message);
            }

            Console.WriteLine("---------------------------------------------");

            var carResult2 = carManager.Delete(new Car { Id = 1005 });

            if (carResult2.Success)
            {
                Console.WriteLine(carResult2.Message);
            }
            else
            {
                Console.WriteLine(carResult2.Message);
            }

            Console.WriteLine("---------------------------------------------");

            var carResult3 = carManager.Update(new Car { Id = 3, Description = "Mercedes C200", DailyPrice = 3000, ModelYear = "2018", ColorId = 4, BrandId = 4 });

            if (carResult3.Success)
            {
                Console.WriteLine(carResult3.Message);
            }
            else
            {
                Console.WriteLine(carResult3.Message);
            }

            Console.WriteLine("---------------------------------------------");

            var carResult4 = carManager.GetCarsByColorId(4);

            if (carResult4.Success)
            {
                foreach (var car in carResult4.Data)
                {
                    Console.WriteLine(car.Description);
                }
                Console.WriteLine(carResult4.Message);
            }
            else
            {
                Console.WriteLine(carResult4.Message);
            }

            Console.WriteLine("---------------------------------------------");

            var carResult5 = carManager.GetCarsByBrandId(4);

            if (carResult5.Success)
            {
                foreach (var car in carResult5.Data)
                {
                    Console.WriteLine(car.Description);
                }
                Console.WriteLine(carResult5.Message);
            }
            else
            {
                Console.WriteLine(carResult5.Message);
            }

            Console.WriteLine("---------------------------------------------");

            var carResult6 = carManager.GetAll();

            if (carResult6.Success)
            {
                foreach (var car in carResult6.Data)
                {
                    Console.WriteLine(car.Description);
                }
                Console.WriteLine(carResult6.Message);
            }
            else
            {
                Console.WriteLine(carResult6.Message);
            }

            Console.WriteLine("---------------------------------------------");

            var carResult7 = carManager.GetCarDetails();

            if (carResult7.Success)
            {
                foreach (var car in carResult7.Data)
                {
                    Console.WriteLine(car.CarName + car.BrandName + car.ColorName + car.DailyPrice);
                }
                Console.WriteLine(carResult7.Message);
            }
            else
            {
                Console.WriteLine(carResult7.Message);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            var brandResult1 = brandManager.Add(new Brand { Name = "Volvo" });

            if (brandResult1.Success)
            {
                Console.WriteLine(brandResult1.Message);
            }
            else
            {
                Console.WriteLine(brandResult1.Message);
            }

            Console.WriteLine("---------------------------------------------");

            var brandResult2 = brandManager.Delete(new Brand { Id = 1003, Name = "Range Rover" });

            if (brandResult2.Success)
            {
                Console.WriteLine(brandResult2.Message);
            }
            else
            {
                Console.WriteLine(brandResult2.Message);
            }

            Console.WriteLine("---------------------------------------------");

            var brandResult3 = brandManager.Update(new Brand { Id = 5, Name = "Tesla Motors" });

            if (brandResult1.Success)
            {
                Console.WriteLine(brandResult3.Message);
            }
            else
            {
                Console.WriteLine(brandResult3.Message);
            }

            Console.WriteLine("---------------------------------------------");

            var brandResult4 = brandManager.GetAll();

            if (brandResult4.Success)
            {
                foreach (var brand in brandResult4.Data)
                {
                    Console.WriteLine(brand.Name);
                }
                Console.WriteLine(brandResult4.Message);
            }
            else
            {
                Console.WriteLine(brandResult4.Message);
            }

            Console.WriteLine("---------------------------------------------");

            var brandResult5 = brandManager.GetById(2);

            if (brandResult5.Success)
            {
                foreach (var brand in brandResult5.Data)
                {
                    Console.WriteLine(brand.Name);
                }
                Console.WriteLine(brandResult5.Message);
            }
            else
            {
                Console.WriteLine(brandResult5.Message);
            }
        }
    }
}
