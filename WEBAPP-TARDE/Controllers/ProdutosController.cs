using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WEBAPP_TARDE.Entidades;
using WEBAPP_TARDE.Models;

namespace WEBAPP_TARDE.Controllers
{
    public class ProdutosController : Controller
    {
        public IActionResult Lista()
        {
            return View( db.Produtos.Include(a => a Categoria).ToList() );
        }

        private readonly Contexto db;

        public ProdutosController(Contexto opt)
        {

            db = opt;

        }

        public IActionResult Cadastro()
        {
            NovoProdutoViewModel model = new NovoProdutoViewModel();
            model.Lista_Categorias = db.Categorias.ToList
            return View();
        }
        [HttpPost]

        public IActionResult SalvarDados(ProdutoEntidade produto)
        {
            db.Produtos.Add(produto);
        }
    }
}
