using ecommerce.Models;
using ecommerce.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public class PedidoController(IPedidoServices pedidoServices) : ControllerBase
    {
        private readonly IPedidoServices _IPDS = pedidoServices;
    
        [HttpPost]
        public async Task<IActionResult> Criar(Pedido pedido)
        {
            if (await _IPDS.Criar(pedido))
            {
                return Ok("Pedido criado com sucesso!");
            }
            return BadRequest("Erro ao criar pedido!");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Pesquisar(int id)
        {
            var pedido = await _IPDS.Pesquisar(id);
            if (pedido == null)
            {
                return NotFound("Pedido não encontrado!");
            }
            return Ok(pedido);
        }
    }
}