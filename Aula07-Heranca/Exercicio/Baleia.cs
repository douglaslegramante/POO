using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class Baleia : Mamifero
    {
        public void Nadar ()
        {
            Console.WriteLine("Nadando...");
        }

        public override void Comer()
        {
            Console.WriteLine("Eu me alimento de peixes!");
        }
    }
}
