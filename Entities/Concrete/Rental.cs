using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Rental : IEntity
    {
        public  int RentalId { get; set; }
        public  int CarId { get; set; }
        public  int CustomerId { get; set; }
        public  DateTime RentDate { get; set; }
        public  DateTime ReturnDate { get; set; }
        
    }
}
