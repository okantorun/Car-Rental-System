using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        private IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental rental)
        {
            var rentalToAdd = _rentalDal.Get(r => r.CarId == rental.CarId);
            if ((rental.RentDate == null || rental.ReturnDate > rental.RentDate))
            {
                _rentalDal.Add(rental);
                return new SuccessResult(Messages.CarHired);
            }
            else
            {
                return new ErrorResult(Messages.CarNotDelivered);
            }
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.GeneralDelete);
        }

        public IDataResult<List<Rental>> GetAll()
        {

            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.GeneralUpdate);
        }
    }
}
