using ecommerce.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdministracaoController(IUnitOfWork contexto) : ControllerBase
    {
        private readonly IUnitOfWork _IUOFW = contexto;

        // [HttpPost]
        // public async Task<IActionResult> Post(AdministracaoController)
    }
}