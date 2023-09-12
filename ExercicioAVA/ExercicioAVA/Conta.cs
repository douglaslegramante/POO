using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAVA
{
    public class Conta
    {
        public int numero;
        public decimal saldo;
        public decimal limite;
        public Agencia agencia;
        public Cliente cliente;

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
            Console.WriteLine("Saldo: " + saldo.ToString("c2"));
        }
    }
}
