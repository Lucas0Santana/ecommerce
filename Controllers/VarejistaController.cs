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
    public class VarejistaController(IVarejistaServices varejistaServices) : ControllerBase
    {
        private readonly IVarejistaServices _IVS = varejistaServices;
    
        [HttpPost]
        public async Task<IActionResult> Criar(Varejista varejista)
        {
            if(await _IVS.Criar(varejista))
            {
                return Ok("Varejista criado com sucesso!");
            }
            return BadRequest("Varejista já existe!");
        }

        [HttpGet("{cnpj}")]
        public async Task<IActionResult> Pesquisar(string cnpj)
        {
            Varejista? varejista = await _IVS.Pesquisar(cnpj);
            if(varejista == null)
            {
                return NotFound("Varejista não encontrado!");
            }
            return Ok(varejista);
        }
    }
}