using ecommerce.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CredenciaisController(ICredenciaisServices credenciaisServices) : ControllerBase 
    {
        private readonly ICredenciaisServices _ICS = credenciaisServices;
        
        [HttpPost]
        public async Task<ActionResult<int>> Post(Credenciais credenciais)
        {
            if(await _ICS.Criar(credenciais))
            {
                return Ok(credenciais.Id);
            }
            return BadRequest($"O email {credenciais.Email} já está cadastrado");
        }

        [HttpPut]
        public async Task<ActionResult<int>> Put(Credenciais credenciais)
        {
            if(await _ICS.Atualizar(credenciais))
            {
                return Ok(credenciais.Id);
            }
            return BadRequest($"Erro ao atualizar credenciais");
        }

        [HttpPatch("{id}")]
        public async Task<ActionResult<string>> Patch(int id)
        {
            if(await _ICS.AlternarStatus(id))
            {
                return Ok($"Status da credencial {id} alterado");
            }
            return BadRequest($"Status da credencial {id} não alterado");
        } 
        
        
    }
}