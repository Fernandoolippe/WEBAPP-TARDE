using Microsoft.AspNetCore.Mvc;
using WEBAPP_TARDE.Entidades;
using WEBAPP_TARDE.Models;

namespace WEBAPP_TARDE.Controllers
{
    public class ProdutosController : Controller
    {
        public IActionResult Lista()
        {
            return View( db.Produtos.ToList());
        }

        private readonly Contexto db;

        public ProdutosController(Contexto opt)
        {

            db = opt;

        }




    }
}
