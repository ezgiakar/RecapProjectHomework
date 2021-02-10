using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarDescription);
            }

            foreach (var car in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine(car.CarDescription, car.CarBrandID);
            }

            foreach (var car in carManager.GetCarsByColorId(2))
            {
                Console.WriteLine(car.CarDescription, car.CarColorID);
            }




            ColorManager colorManager = new ColorManager(new EfColorDal());

            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }

            foreach (var color in colorManager.GetCarsByColorId(2))
            {
                Console.WriteLine(color.ColorID);
            }






            BrandManager brandManager = new BrandManager(new EfBrandDal());

            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.CarBrandName);
            }

            foreach (var brand in brandManager.GetCarsByBrandId(1))
            {
                Console.WriteLine(brand.CarBrandID);
            }



            CarManager carManager1 = new CarManager(new EfCarDal());
            foreach (var car in carManager1.GetCarDetailDtos())
            {

                Console.WriteLine(car.BrandName + " " + car.ColorName + " " + car.DailyPrice + " " + car.CarName);
            }
        }
    }
}
