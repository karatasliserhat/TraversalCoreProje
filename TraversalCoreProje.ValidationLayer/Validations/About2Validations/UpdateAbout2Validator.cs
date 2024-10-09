﻿using FluentValidation;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.ValidationLayer.Validations
{
    internal class UpdateAbout2Validator : AbstractValidator<UpdateAbout2Dto>
    {
        public UpdateAbout2Validator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("ID alanı boş geçilemez").NotNull().WithMessage("ID alanı boş geçilemez");

            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama alanı boş geçilemez").NotNull().WithMessage("Açıklama alanı boş geçilemez").MinimumLength(50).WithMessage("Lütfen en az 50 karekterlik açıklama bilgisi giriniz").MaximumLength(1500).WithMessage("Lütfen açıklamayı kısaltın");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Lütfen görsel seçiniz").NotNull().WithMessage("Lütfen görsel seçiniz");
            RuleFor(x => x.Title1).NotEmpty().WithMessage("Başlık alanı boş geçilemez").NotNull().WithMessage("Başlık alanı boş geçilemez");
            RuleFor(x => x.Title2).NotEmpty().WithMessage("Başlık alanı boş geçilemez").NotNull().WithMessage("Başlık alanı boş geçilemez");
        }
    }
}