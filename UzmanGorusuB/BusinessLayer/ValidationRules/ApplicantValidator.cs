using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ApplicantValidator : AbstractValidator<Applicant>
    {
        public ApplicantValidator()
        {
            RuleFor(x => x.ApplicantName).NotEmpty().WithMessage("İsim Kısmı Boş Geçilemez");
            RuleFor(x => x.ApplicantSurname).NotEmpty().WithMessage("Soyisim Kısmı Boş Geçilemez");

        }
    }
}
