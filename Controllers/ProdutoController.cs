using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ecommerce.Models;
using ecommerce.Services.IServices;
using ecommerce.Services.Services;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController(IProdutoServices produtoServices) : ControllerBase
    {
        private readonly IProdutoServices _IPS = produtoServices;


        [HttpPost]
        public async Task<IActionResult> Post(Produto produto)
        {
            if (await _IPS.Criar(produto))
            {
                return Ok($"{produto.Nome} cadastrado com sucesso");
            }

            return BadRequest("Erro ao cadastrar produto");
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Produto>> Get(int id)
        {
            var produto = await _IPS.Pesquisar(id);
            if (produto != null)
            {
                return Ok(produto);
            }

            return NotFound("Produto não encontrado");
        }

        [HttpGet("cnpj/{cnpj}")]
        public async Task<ActionResult<List<Produto>>> Get(string cnpj)
        {
            var produtos = await _IPS.Listar(cnpj);
            if (produtos.Count > 0)
            {
                return Ok(produtos);
            }

            return NotFound("Nenhum produto encontrado");
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> Patch(int id)
        {
            if (await _IPS.Desativar(id))
            {
                return Ok();
            }

            return BadRequest();
        }


    }
}