﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adını boş geçemezsiniz");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar soyisim boş geçilemez");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkında boş geçemezsiniz");
            RuleFor(x => x.WriterTitle).MaximumLength(20).WithMessage("Ünvan kısmı boş olamaz.");
            RuleFor(x => x.WriterSurname).MinimumLength(3).WithMessage("Yazar adı 3 karakterden az olamaz.");
            RuleFor(x => x.WriterSurname).MaximumLength(20).WithMessage("Yazar ismi 20 karakterden fazla olamaz.");
        }
    }
}
