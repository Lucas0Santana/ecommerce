using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace ecommerce.Services
{
    public class TokenService
    {
        public static string GenerateToken(Credenciais credenciais, string id)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(Configuracoes.Secret);
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new("Id", id, ClaimValueTypes.Integer),
                        new(ClaimTypes.Email, credenciais.Email),
                        new(ClaimTypes.Name, credenciais.Nome, ClaimValueTypes.Integer),

                    }),
                    Expires = DateTime.UtcNow.AddHours(6),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                };
                var token = tokenHandler.CreateToken(tokenDescriptor);
                return tokenHandler.WriteToken(token);
            }
            catch
            {
                return "Erro";
            }
        }
    }
}
