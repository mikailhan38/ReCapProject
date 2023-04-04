using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager:IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }
        public void Add(Brand brand)
        {
            if (brand.BrandName.Length < 2)
            {
                Console.WriteLine("Marka adı 2 Karakterden Kısa olamaz");
            }
            else
            {
                _brandDal.Add(brand);
            }
        }
        public void Delete(Brand brand) 
        {
            _brandDal.Delete(brand);
        }
        public void Update(Brand brand) { _brandDal.Update(brand); }
    }
}
