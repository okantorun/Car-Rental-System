using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework 
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, MydatabaseContext>, IRentalDal
    {
        public List<RentalDetailsDto> GetRentalDetails()
        {
            using (MydatabaseContext context = new MydatabaseContext())
            {
                var result = from rental in context.Rentals
                             join car in context.Cars on rental.CarId equals car.CarId
                             join cus in context.Customers on rental.CustomerId equals cus.CustomerId
                             join user in context.Users on cus.UserId equals user.Id
                             join brand in context.Brands on car.BrandId equals brand.BrandId
                             select new RentalDetailsDto
                             {
                                 RentalId = rental.RentalId,
                                 CarName = car.Description,
                                 BrandName = brand.BrandName,
                                 CustomerName = user.FirstName + " " + user.LastName,
                                 RentDate = rental.RentDate,
                                 ReturnDate = rental.ReturnDate
                             };

                return result.ToList();
            }
        }
    }
}
