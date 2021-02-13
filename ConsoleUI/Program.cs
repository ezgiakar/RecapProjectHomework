using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entity.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarManagerTest();
            ManagerTest();
        }

        private static void CarManagerTest()
        {
            //CarManager carManager = new CarManager(new EfCarDal());

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.CarDescription);
            //}

            //foreach (var car in carManager.GetCarsByBrandId(1))
            //{
            //    Console.WriteLine(car.CarDescription, car.CarBrandID);
            //}

            //foreach (var car in carManager.GetCarsByColorId(2))
            //{
            //    Console.WriteLine(car.CarDescription, car.CarColorID);
            //}




            //ColorManager colorManager = new ColorManager(new EfColorDal());

            //foreach (var color in colorManager.GetAll())
            //{
            //    Console.WriteLine(color.ColorName);
            //}

            //foreach (var color in colorManager.GetCarsByColorId(2))
            //{
            //    Console.WriteLine(color.ColorID);
            //}






            //BrandManager brandManager = new BrandManager(new EfBrandDal());

            //foreach (var brand in brandManager.GetAll())
            //{
            //    Console.WriteLine(brand.CarBrandName);
            //}

            //foreach (var brand in brandManager.GetCarsByBrandId(1))
            //{
            //    Console.WriteLine(brand.CarBrandID);
            //}



            //CarManager carManager1 = new CarManager(new EfCarDal());
            //foreach (var car in carManager1.GetCarDetailDtos())
            //{

            //    Console.WriteLine(car.BrandName + " " + car.ColorName + " " + car.DailyPrice + " " + car.CarName);
            //}
        }

        private static void ManagerTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetailDtos();
            if (result.Success==true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + "/" + car.BrandName + "/" + car.BrandName);
                }
            }

            else
            {
                Console.WriteLine(result.Message);
            }

            foreach (var car in carManager.GetCarDetailDtos().Data)
            {
                Console.WriteLine(car.CarName + "/" + car.BrandName);
            }

            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            UserManager userManager = new UserManager(new EfUserDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            Rental rentalAdd = new Rental
            {
                CarId = 1,
                CustomerId = 1,
                RentDate = DateTime.Now,
                ReturnDate = new DateTime(2021, 03, 03)
            };

            Console.WriteLine(rentalManager.Add(rentalAdd).Message);

            User user = new User
            {   FirstName = "Ezgi",
                LastName = "Akar",
                Email = "ezgiakar.ea@gmail.com",
                Password = "123456",
                UserId = 1 
            };
        }
    }
}
