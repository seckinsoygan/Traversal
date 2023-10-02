using FluentValidation;
using Traversal.Entity.Concrete;

namespace Traversal.Business.ValidationRules
{
	public class AboutValidator : AbstractValidator<About>
	{
		public AboutValidator()
		{
			RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama Kısmını Boş Geçemezsiniz.");
			RuleFor(x => x.Image1).NotEmpty().WithMessage("Lütfen Görsel Seçiniz.");
		}
	}
}
