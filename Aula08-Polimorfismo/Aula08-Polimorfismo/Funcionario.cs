using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08_Polimorfismo
{
    abstract class Funcionario : IControleDePonto
    {
        // Propriedades

        public int Codigo { get; set; } // Adicionado
        public string Nome { get; set; }
        public double Salario { get; set; }

        // Métodos
        public virtual double CalculaBonificacao()
        {
            return Salario * 0.1;
        }

        public void RegistraEntrada()
        {
            DateTime agora = DateTime.Now;
            string horario = String.Format(" {0: d/M/yyyy HH:mm:ss}", agora);
            Console.WriteLine(" ENTRADA : " + Codigo);
            Console.WriteLine(" DATA : " + horario);
        }

        public void RegistraSaida()
        {
            DateTime agora = DateTime.Now;
            string horario = String.Format(" {0: d/M/ yyyy HH:mm:ss}", agora);
            Console.WriteLine(" SAÍDA : " + Codigo);
            Console.WriteLine(" DATA : " + horario);
        }
    }
}
