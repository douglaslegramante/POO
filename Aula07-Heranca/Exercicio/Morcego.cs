using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class Morcego : Mamifero
    {
        public void Voar()
        {
            Console.WriteLine("Voando...");
        }

        public override void Comer()
        {
            Console.WriteLine("Eu me alimento de frutas!");
        }
    }
}
