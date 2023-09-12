using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    abstract class Conta
    {
        public decimal Saldo { get; set; }
        public abstract void Depositar(decimal valor);
        public abstract void Transferir(Conta destino, decimal valor);

        public abstract void Sacar(decimal valor);

        public abstract void ImprimeExtrato();
    }
}
