using Business.Abstract;
using Business.Constans;
using Core.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalManager:IRentalService
    {
        IRentalDal _rendalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rendalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            if (rental.ReturnDate==null)
            {
                return new ErrorResult(Messages.RentalInvalid);
            }
            else
            {
                _rendalDal.Add(rental);
            }
            return new SuccessResult(Messages.RentalAdded);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rendalDal.GetAll());
        }

        public IResult Remove(Rental rental)
        {
            _rendalDal.Delete(rental);
            return new SuccessResult();
        }

        public IResult Update(Rental rental)
        {
            _rendalDal.Update(rental);
            return new SuccessResult();
        }
    }
}
