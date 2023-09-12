using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class Animal
    {
        // atributo
        private string nome;

        // propriedade
        public string Nome { get; set; }

        // métodos
        public void Acordar()
        {
            Console.WriteLine("Acordei!");
        }
        public virtual void Comer ()
        {
            Console.WriteLine("Tô com fome!");
        }
        public void Dormir()
        {
            Console.WriteLine("Dormindo...");
        }
    }
}
