using ecommerce.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CredenciaisController(IUnitOfWork contexto) : ControllerBase 
    {
        private readonly IUnitOfWork _IUOFW = contexto;

        
        
    }
}