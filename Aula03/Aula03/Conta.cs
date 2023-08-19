using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03
{
    public class Conta
    {
        public int numero;
        public decimal saldo;
        public decimal limite = 100;
        public Agencia agencia;

        public void Depositar(decimal valor)
        {
            saldo = saldo + valor;
        }
        public void Sacar(decimal valor)
        {
            saldo = saldo - valor;
        }
        public decimal ConsultarSaldo()
        {
            return saldo + limite;
        }
        public void ImprimeExtrato()
        {
            Console.WriteLine("Saldo: "+saldo.ToString("c2"));    
        }
    }
}
