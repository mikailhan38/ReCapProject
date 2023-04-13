using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator:AbstractValidator<Rental>
    {
        public RentalValidator() {
            RuleFor(r => r.RentDate).NotEmpty();
            RuleFor(r => r.RentDate).Must(BeAValidDate).WithMessage("Hatalı tarih girildi");
        }

        private bool BeAValidDate(DateTime arg)
        {
            return DateTime.Equals(default (DateTime), arg);
        }
    }
}
