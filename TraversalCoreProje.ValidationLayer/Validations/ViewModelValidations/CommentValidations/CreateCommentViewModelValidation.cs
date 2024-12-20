﻿using FluentValidation;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.ValidationLayer.Validations
{
    public class CreateCommentViewModelValidation : AbstractValidator<CreateCommentViewModel>
    {
        public CreateCommentViewModelValidation()
        {

            RuleFor(x => x.Content).NotEmpty().WithMessage("İçerik alanı boş geçilemez").NotNull().WithMessage("İçerik alanı boş geçilemez").MinimumLength(30).WithMessage("Lütfen en az 30 karekterlik açıklama bilgisi giriniz").MaximumLength(1500).WithMessage("Lütfen açıklamayı kısaltın");
        }
    }
}
