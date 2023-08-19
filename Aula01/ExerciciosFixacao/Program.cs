using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            TestarClasseCliente();
            TestarClasseCartaoDeCredito();
            TestarClasseCliente();
            TestarClasseConta();

            Console.ReadKey();
        }

        static void TestarClasseCliente()
        {
            // Testa classe cliente
            Cliente c1 = new Cliente();
            c1.nome = " Rafael Cosentino ";
            c1.codigo = 1;

            Cliente c2 = new Cliente();
            c2.nome = " Jonas Hirata ";
            c2.codigo = 2;

            Console.WriteLine(" Dados do primeiro cliente ");
            Console.WriteLine(" Nome : " + c1.nome);
            Console.WriteLine(" Código : " + c1.codigo);

            Console.WriteLine(" ----------------------------------------");

            Console.WriteLine(" Dados do segundo cliente ");
            Console.WriteLine(" Nome : " + c2.nome);
            Console.WriteLine(" Código : " + c2.codigo);

            Console.WriteLine();
        }

        static void TestarClasseCartaoDeCredito()
        {
            CartaoDeCredito cdc1 = new CartaoDeCredito();
            cdc1.numero = 111111;
            cdc1.dataDeValidade = " 01/01/2013 ";

            CartaoDeCredito cdc2 = new CartaoDeCredito();
            cdc2.numero = 222222;
            cdc2.dataDeValidade = " 01/01/2014 ";

            Console.WriteLine(" Número : " + cdc1.numero);
            Console.WriteLine(" Data de validade : " + cdc1.dataDeValidade);

            Console.WriteLine(" ----------------------------------------");

            Console.WriteLine(" Dados do segundo cartão ");
            Console.WriteLine(" Número : " + cdc2.numero);
            Console.WriteLine(" Data de validade : " + cdc2.dataDeValidade);

            Console.WriteLine();
        }

        static void TestarClasseAgencia()
        {
            Agencia a1 = new Agencia();
            a1.numero = 1234;

            Agencia a2 = new Agencia();
            a2.numero = 5678;

            Console.WriteLine(" Dados da primeira agência ");
            Console.WriteLine(" Número : " + a1.numero);

            Console.WriteLine(" ----------------------------------------");

            Console.WriteLine(" Dados da segunda agência ");
            Console.WriteLine(" Número : " + a2.numero);

            Console.WriteLine();
        }

        static void TestarClasseConta()
        {
            Conta c1 = new Conta();
            c1.numero = 1234;
            c1.saldo = 1000;
            

            Conta c2 = new Conta();
            c2.numero = 5678;
            c2.saldo = 2000;
            c2.limite = 250;

            Console.WriteLine(" Dados da primeira conta ");
            Console.WriteLine(" Número : " + c1.numero);
            Console.WriteLine(" Saldo : " + c1.saldo);
            Console.WriteLine(" Limite : " + c1.limite);

            Console.WriteLine(" ----------------------------------------");

            Console.WriteLine(" Dados da segunda conta ");
            Console.WriteLine(" Número : " + c2.numero);
            Console.WriteLine(" Saldo : " + c2.saldo);
            Console.WriteLine(" Limite : " + c2.limite);

            Console.WriteLine();
        }
    }
}
