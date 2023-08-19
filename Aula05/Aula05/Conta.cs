using System;

namespace Aula05
{
    public class Conta
    {
        public int numero;
        public double saldo;
        public double limite = 100;
        public Agencia agencia;

        ////Construtor
        //public Conta(int numero,Agencia agencia)
        //{
        //    this.numero = numero;
        //    this.agencia = agencia;
        //}

        //Métodos 

        //private double saldo;

        public void Depositar(double valor)
        {
            saldo = saldo + valor;
            DescontarTarifa();
        }

        public void Sacar(double valor)
        {
            saldo = saldo - valor;
            DescontarTarifa();
        }

        private void DescontarTarifa()
        {
            saldo = saldo - 1;
        }

        public double ConsultarSaldo()
        {
            return saldo + limite;
        }

        public void ImprimeExtrato()
        {
            Console.WriteLine("Saldo: " + saldo.ToString("c2"));
        }

        public void Transferir (Conta destino, double valor)
        {
            saldo = saldo - valor;
            destino.saldo = destino.saldo + valor;
        }
    }

}