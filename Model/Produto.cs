using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebCrud.Model
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public string Imagem { get; set; }
        public int Quantidade { get; set; }
        public string Status { get; set; }
        public Vendedor Vendedor { get; set; }
        public string Categoria { get; set; }
        public decimal TotalProduto { get; set; }
    }
}