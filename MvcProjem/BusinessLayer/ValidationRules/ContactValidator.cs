using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator: AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x=>x.UserMail).NotEmpty().WithMessage("Mail adresi boş geçilemez...");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu adını boş geçemezsiniz");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı adı boş geçilemez");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Kategori adı 3 karakterden az olamaz.");
            RuleFor(x => x.UserName).MinimumLength(3).WithMessage("Kategori adı 3 karakterden az olamaz.");
            RuleFor(x => x.Subject).MaximumLength(50).WithMessage("Kategori ismi 20 karakterden fazla olamaz.");

        }
    }
}
