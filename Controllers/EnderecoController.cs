using ecommerce.Models;
using ecommerce.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ecommerce.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EnderecoController(IUnitOfWork contexto) : ControllerBase
    {
        private readonly IUnitOfWork _IUOFW = contexto;

        [HttpPost]
        public async Task<IActionResult> Post(Endereco endereco)
        {
            _IUOFW.EnderecoRepository.Adicionar(endereco);
            await _IUOFW.Commit();
            return Ok(endereco.GetId());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            Endereco? end = await _IUOFW.EnderecoRepository.Pesquisar(x => x.GetId() == id).FirstOrDefaultAsync();
            if(end == null)
            {
                return NotFound("Nenhum endereço encontrado");
            }

            return Ok(end);
        }

    }
}