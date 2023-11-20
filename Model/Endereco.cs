using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebCrud.Model
{
    public class Endereco
    {
        public string Logradouro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }
    }
}