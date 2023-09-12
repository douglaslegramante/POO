using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07_Heranca
{
    class Telefonista : Funcionario
    {
        public int EstacaoDeTrabalho { get; set; }

        public override void MostrarDados()
        {
            Console.WriteLine("\n\t\t---Dados Telefonista---");
            base.MostrarDados();
            Console.WriteLine("Estação de trabalho: " + EstacaoDeTrabalho);
        }

        /*
        public override string ToString()
        {
            return "\n\t\t---Dados da Telefonista---"
            + "\nNome : " + Nome
            + "\nSalário : " + Salario
            + "\nUsuário : " + EstacaoDeTrabalho;
        }
        */
    }
}
