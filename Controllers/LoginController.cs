using ecommerce.Models;
using ecommerce.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [AllowAnonymous]
    public class LoginController(ILoginServices loginServices) : ControllerBase
    {
        private readonly ILoginServices _ILS = loginServices;

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Login login)
        {
            if (string.IsNullOrEmpty(login.Email) || string.IsNullOrEmpty(login.Senha))
            {
                return BadRequest("Email e senha são obrigatórios!");
            }
            
            string resposta = await _ILS.Login(login.Email, login.Senha);
            if(resposta == "erro")
            {
                return BadRequest("Email ou senha incorretos!");
            }
            return Ok(resposta);
        }
    }
}