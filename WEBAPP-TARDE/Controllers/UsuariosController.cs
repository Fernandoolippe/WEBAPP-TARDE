using Microsoft.AspNetCore.Mvc;

namespace WEBAPP_TARDE.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastro()
        {

            return View();

        }
            
     }
}
