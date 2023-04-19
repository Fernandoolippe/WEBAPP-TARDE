using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Xml;
using WEBAPP_TARDE.Models;

namespace WEBAPP_TARDE.Controllers
{
    public class ClientesController : Controller
    {
        public static List<ClientesViewModel> db = new List<ClientesViewModel>();
        public IActionResult Lista()
        {

            ClientesViewModel c1 = new ClientesViewModel();
            c1.Id = 1;
            c1.Nome = "9adasdasd";
            c1.Telefone = "2313123";

            for (int i = 0; i< 10;i++)
            {
                ClientesViewModel c2 = new ClientesViewModel();
                c2.Id = i;
                c2.Nome = "ahghg" + i;
                c2.Telefone = "777777" + i;
                //db.Add(c2);
            }
           // db.Add(c1);



            return View( db );
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult SalvarDados(ClientesViewModel dados)
        {
            if (dados.Id == 0)
            {

                Random rand = new Random();
          
                int numeroAleatorio = rand.Next(1, 9999);
                dados.Id = numeroAleatorio;
                db.Add(dados);

            }
            else
            {
  
              int indice = db.FindIndex(a => a.Id == dados.Id);
                db[indice] = dados;  
            }
            return RedirectToAction("Lista");

        }

        public IActionResult Excluir(int id)
        {

            ClientesViewModel cliente = db.Find(a => a.Id == id);

            if (cliente != null)
            {
                db.Remove(cliente);
            }

            return RedirectToAction("Lista");


        }

        public IActionResult Editar(int id)
        {

            ClientesViewModel cliente = db.Find(a => a.Id == id);

            if (cliente != null)
            {
                return View(cliente);
            }

            else
            {

                return RedirectToAction("Lista");

            }

        }
    }
}
