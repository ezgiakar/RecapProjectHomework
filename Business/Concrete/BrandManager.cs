using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.BrandAdded);
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.BrandDeleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());
        }


        public IDataResult<List<Brand>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(p => p.CarBrandID == id));
        }

        public IResult Update(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.BrandUpdated);
        }
    }
}
