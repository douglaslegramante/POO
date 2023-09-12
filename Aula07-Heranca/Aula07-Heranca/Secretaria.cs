using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07_Heranca
{
    class Secretaria : Funcionario
    {
        public int Ramal { get; set; }

        public override void MostrarDados()
        {
            Console.WriteLine("\n\t\t---Dados Secretária---");
            base.MostrarDados();
            Console.WriteLine("Ramal : " + Ramal);
        }

        /*
        public override string ToString()
        {
            return "\n\t\t---Dados da Secretária---"
            + "\nNome : " + Nome
            + "\nSalário : " + Salario
            + "\nUsuário : " + Ramal;
        }
        */
    }
}
