using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class ContaCorrente : Conta
    {
        public decimal Limite { get; set; }


        public override void Sacar(decimal valor)
        {
            Saldo = Saldo - valor;
        }

        public override void Depositar(decimal valor)
        {
            Saldo = Saldo + valor;
        }

        public override void Transferir(Conta destino, decimal valor)
        {
            Saldo = Saldo - valor;
            destino.Saldo = destino.Saldo + valor;
        }

        public override void ImprimeExtrato()
        {
            DateTime agora = DateTime.Now;
            string horario = String.Format("{0:dd/MM/yyyy HH:mm:ss}", agora);
            Console.WriteLine("Data: " + horario);
            Console.WriteLine("Saldo: " + Saldo.ToString("c2"));
            Console.WriteLine("Limite: " + Limite.ToString("c2"));
        }
    }
}
