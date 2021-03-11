using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.FileHelper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;
     
        public CarImageManager(ICarImageDal carImageDal)
        {

            _carImageDal = carImageDal;
        }

        public IResult Add(IFormFile file, CarImage carImage)
        {
            IResult result = BusinessRules.Run(CheckImageLimit(carImage.CarId));
            if (result != null)
            {
                return result;
            }
            carImage.ImagePath = FileHelper.Add(file);
            carImage.DateTime = DateTime.Now;
            _carImageDal.Add(carImage);
            return new SuccessResult();
        }

        public IResult Delete(CarImage carImage)
        {
            
    
            FileHelper.Delete(carImage.ImagePath);
            _carImageDal.Delete(carImage);
            return new SuccessResult();
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(), Messages.CarListed);
        }

        public IDataResult<List<CarImage>> GetById(int id)
        {
            return new SuccessDataResult<List<CarImage>>(CheckIfImageNull(id).Data);
        }

        public IResult Update(IFormFile file, CarImage carImage)
        {
            var carImageToUpdate = _carImageDal.Get(p => p.ImageId == carImage.ImageId);
            var oldpath = carImageToUpdate.ImagePath;
            carImage.ImagePath = FileHelper.Update(oldpath, file);
            carImage.DateTime = carImageToUpdate.DateTime;
            carImage.CarId = carImageToUpdate.CarId;
            _carImageDal.Update(carImage);
            return new SuccessResult();
        }
        private IResult CheckImageLimit(int carId)
        {
            var result = _carImageDal.GetAll(c => c.CarId == carId).Count;
            if (result >= 5)
            {
                return new ErrorResult(Messages.CarImageLimit);
            }
            return new SuccessResult();
        }

        private IDataResult<List<CarImage>> CheckIfImageNull(int carId)
        {
            var Path = $@"{Environment.CurrentDirectory}\Public\CarImages\default.jpg";
            var result = _carImageDal.GetAll(c => c.CarId == carId).Any();
            if (!result)
            {
                 List < CarImage >carImage = new  List < CarImage > ();
                 carImage.Add(new CarImage { CarId = carId, DateTime = DateTime.Now, ImagePath = Path });
                return new SuccessDataResult<List<CarImage>>(carImage);

            }
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(c => c.CarId == carId).ToList());
        }

       
    }
}
