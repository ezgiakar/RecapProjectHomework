using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
   public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            //if (car.CarDailyPrice > 0)
            //{
            //    return new ErrorResult(Messages.ProductNameInvalid);
            //}
            //_carDal.Add(car);

            //return new SuccessResult(Messages.ProductAdded);

            //if (car.CarDescription.Length < 2)
            //{
            //    return new ErrorResult(Messages.ProductNameInvalid);
            //} Bunun yerine validator yazdık. Core katmanına yazdık.
            

            //business codes

            _carDal.Add(car);

            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);

            return new SuccessResult(Messages.ProductDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour == 24)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.ProductListed);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetailDtos()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetailDtos());
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.CarBrandID == id));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.CarColorID == id));
        }

        public IResult Update(Car car)
        {
            if (car.CarDailyPrice > 0)
            {
                _carDal.Update(car);
                return new ErrorResult(Messages.ProductPriceInvalid);
            }
            _carDal.Update(car);

            return new SuccessResult(Messages.ProductUpdated);
        }
    }
}
