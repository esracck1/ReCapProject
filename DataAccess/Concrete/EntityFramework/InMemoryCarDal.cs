using DataAccess.Abstract;
using Entities.Concrete;
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
            _cars = new List<Car>() { 
            new Car{BrandID=1,ColorID=1,DailyPrice=230,Description="Audi sıfır araç",ID=1,ModelYear="2002"},
            new Car{BrandID=2,ColorID=2,DailyPrice=740,Description="Doblo sıfır araç",ID=2,ModelYear="2042"} ,
            new Car{BrandID=3,ColorID=8,DailyPrice=574,Description="Audi sıfır araç",ID=3,ModelYear="2002"}

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car  cartoDelete = _cars.SingleOrDefault(p =>p.ID==car.ID);
            _cars.Remove(cartoDelete);
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

        public List<Car> GetById(int Id)
        {
            return _cars.Where(p => p.ID == Id).ToList();

        }

        public void Update(Car car)
        {
           Car cartoUpdate = _cars.SingleOrDefault(p => p.ID == car.ID);
            cartoUpdate.DailyPrice = car.DailyPrice;
            cartoUpdate.ColorID = car.ColorID;
            cartoUpdate.BrandID = car.BrandID;
            cartoUpdate.Description = car.Description;
            cartoUpdate.ID = car.ID;
            cartoUpdate.ModelYear = car.ModelYear;
        }
       


    }
}
