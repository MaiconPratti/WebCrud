using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebCrud.Model
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string IdVendedor { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public decimal Comissao { get; set; }
        public Endereco Endereco { get; set; }
    }
}