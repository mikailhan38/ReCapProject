﻿using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.CarName.Length >= 2)
            {
                _carDal.Add(car);
            }
            else 
            {
                Console.WriteLine("Araç Adı 2 karakterden kısa ve günlük ücret 0'dan küçük olamaz");
            }
        }
        public void Delete(Car car)
        {
           _carDal.Delete(car);
        }
        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int Id)
        {
            return _carDal.GetAll(c=>c.BrandId==Id);
        }

        public List<Car> GetCarsByColorId(int Id)
        {
            return _carDal.GetAll(c=> c.ColorId==Id);
        }
    }
}
