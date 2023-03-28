using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car { BrandId = 1, ColorId = 1, Id = 1, ModelYear = "2023", DailyPrice = 102.10, Description = "Büyük Aile Aracı" },
                new Car { BrandId = 1, ColorId = 2, Id = 2, ModelYear = "2022", DailyPrice = 105.00, Description = "Küçük Bagaj Hacimli Araç" },
                new Car { BrandId = 1, ColorId = 3, Id = 3, ModelYear = "2021", DailyPrice = 110.50, Description = "Siyah Renkli Konforlu Aracı" },
                new Car { BrandId = 2, ColorId = 3, Id = 4, ModelYear = "2023", DailyPrice = 198.10, Description = "Lüks Vip Aracı" }
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;
            carToDelete=_cars.SingleOrDefault(c=>c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByID(int id)
        {
            return _cars.Where(c=>c.Id==id).ToList();
        }

        public void Update(Car car)
        {
            
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;

        }
    }
}
