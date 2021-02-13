using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, NorthwindContext>, IRentalDal
    {
        public List<RentalDetailDto> GetCarDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from r in filter == null ? context.Rentals : context.Rentals.Where(filter)
                             join c in context.Cars
                             on r.CarId equals c.CarID
                             join cu in context.Customers
                             on r.CustomerId equals cu.CustomerId
                             join b in context.Brands
                             on c.CarBrandID equals b.CarBrandID
                             join u in context.Users
                             on cu.CustomerId equals u.UserId
                             select new RentalDetailDto
                             {
                                 RentalId = r.RentalId,
                                 CarName = b.CarBrandName,
                                 CustomerName = cu.CompanyName,
                                 UserName = u.FirstName + "" + u.LastName,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.RentDate
                             };
                return result.ToList();
            }
        }
    }
}
