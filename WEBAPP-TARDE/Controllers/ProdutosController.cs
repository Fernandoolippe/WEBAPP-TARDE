using Microsoft.AspNetCore.Mvc;

namespace WEBAPP_TARDE.Controllers
{
    public class ProdutosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
