﻿namespace WEBAPP_TARDE.Entidades
{
    public class ProdutoEntidade
    {

        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public bool Ativo { get; set; }

        public CategoriasEntidade Categoria { get; set; }

        public int CategoriaId { get; set; }
    }
}
