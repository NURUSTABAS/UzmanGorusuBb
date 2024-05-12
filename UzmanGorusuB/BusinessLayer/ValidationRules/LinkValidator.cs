using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class LinkValidator : AbstractValidator<Link>
    {
        public LinkValidator()
        {
            RuleFor(x => x.LinkTitle).NotEmpty().WithMessage("Bu alanı boş bırakmayınız");
            RuleFor(x => x.LinkTitle).MaximumLength(150).WithMessage("Lütfen 150 karakterden fazla giriş yapmayınız");
            RuleFor(x => x.LinkTitle).MinimumLength(5).WithMessage("Lütfen 5 karakterden fazla giriş yapınız");
            RuleFor(x => x.LinkContent).NotEmpty().WithMessage("Bu alan boş geçilmez");
            RuleFor(x => x.LinkContent).MaximumLength(150).WithMessage("Lütfen 150 karakterden fazla giriş yapmayınız");
            RuleFor(x => x.LinkContent).MinimumLength(5).WithMessage("Lütfen 5 karakterden fazla giriş yapınız");
        }
    }
}
