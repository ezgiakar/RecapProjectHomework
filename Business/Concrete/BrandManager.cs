using Business.Abstract;
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

        public void Add(Brand brand)
        {
            _brandDal.Delete(brand);
            Console.WriteLine("Marka başarıyla eklendi.");
        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            Console.WriteLine("Marka başarıyla silindi.");
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }


        public List<Brand> GetCarsByBrandId(int id)
        {
            return _brandDal.GetAll(p => p.CarBrandID == id);
        }

        public void Update(Brand brand)
        {
            _brandDal.Delete(brand);
            Console.WriteLine("Marka başarıyla güncellendi.");
        }
    }
}
