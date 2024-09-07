using FluentValidation;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.ValidationLayer.Validations
{
    public class UpdateCommentViewModelValidation:AbstractValidator<UpdateCommentViewModel>
    {
        public UpdateCommentViewModelValidation()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("ID alanı boş geçilemez").NotNull().WithMessage("ID alanı boş geçilemez");

            RuleFor(x => x.Content).NotEmpty().WithMessage("İçerik alanı boş geçilemez").NotNull().WithMessage("İçerik alanı boş geçilemez").MinimumLength(30).WithMessage("Lütfen en az 30 karekterlik açıklama bilgisi giriniz").MaximumLength(1500).WithMessage("Lütfen açıklamayı kısaltın");
            RuleFor(x => x.User).NotEmpty().WithMessage("Yorum Yapan Ad soyad boş geçilemez").NotNull().WithMessage("yorum Yapam Ad soyad alanı boş geçilemez");
        }
    }
}
