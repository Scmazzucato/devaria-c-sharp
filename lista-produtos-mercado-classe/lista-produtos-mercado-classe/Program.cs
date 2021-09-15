using lista_produtos_mercado_classe.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace lista_produtos_mercado_classe
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtosDisponiveis = new List<Produto>();
            produtosDisponiveis.Add(new Produto() { Nome = "Pão", Preco = 0.33 });
            produtosDisponiveis.Add(new Produto() { Nome = "Shampoo", Preco = 19.9 });
            produtosDisponiveis.Add(new Produto() { Nome = "Condicionador", Preco = 20.15 });
            produtosDisponiveis.Add(new Produto() { Nome = "Leite", Preco = 2.00 });
            produtosDisponiveis.Add(new Produto() { Nome = "Arroz", Preco = 25.60 });
            produtosDisponiveis.Add(new Produto() { Nome = "Feijão", Preco = 12.50 });
            produtosDisponiveis.Add(new Produto() { Nome = "Manteiga", Preco = 5.68 });
            produtosDisponiveis.Add(new Produto() { Nome = "Carne", Preco = 27.55 });
            produtosDisponiveis.Add(new Produto() { Nome = "Frango", Preco = 12.75 });

            if(args.Length == 0)
            {
                Console.WriteLine("Você não passou o produto que deseja comprar");
                return;
            }

            var produtosSelecionadosDisponiveis = produtosDisponiveis.Where(produto => args.Any(args => produto.Nome.ToUpper() == args.ToUpper()));

            foreach(var produto in produtosSelecionadosDisponiveis){
                Console.WriteLine($"Este Produto nós temos {produto.ExibirDadosProduto()}");
            }
            var produtosSelecionadosNaoDisponiveis = args.Where(args => !produtosDisponiveis.Any(produto => produto.Nome.ToUpper() == args.ToUpper()));
            foreach (var produtoNaoDisponivel in produtosSelecionadosNaoDisponiveis)
            {
                Console.WriteLine($"Este produto não temos infelizmente =/ {produtoNaoDisponivel}");
            }
            var produtosOrdenadosPorNome = produtosDisponiveis.OrderBy(produto => produto.Nome);
            foreach(var produtoOrdenado in produtosOrdenadosPorNome)
            {
                Console.WriteLine(produtoOrdenado.ExibirDadosProduto());
            }
        }
    }
}
