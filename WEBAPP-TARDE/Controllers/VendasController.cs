using Microsoft.AspNetCore.Mvc;
using WEBAPP_TARDE.Entidades;
using WEBAPP_TARDE.Models;

namespace WEBAPP_TARDE.Controllers
{
    public class VendasController : Controller
    {
        private Contexto db;

        public VendasController(Contexto contexto)
        {
            db = contexto;
        }
        public IActionResult Lista()
        {
            return View();
        }
        public IActionResult Cadastro()
        {
            NovaVendaViewModel model = new NovaVendaViewModel();
            model.Lista_Produtos = db.Produtos.ToList();
            return View(model);
        }
        [HttpPost]
        public IActionResult SalvarDados(VendasEntidade dados)
        {
            return RedirectToAction("Lista");
        }
    }
}
