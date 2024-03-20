using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ecommerce.Models;
using ecommerce.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
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