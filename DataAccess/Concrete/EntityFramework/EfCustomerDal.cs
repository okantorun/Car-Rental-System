using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, MydatabaseContext>, ICustomerDal
    {

        public List<CustomerDetailsDto> GetCustomerDetails()
        {
            using (MydatabaseContext context = new MydatabaseContext())
            {
                var result = from cus in context.Customers
                             join user in context.Users on cus.UserId equals user.Id
                             select new CustomerDetailsDto
                             {
                                 CustomerId = cus.CustomerId,
                                 FirstName = user.FirstName,
                                 LastName = user.LastName,
                                 CompanyName = cus.CompanyName
                             };
                return result.ToList();
            }
        }
    }
}
