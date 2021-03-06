﻿using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspect.Autofac.Validation;
using Core.Aspect.Caching;
using Core.Aspect.Performance;
using Core.Aspect.Transaction;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        [SecuredOperation("car.add,admin")]
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Add(Car car)
        {
             _carDal.Add(car);
             return new SuccessResult(Messages.CarAdded);

           
        }



        public IResult Delete(Car car)
        {
            ValidationTool.Validate(new CarValidator(), car);
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }
        [PerformanceAspect(5)]
        [CacheAspect(duration: 20)]
        public IDataResult<List<Car>> GetAll()
        {
            Thread.Sleep(5000);
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarListed);

        }
        [CacheAspect]
        public IDataResult<Car> GetAllById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.CarId == id));
        }
        public IDataResult<List<CarDetailDto>> GetCarDetailsById(int id)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(c => c.CarId == id));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(), Messages.CarListed);
        }

        public IDataResult<List<CarDetailDto>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(c => c.BrandId == id), Messages.CarListed);
        }

        public IDataResult<List<CarDetailDto>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(c => c.ColorId == id), Messages.CarListed);
        }
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }
        [TransactionScopeAspect]
        public IResult AddTransactionalTest(Car car)
        {
            _carDal.Update(car);
            _carDal.Add(car);
            return new SuccessResult(Messages.CarUpdated);
        }
        public IDataResult<List<CarDetailDto>> GetCarDetailsByFilter(int brandId, int colorId)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(c => c.BrandId == brandId & c.ColorId == colorId), Messages.CarListed);
        }

    }
}
