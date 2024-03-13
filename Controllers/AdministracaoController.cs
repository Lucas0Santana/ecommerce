using Microsoft.AspNetCore.Mvc;

namespace ecommerce.Controllers
{
    [Route("[controller]")]
    public class AdministracaoController : Controller
    {
        private readonly ILogger<AdministracaoController> _logger;

        public AdministracaoController(ILogger<AdministracaoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}