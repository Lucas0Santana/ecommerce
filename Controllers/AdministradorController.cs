using ecommerce.Models;
using ecommerce.Repository.IRepository;
using ecommerce.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdministradorController(IAdministradorServices administradorServices) : ControllerBase
    {
        private readonly IAdministradorServices _IADMS = administradorServices;

        [HttpPost]
        public async Task<IActionResult> Post(Administrador administrador)
        {
            if(await _IADMS.Criar(administrador))
            {
                return Ok("Administrador criado com sucesso!");
            }
            return BadRequest("Erro ao criar administrador!");
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Administrador>> Get(int id)
        {
            var administrador = await _IADMS.Pesquisar(id);
            if(administrador == null)
            {
                return NotFound("Administrador não encontrado!");
            }
            return Ok(administrador);
        }
    }
}