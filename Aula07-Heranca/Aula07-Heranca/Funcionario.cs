using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07_Heranca
{
    class Funcionario
    {
        // Propriedades
        public string Nome { get; set; }
        public double Salario { get; set; }

        // Métodos
        public virtual double CalculaBonificacao()
        {
            return Salario * 0.1;
        }

        public virtual void MostrarDados()
        {
            Console.WriteLine("Nome : " + Nome);
            Console.WriteLine("Salário : " + Salario.ToString("c2"));           
            Console.WriteLine("Bonificação : " + CalculaBonificacao().ToString("c2"));
        }
    }
}
