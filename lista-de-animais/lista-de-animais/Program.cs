using System;
using System.Collections.Generic;
using System.Linq;
using lista_de_animais.Classes;

namespace lista_de_animais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o nome de um animal:");
            var nomeAnimal = Console.ReadLine();
            if (string.IsNullOrEmpty(nomeAnimal) || string.IsNullOrWhiteSpace(nomeAnimal))
            {
                Console.WriteLine("Favor passar o nome de um animal vertebrado válido!");
                return;
            }
            var listaDeAnimais = new List<Animal>();
            listaDeAnimais.Add(new Mamiferos() { Nome = "Vaca", QuantidadeDeMamas = 4 });
            listaDeAnimais.Add(new Reptil() { Nome = "Cobra" });
            listaDeAnimais.Add(new Aves() { Nome = "Gavião" });
            listaDeAnimais.Add(new Peixes() { Nome = "Tubarão", quantidadeDeNadadeiras = 2 });

            var animalSelecionado = listaDeAnimais.FirstOrDefault(animal => animal.Nome.ToUpper() == nomeAnimal.ToUpper());

            if (animalSelecionado == null)
            {
                Console.WriteLine("O animal não está na nossa lista");
                return;
            }
            if (animalSelecionado is Mamiferos)
            {
                Console.WriteLine($"O animal encontrado é um mamífero com nome {animalSelecionado.Nome} e quantidade de mamas igual {((Mamiferos)animalSelecionado).QuantidadeDeMamas}");
            }else if (animalSelecionado is Reptil)
            {
                Console.WriteLine($"O animal encontrado é um reptil com nome {animalSelecionado.Nome} e que não sabe controlar sua temperatura {((Reptil)animalSelecionado).ControlaTemperaturaDoCorpo}");
            }else if (animalSelecionado is Aves)
            {
                Console.WriteLine($"O animal encontrado é uma ave com nome {animalSelecionado.Nome} e que tem penas {((Aves)animalSelecionado).temPena}");
            }else if (animalSelecionado is Peixes)
            {
                Console.WriteLine($"O animal encontrado é um peixe com nome {animalSelecionado.Nome} e tem {((Peixes)animalSelecionado).quantidadeDeNadadeiras} nadadeiras");
            }else
            {
                Console.WriteLine($"É um animal e tem nome {nomeAnimal}");
            }
        }
    }
}
