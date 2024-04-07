using ecommerce.Models;
using ecommerce.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public class EnderecoController(IEnderecoServices serviceEndereco) : ControllerBase
    {
        private readonly IEnderecoServices _ISE = serviceEndereco;

        [HttpPost]
        public async Task<IActionResult> Post(Endereco endereco)
        {
            if(await _ISE.Criar(endereco))
            {
                return Ok("Endereço cadastrado com sucesso");
            }
            return BadRequest("Erro ao cadastrado endereço");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {   
            Endereco? endereco = await _ISE.Pesquisar(id);

            if(endereco != null)
            {
                return Ok(endereco);
            }
            else
            {
                return NotFound("Endereço não encontrado");
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put(Endereco endereco)
        {
            if(await _ISE.Atualizar(endereco))
            {
                return Ok("Endereço atualizado com sucesso");
            }
            return BadRequest("Erro ao atualizar endereço");
        }
    }
}