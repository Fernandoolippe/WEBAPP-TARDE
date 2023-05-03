using Microsoft.AspNetCore.Mvc;
using WEBAPP_TARDE.Entidades;
using System.Text.RegularExpressions;

namespace WEBAPP_TARDE.Controllers
{
    public class CategoriasController : Controller
    {
        private Contexto contexto;

        public CategoriasController(Contexto db)
        {

            contexto = db;

        }
        public IActionResult Lista()
        {
            return View(contexto.CATEGORIAS.ToList());
        }

        public IActionResult Cadastro()
        {

            return View();

        }
        [HttpPost]
        public IActionResult SalvarDados(CategoriasEntidade dados)
        {

            contexto.CATEGORIAS.Add(dados);
            contexto.SaveChanges();
            return RedirectToAction("Lista");

        }
    }
}
