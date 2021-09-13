using System;
using System.Collections.Generic;
using System.Linq;

namespace Lista_de_compras
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> produtosDisponiveis = new List<string>()
            {
                "Pão", "Leite", "Manteiga", "Carne", "Café", "Frango", "Batata", "Chocolate", "Arroz", "Feijão"
            };
            try
            {
                var produtosSelecionados = produtosDisponiveis.Where(produto => args.Contains(produto)).ToList();   
                foreach (var produtoSelecionado in produtosSelecionados)
                {
                    Console.WriteLine($"Este produto nos temos: {produtoSelecionado}");
                }
                var produtosNaoDisponiveis = args.Where(args => !produtosDisponiveis.Contains(args)).ToList();
                foreach(var produtosNaoDisponivel in produtosNaoDisponiveis)
                {
                    Console.WriteLine($"Este produto nos não temos infelizmente=/ : {produtosNaoDisponivel}");
                }
                var produtosDisponiveisOrdenadoPorNome = produtosDisponiveis.OrderBy(e => e).ToList();
                foreach(var produtorOrdenados in produtosDisponiveisOrdenadoPorNome)
                {
                    Console.WriteLine($"Segue este produto disponível: {produtorOrdenados}");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Argumentos Inválidos");
            }
        }
    }
}