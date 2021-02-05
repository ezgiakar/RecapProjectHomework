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
        }
    }
}
