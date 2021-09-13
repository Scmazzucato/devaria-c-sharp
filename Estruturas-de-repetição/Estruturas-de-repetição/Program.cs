using System;

namespace Estruturas_de_repetição
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                Console.WriteLine("Favor informar palavras no argumento!");
                return;
            }
            for (var indice = 0;  indice < args.Length; indice++)
            {
                Console.WriteLine($"Estrutura for, indice e valor: {indice},{args[indice]}");
            }
            var argumentosLidos = 0;
            while(argumentosLidos < args.Length)
            {
                Console.WriteLine($"Estrutura while, argumentos lidos e valor lidos: {argumentosLidos}, {args[argumentosLidos]}");
                argumentosLidos++;
            }
            var loopsEfetuados = 0;
            do
            {
                Console.WriteLine($"Estrutura do while, loops efetuados: {loopsEfetuados} e valor lido: {args[loopsEfetuados]}");
                loopsEfetuados++;
            } while (loopsEfetuados < args.Length);
            foreach(var arg in args)
            {
                Console.WriteLine($"Estrutura foreach valor lido: {arg}");
            }
        }
    }
}
