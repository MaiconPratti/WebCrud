﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebCrud.Model
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public long CPF { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public Endereco Endereco { get; set; }
    }
}