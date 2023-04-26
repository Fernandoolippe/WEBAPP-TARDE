using Microsoft.EntityFrameworkCore;
using WEBAPP_TARDE.Entidades;

namespace WEBAPP_TARDE
{
    public class Contexto : DbContext
    {

        public Contexto(DbContextOptions<Contexto> opt) : base(opt)
        { }



        public DbSet<ProdutoEntidade> Produtos { get; set; }

        
        
       





    }
}
