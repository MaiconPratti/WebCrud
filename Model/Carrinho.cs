using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebCrud.Model
{
    [Serializable]
    public class Carrinho
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public decimal ValorTotal { get; set; }
        public int StatusPedido { get; set; }
        public Cliente Cliente { get; set; }
        public List<Produto> Produtos { get; set; }
        public decimal TotalCarrinho { get; set; }
    }

}