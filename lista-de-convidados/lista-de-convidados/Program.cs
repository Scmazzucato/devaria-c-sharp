using System;

namespace lista_de_convidados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o nome do convidado:");
            var nome = Console.ReadLine();

            if(string.IsNullOrEmpty(nome))
            {
                Console.WriteLine("Nome não informado para seguir a vaçidação");
                return;
            }

            Console.WriteLine("Informe a idade do convidado:");
            var idadeString = Console.ReadLine();
            int idade;

            bool idadeInformada = int.TryParse(idadeString, out idade);

            if(idadeInformada == false)
            {
                Console.WriteLine("Idade não informada para seguir com o programa");
            }
            bool estaConvidado;
            switch (nome)
            {
                case "Samuel":
                    estaConvidado = true;
                    break;
                case "Giovane":
                    estaConvidado = true;
                    break;
                case "Catarina":
                    estaConvidado = true;
                    break;
                case "Osvaldo":
                    estaConvidado = true;
                    break;
                case "Flávia":
                    estaConvidado = true;
                    break;
                default:
                    estaConvidado = false;
                    break;
            } 
            
            if(estaConvidado == true && idade >= 18)
            {
                Console.WriteLine("Parabéns bem vindo a festa");
                return;
            }
            else if(estaConvidado == false)
            {
                Console.WriteLine("Você não está na lista de convidados, favor consultar com quem te convidou.");
            }
            else
            {
                Console.WriteLine("Você não tem 18 anos para entrar na festa");
            }
        }
    }
}
