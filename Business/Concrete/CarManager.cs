﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcern.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        [CacheAspect]
        public IDataResult<List<Car>> GetAll()
        {

            return new SuccessDataResult<List<Car>>(_carDal.GetAll());
        }

        public IDataResult<List<CarDetailsDto>> GetCarsByBrandId(int brandId)
        {
            var result = _carDal.GetCarDetails(b => b.BrandId == brandId);
            return new SuccessDataResult<List<CarDetailsDto>>(result);
        }

        [CacheAspect]
        public IDataResult<List<CarDetailsDto>> GetCarsByColorId(int colorId)
        {
            var result = _carDal.GetCarDetails(c => c.ColorId == colorId);
            return new SuccessDataResult<List<CarDetailsDto>>(result);
        }

        [CacheAspect]
        public IDataResult<List<CarDetailsDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailsDto>>(_carDal.GetCarDetails());
        }

        [CacheAspect]
        public IDataResult<List<CarDetailsDto>> GetCarDetailsById(int id)
        {
            var result = _carDal.GetCarDetails(p => p.CarId == id);
            return new SuccessDataResult<List<CarDetailsDto>>(result);

        }

        [CacheRemoveAspect("ICarService.Get")]
        [SecuredOperation("car.add,admin")]
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }

        [CacheRemoveAspect("ICarService.Get")]
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.GeneralUpdate);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car); ;
            return new SuccessResult(Messages.GeneralDelete);
        }

        [TransactionScopeAspect]
        public IResult AddTransactional(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
