using Business.Abstract;
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

        public void Add(Color color)
        {
            _colorDal.Delete(color);
            Console.WriteLine("Renk başarıyla eklendi.");
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
            Console.WriteLine("Renk başarıyla silindi.");
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }


        public List<Color> GetCarsByColorId(int id)
        {
            return _colorDal.GetAll(p => p.ColorID == id);
        }

        public void Update(Color color)
        {
            _colorDal.Delete(color);
            Console.WriteLine("Renk başarıyla güncellendi.");
        }
    }
}
