using System.Reflection.Metadata.Ecma335;
using ecommerce.Models;
using ecommerce.Repository.IRepository;
using ecommerce.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ecommerce.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController(IClienteServices clienteServices) : ControllerBase
    {
        private readonly IClienteServices _ICLS = clienteServices;

        [HttpPost]
        public async Task<IActionResult> Post(Cliente cliente)
        {   
            if(await _ICLS.Criar(cliente))
            {
                return Ok("Cliente cadastrado com sucesso");
            }
            return BadRequest($"CPF {cliente.CPF} já cadastrado");
        }

        [HttpGet("{cpf}")]
        public async Task<IActionResult> Get(string cpf)
        {            
            Cliente? cliente = await _ICLS.Pesquisar(cpf);
            if(cliente != null)
            {
                return Ok(cliente);
            }
            return NotFound("Cliente não encontrado");
        }

        [HttpPatch]
        public async Task<IActionResult> Patch(string cpf)
        {
            if(await _ICLS.AlternarStatus(cpf))
            {
                return Ok("Status do cliente alterado");
            }
            return NotFound("Usuário não encontrado");
        }

    }
}