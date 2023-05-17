using AspNetCore;
using WEBAPP_TARDE.Entidades;

namespace WEBAPP_TARDE.Models
{
    public class NovoProdutoViewModel: ProdutoEntidade
    {
        public NovoProdutoViewModel()
        {
            Lista_Categorias = new List<CategoriasEntidade>();
        }
        public List<CategoriasEntidade> Lista_Categorias { get; set; }
    }
}
