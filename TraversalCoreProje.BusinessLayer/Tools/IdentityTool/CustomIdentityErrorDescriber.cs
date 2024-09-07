using Microsoft.AspNetCore.Identity;

namespace TraversalCoreProje.BusinessLayer.Tools
{
    public class CustomIdentityErrorDescriber : IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError { Code = "PasswordTooShort", Description = $"Şifreni en az {length} karekter uzunluğunda olmalıdır" };
        }
        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError { Code = "PasswordRequiresUpper", Description = $"Şifreniz bir büyük karekter içermelidir" };
        }
        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError { Code = "PasswordRequiresLower", Description = $"Şifreniz bir küçük karekter içermelidir" };
        }

        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError
            {
                Code = "PasswordRequiresNonAlphanumeric",
                Description = $"Şifreniz bir Alphanumeric karekter içermelidir"
            };
        }

        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError
            {
                Code = "PasswordRequiresDigit",
                Description = $"Şifreniz rakam içermelidir."
            };
        }
    }
}
