using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            testarFuncionario();
        }

        static void testarFuncionario()
        {
            Funcionario func = new Funcionario();
            func.Nome = "Jo";
            func.Salario = 1199;
            

            Console.WriteLine("\t\t---Dados do Funcionário---\n");
            Console.WriteLine(func.Nome);
            Console.WriteLine(func.Salario.ToString("c2"));
            Console.ReadKey();
        }
    }
}
