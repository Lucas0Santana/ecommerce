using Microsoft.AspNetCore.Mvc;

namespace ecommerce.Controllers
{
    [Route("[controller]")]
    public class SolicitacaoDeEstornoController : Controller
    {
        private readonly ILogger<SolicitacaoDeEstornoController> _logger;

        public SolicitacaoDeEstornoController(ILogger<SolicitacaoDeEstornoController> logger)
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