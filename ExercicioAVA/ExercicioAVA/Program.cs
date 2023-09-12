using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAVA
{
    class Program
    {
        static void Main(string[] args)
        {

            // Criando um objeto de cada classe
            Cliente c = new Cliente();
            //CartaoDeCredito cdc = new CartaoDeCredito();
            Conta ct = new Conta();
            Agencia ag = new Agencia();


            // Acessando os atributos
            c.nome = "Douglas Legramante";
            c.codigo = 0711;
            //cdc.numero = 52543467;
            //cdc.dataDeValidade = "12/12/18";
            ct.numero = 45678;
            ct.saldo = 850;
            ct.limite = 100;

            ag.numero = 1825;

            // Ligando os objetos
            //cdc.conta = ct;
            ct.agencia = ag;
            ct.cliente = c;

            do
            {
                Console.WriteLine("\t\t---Banco Digital---");
                Console.Write("\n(1)Sacar \n(2)Depositar \n(3)Imprimir extrato " +
                    "\n(4)Consultar Saldo \n(5)Sair \n\nEscolha uma opção: ");
                int op = int.Parse(Console.ReadLine());
                decimal valor = 0;

                switch (op)
                {
                    case 1:
                        Console.Write("\nInforme o valor: ");
                        valor = decimal.Parse(Console.ReadLine());
                        ct.Sacar(valor);
                        Console.WriteLine("Você sacou: " + valor.ToString("c2"));
                        Console.WriteLine("Operação realizada com sucesso!");
                        break;
                    case 2:
                        Console.Write("\nInforme o valor: ");
                        valor = decimal.Parse(Console.ReadLine());
                        ct.Depositar(valor);
                        Console.WriteLine("Operação realizada com sucesso!");
                        break;
                    case 3:
                        ct.ImprimeExtrato();
                        break;
                    case 4:
                        decimal saldo = ct.ConsultarSaldo();
                        Console.WriteLine("\nSeu saldo é: " + saldo.ToString("c2"));
                        break;
                    case 5:
                        Console.WriteLine("\nFinalizando...");
                        Console.WriteLine("Precione qualquer tecla para fechar...");
                        Console.ReadKey();
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("\nInforme uma opção entre 1 e 5");
                        break;
                }                
                Console.WriteLine("\nPrecione uma tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            } while (true);

        }
    }
}
