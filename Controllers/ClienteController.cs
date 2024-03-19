using System.Reflection.Metadata.Ecma335;
using ecommerce.Models;
using ecommerce.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ecommerce.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController(IUnitOfWork contexto) : ControllerBase
    {
        private readonly IUnitOfWork _IUOFW = contexto;

        [HttpPost]
        public async Task<IActionResult> Post(Cliente cliente)
        {   
            try
            {
                _IUOFW.ClienteRepository.Adicionar(cliente);
                await _IUOFW.Commit();                
            }
            catch (Exception)
            {
                return BadRequest($"CPF {cliente.CPF} já cadastrado");
            }

            return Ok("Cliente cadastrado com sucesso");
        }

        [HttpGet("{cpf}")]
        public async Task<IActionResult> Get(string cpf)
        {            
            Cliente? cliente = await _IUOFW.ClienteRepository.Pesquisar(x => x.CPF == cpf).FirstOrDefaultAsync();
            if(cliente == null) { return NotFound("Cliente não encontrado"); }

            return Ok(cliente);
        }

    [HttpGet]
    public int GetTeste()
    {
        return 1;
    }

        [HttpPatch]
        public async Task<IActionResult> Patch(Cliente cliente)
        {
            Cliente? clienteExistente = await _IUOFW.ClienteRepository.Pesquisar(x => x.CPF == cliente.CPF).FirstOrDefaultAsync(); 
            if(clienteExistente == null) { return NotFound("Cliente não encontrado"); }

            return Ok("Nada alterado");
        }

        

    }
}