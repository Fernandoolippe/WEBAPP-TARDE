using WEBAPP_TARDE.Entidades;

namespace WEBAPP_TARDE.Models
{
    public class NovaVendaViewModel
    {
        public NovaVendaViewModel()
        {
            Lista_Produtos = new List<ProdutoEntidade>();
        }
        public List<ProdutoEntidade>Lista_Produtos { get; set; }
    }
}
