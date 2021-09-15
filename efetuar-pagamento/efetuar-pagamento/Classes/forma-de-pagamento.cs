using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efetuar_pagamento.Classes
{
    class forma_de_pagamento
    {
        public virtual void efetuarPagamento()
        {
            Console.WriteLine("Pagamento Efeuado");
        }
    }
    class forma_de_pagamento_boleto : forma_de_pagamento
    {
        public override void efetuarPagamento()
        {
            Console.WriteLine("Pagamento Efetuado com boleto");
        }
    }
    class forma_de_pagamento_pix : forma_de_pagamento
    {
        public override void efetuarPagamento()
        {
            Console.WriteLine("Pagamento Efetuado com pix");
        }
    }
    class forma_de_pagamento_cartaoDeCredito : forma_de_pagamento
    {
        public override void efetuarPagamento()
        {
            Console.WriteLine("Pagamento Efetuado com cartão de crédito");
        }
    }
    class forma_de_pagamento_transferencia : forma_de_pagamento
    {
        public override void efetuarPagamento()
        {
            Console.WriteLine("Pagamento Efetuado com tranferencia");
        }
    }

}
