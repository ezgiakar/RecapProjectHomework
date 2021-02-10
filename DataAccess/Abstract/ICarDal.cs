using DataAccess.EntityFramework;
using Entity.Concrete;
using Entity.DTOes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
      List<CarDetailDto> GetCarDetailDtos();
    }
}
