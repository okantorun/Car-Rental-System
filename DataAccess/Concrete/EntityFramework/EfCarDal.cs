using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, MydatabaseContext>, ICarDal
    {
        public List<CarDetailsDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            using (MydatabaseContext context = new MydatabaseContext())
            {
                var result = from c in filter is null ? context.Cars : context.Cars.Where(filter)
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join col in context.Colors
                             on c.ColorId equals col.ColorId
                             select new CarDetailsDto
                             {
                                 CarId = c.CarId,
                                 ModelYear = c.ModelYear,
                                 CarName = c.CarName,
                                 BrandName = b.BrandName,
                                 ColorName = col.ColorName,
                                 DailyPrice = (int)c.DailyPrice,
                                 ImagePath = (from img in context.CarImages
                                              where c.CarId == img.CarId
                                              select img.ImagePath).ToList()
                             };

                return result.ToList();
            }
        }
    }
}
