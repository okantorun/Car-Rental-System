using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,BrandId=1,ColorId=123,ModelYear=2010,DailyPrice=1000,Description="Temiz"},
                new Car{CarId=2,BrandId=1,ColorId=321,ModelYear=2010,DailyPrice=500,Description="Gayet iyi"},
                new Car{CarId=3,BrandId=2,ColorId=111,ModelYear=2012,DailyPrice=1300,Description="Sadece aileler için"},
                new Car{CarId=4,BrandId=2,ColorId=101,ModelYear=2014,DailyPrice=1200,Description="Oldukça iyi"},
                new Car{CarId=5,BrandId=3,ColorId=456,ModelYear=2016,DailyPrice=1500,Description="Daha önce hiç kiralanmadı"},
            };

        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.CarId == id ).ToList();
        }

        public List<CarDetailsDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            car.CarId = carToUpdate.CarId;
            car.BrandId = carToUpdate.ModelYear;
            car.ModelYear = carToUpdate.ModelYear;
            car.ColorId = carToUpdate.ColorId;
            car.DailyPrice = carToUpdate.DailyPrice;
            car.Description = carToUpdate.Description;
        }
    }
}
