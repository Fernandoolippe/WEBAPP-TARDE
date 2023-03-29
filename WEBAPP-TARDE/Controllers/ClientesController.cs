using Microsoft.AspNetCore.Mvc;

namespace WEBAPP_TARDE.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Lista()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }
    }
}
