using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
           this._carDal  = carDal;
        }

        public void Add(Car entity)
        {
            if (entity.DailyPrice>0 && entity.Description.Length>2)
            {
                _carDal.Add(entity);
            }
            else if (entity.DailyPrice>0)
            {
                Console.WriteLine("Lütfen açıklama karakterini 2'den büyük tutunuz.");
            }
            else if (entity.Description.Length>0)
            {
                Console.WriteLine("Lütfen günlük ücreti 0'dan farklı bir değerde veriniz");
            }
            else
            {
                Console.WriteLine("Lütfen açıklama karakterini 2'den büyük tutunuz ve  günlük ücreti 0'dan farklı bir değerde veriniz");
            }
            
        }

        public void Delete(Car entity)
        {
          
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}
