using efetuar_pagamento.Classes;
using efetuar_pagamento.Enum;
using System;

namespace efetuar_pagamento
{
    class Program
    {
        static void Main(string[] produtos)
        {
            if (produtos.Length == 0)
            {
                Console.WriteLine("Nenhum produto foi listado pra compra");
                return;
            }
            Console.WriteLine("Favor informar a forma de pagamento(Boleto, Pix, CartãoDeCredito, Transferencia)");
            var formaDePagamentoDesejada = Console.ReadLine();

            if (string.IsNullOrEmpty(formaDePagamentoDesejada) || string.IsNullOrWhiteSpace(formaDePagamentoDesejada) || (tipo_pagamento_Enum.Boleto.ToString() != formaDePagamentoDesejada
                && tipo_pagamento_Enum.Pix.ToString() != formaDePagamentoDesejada
                && tipo_pagamento_Enum.CartãoDeCredito.ToString() != formaDePagamentoDesejada
                && tipo_pagamento_Enum.Tranferencia.ToString() != formaDePagamentoDesejada))
            {
                Console.WriteLine($"A forma de pagamento: {formaDePagamentoDesejada} não é válida");
                return;
            }
            forma_de_pagamento forma_de_pagamento;
            if (tipo_pagamento_Enum.Boleto.ToString() == formaDePagamentoDesejada)
            {
                forma_de_pagamento = new forma_de_pagamento_boleto();
            }else if (tipo_pagamento_Enum.Pix.ToString() == formaDePagamentoDesejada)
            {
                forma_de_pagamento = new forma_de_pagamento_pix();
            }else if (tipo_pagamento_Enum.CartãoDeCredito.ToString() == formaDePagamentoDesejada)
            {
                forma_de_pagamento = new forma_de_pagamento_cartaoDeCredito();
            }else if (tipo_pagamento_Enum.Tranferencia.ToString() == formaDePagamentoDesejada)
            {
                forma_de_pagamento = new forma_de_pagamento_transferencia();
            }
            else
            {
                Console.WriteLine($"A forma de pagamento: {formaDePagamentoDesejada} não é válida");
                return;
            }
            if(forma_de_pagamento != null)
            {
                forma_de_pagamento.efetuarPagamento();
            }
        }
    }
}
