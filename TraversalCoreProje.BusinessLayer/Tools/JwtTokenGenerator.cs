using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace TraversalCoreProje.BusinessLayer.Tools
{
    public class JwtTokenGenerator : IJwtTokenGenerator
    {
        private readonly IJwtTokenModel _jwtTokenModel;

        public JwtTokenGenerator(IJwtTokenModel jwtTokenModel)
        {
            _jwtTokenModel = jwtTokenModel;
        }


        public TokenResponseModel GenerateToken(GetCheckUserModel model)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(model.Name).Append(" ").Append(model.Surname).ToString();

            var claims = new List<Claim>();
            if (!string.IsNullOrWhiteSpace(model.RoleName))
                claims.Add(new Claim(ClaimTypes.Role, model.RoleName));

            if (!string.IsNullOrEmpty(model.UserName))
                claims.Add(new Claim("Username", model.UserName));

            if (!string.IsNullOrEmpty(model.Name))
                claims.Add(new Claim(ClaimTypes.Name, builder.ToString()));

            if (!string.IsNullOrEmpty(model.Email))
                claims.Add(new Claim(ClaimTypes.Email, model.Email));

            claims.Add(new Claim(ClaimTypes.NameIdentifier, model.UserId.ToString()));

            SecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtTokenModel.Key));
            SigningCredentials signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var expireDAte = DateTime.UtcNow.AddDays(_jwtTokenModel.ExpireDate);
            JwtSecurityToken securityToken = new JwtSecurityToken(issuer: _jwtTokenModel.Issuer, audience: _jwtTokenModel.Issuer, claims: claims, notBefore: DateTime.UtcNow, expires: expireDAte, signingCredentials: signingCredentials);

            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();

            return new TokenResponseModel(handler.WriteToken(securityToken), expireDAte);
        }
    }
}
