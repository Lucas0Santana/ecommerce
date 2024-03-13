using Microsoft.AspNetCore.Mvc;

namespace ecommerce.Controllers
{
    [Route("[controller]")]
    public class VarejistaController : Controller
    {
        private readonly ILogger<VarejistaController> _logger;

        public VarejistaController(ILogger<VarejistaController> logger)
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