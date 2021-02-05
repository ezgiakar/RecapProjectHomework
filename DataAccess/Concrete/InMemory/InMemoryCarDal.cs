using DataAccess.Abstract;
using Entity.Concrete;
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
            _cars = new List<Car>
            {
                new Car
                {
                    CarID = 1, CarBrandID = 1, CarColorID= 1, CarDailyPrice = 500000,
                    CarDescription = "BMW", CarModalYear = 2020
                },
                new Car
                {
                    CarID = 2, CarBrandID = 1, CarColorID= 2, CarDailyPrice = 200000,
                    CarDescription = "BMW", CarModalYear = 2019
                },
                new Car
                {
                    CarID = 3, CarBrandID = 1, CarColorID= 3, CarDailyPrice = 100000,
                    CarDescription = "BMW", CarModalYear = 2018
                },
                new Car
                {
                    CarID = 4, CarBrandID = 2, CarColorID= 1, CarDailyPrice = 300000,
                    CarDescription = "VOLKSWAGEN", CarModalYear = 1996
                },
                new Car
                {
                    CarID = 5, CarBrandID = 2, CarColorID= 1, CarDailyPrice = 400000,
                    CarDescription = "VOLKSWAGEN", CarModalYear = 2015
                }
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarID == car.CarID);
            _cars.Remove(carToDelete);

        }

        public List<Car> GetAllByBrandId(int brandId)
        {
            return _cars.Where(p => p.CarBrandID == brandId).ToList();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarID == car.CarID);
            carToUpdate.CarBrandID = car.CarBrandID;
            carToUpdate.CarColorID = car.CarColorID;
            carToUpdate.CarDailyPrice = car.CarDailyPrice;
            carToUpdate.CarDescription = car.CarDescription;
            carToUpdate.CarModalYear = car.CarModalYear;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
    }
}

