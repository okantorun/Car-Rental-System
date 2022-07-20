using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, MydatabaseContext>, ICarDal
    {
        public List<CarDetailsDto> GetCarDetails()
        {
            using (MydatabaseContext context = new MydatabaseContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join col in context.Colors
                             on c.ColorId equals col.ColorId
                             select new CarDetailsDto
                             {
                                 ModelYear = c.ModelYear,
                                 BrandName = b.BrandName,
                                 ColorName = col.ColorName,
                                 DailyPrice = c.DailyPrice,
                             };

                return result.ToList();
            }
        }
    }
}
