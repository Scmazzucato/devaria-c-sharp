﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_produtos_mercado_classe.Classes
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string ExibirDadosProduto()
        {
            return $"Produto: {Nome} com valor de R$ {Preco}";
        }
    }
}
