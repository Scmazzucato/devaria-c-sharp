using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_de_animais.Classes
{
    class Animal
    {
        public string Nome { get; set; }
    }

    class Mamiferos : Animal
    {
        public int QuantidadeDeMamas { get; set; }
    }

    class Reptil : Animal
    {
        public bool ControlaTemperaturaDoCorpo { get; set; } = false;
    }
    class Aves : Animal
    {
        public bool temPena { get; set; } = true;
    }
    class Peixes : Animal
    {
        public int quantidadeDeNadadeiras { get; set; }
    }
    
}
