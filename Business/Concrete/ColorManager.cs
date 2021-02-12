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
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult(Messages.ColorAdded);
        }

        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult(Messages.ColorDeleted);
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll());
        }


        public IDataResult<List<Color>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(p => p.ColorID == id));
        }

        public IResult Update(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult(Messages.ColorUpdated);
        }
    }
}
