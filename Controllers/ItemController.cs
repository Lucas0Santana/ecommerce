using ecommerce.Models;
using ecommerce.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemController(IItemServices itemServices) : ControllerBase
    {
        private readonly IItemServices _itemServices = itemServices;

        [HttpPost]
        public async Task<IActionResult> Post(Item item)
        {
            if(await _itemServices.Criar(item))
            {
                return Ok("Cadastrado com sucesso");
            }
            return BadRequest("Item já existe");
        }

        [HttpGet("{idProduto}")]
        public async Task<IActionResult> Get(int idProduto)
        {
            Item? item = await _itemServices.Pesquisar(idProduto);
            if(item == null)
            {
                return NotFound("Item não encontrado");
            }
            return Ok(item);
        }
    }
}