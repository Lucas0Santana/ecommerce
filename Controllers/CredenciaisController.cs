using ecommerce.Models;
using ecommerce.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CredenciaisController(IUnitOfWork contexto) : ControllerBase 
    {
        private readonly IUnitOfWork _IUOFW = contexto;
        
        [HttpPost]
        public async Task<ActionResult<int>> Post(Credenciais credenciais)
        {
            if(await _IUOFW.CredenciaisRepository.Existe(x => x.GetEmail() == credenciais.GetEmail()))
            {
                return BadRequest($"O email {credenciais.GetEmail()} já está cadastrado");
            }

            _IUOFW.CredenciaisRepository.Adicionar(credenciais);
            await _IUOFW.Commit();
            return Ok(credenciais.GetId());
        } 
        
        
    }
}