﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Array
namespace Banco.Contas
{
   public class Cliente
    {
        private string p;
        public Cliente(string p)
        {
            this.Nome = p;
        }
        public string Nome { get; set; }
    }
}
