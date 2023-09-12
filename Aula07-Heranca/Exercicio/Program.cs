using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Baleia baleia = new Baleia();
            baleia.Comer();
            baleia.Acordar();
            baleia.Dormir();
            baleia.Mamar();
            baleia.Nome = "Preciosa";
            Console.ReadKey();
        }
    }
}
