using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05
{
    class Program
    {
        static void Main(string[] args)
        {
            TestarEncapsulamento();
            //TestarTudo();
            //TestarGerente();

            Console.ReadKey();
        }

        public static void TestarEncapsulamento()
        {
            Conta Igor = new Conta();
            Igor.saldo = 500;

            Conta Eduarda = new Conta();
            Eduarda.saldo = 100;

            Igor.Transferir(Eduarda, 150);


            Console.WriteLine(Igor.saldo);
            Console.WriteLine(Eduarda.saldo);

        }

        public static void TestarTudo()
        {

            //Criando um objeto de cada classe

            Conta Maria = new Conta();
            Maria.limite = 500;
            Conta joao = new Conta();
            joao.limite = 300;

            joao = Maria;

            joao.limite = 150;
            Maria.limite = 200;
            Console.WriteLine(joao.limite);
            Console.WriteLine(Maria.limite);

            Maria.Depositar(300);
            double retorno = Maria.ConsultarSaldo();
            Console.WriteLine("Seu saldo é: " + retorno.ToString("c2"));

            Cliente c = new Cliente();
            CartaoDeCredito cdc = new CartaoDeCredito(52563100);
            Agencia ag = new Agencia(1825);

            Conta ct = new Conta();

            Endereco end = new Endereco();

            double pegaretorno = ct.ConsultarSaldo();
            Console.WriteLine("Seu saldo é : " + pegaretorno.ToString("c2"));

            //Acessando os atributos
            c.nome = "Rafael Andrade";
            c.codigo = 123;
            cdc.dataDeValidade = "12/12/18";
            ct.numero = 45678;
            ct.saldo = 500;
            ct.limite = 100;
            end.logradouro = "Avenida Paraná";
            end.numero = 2345;
            end.bairro = "Centro";

            Console.WriteLine("Dados do cliente");
            Console.WriteLine("Nome: " + c.nome);
            Console.WriteLine("Código: " + c.codigo);

            Console.WriteLine(" ----------------------------------------");

            Console.WriteLine("Dados do cartão");
            Console.WriteLine("Número: " + cdc.numero);
            Console.WriteLine("Data de validade: " + cdc.dataDeValidade);

            Console.WriteLine(" ----------------------------------------");

            Console.WriteLine("Dados da conta");
            Console.WriteLine("Número: " + ct.numero);
            Console.WriteLine("Saldo: " + ct.saldo);
            Console.WriteLine("Limite: " + ct.limite);

            Console.WriteLine(" ----------------------------------------");

            Console.WriteLine("Dados da agencia");
            Console.WriteLine("Número: " + ag.numero);

            Console.WriteLine(" ----------------------------------------");

            Console.WriteLine("Dados do endereço");
            Console.WriteLine("Logradouro: " + end.logradouro);
            Console.WriteLine("Número: " + end.numero);
            Console.WriteLine("Bairro: " + end.bairro);

            Console.WriteLine(" ----------------------------------------");

            // Ligando os objetos
            cdc.cliente = c;
            ct.agencia = ag;
            end.cliente = c;

            Console.WriteLine("Dados do cliente obtidos através do cartão");
            Console.WriteLine("Nome do cliente: " + cdc.cliente.nome);
            Console.WriteLine("Código do cliente: " + cdc.cliente.codigo);
            Console.WriteLine(" ----------------------------------------");
            Console.WriteLine("Dados da agencia obtidos através da conta");
            Console.WriteLine("Número da agencia: " + ct.agencia.numero);
            Console.WriteLine(" ----------------------------------------");
            Console.WriteLine("Dados do cliente obtidos através do endereço");
            Console.WriteLine("Código do cliente: " + end.cliente.codigo);
            Console.WriteLine("Nome do cliente: " + end.cliente.nome);

            Console.WriteLine(" ----------------------------------------\n");
        }

        public static void TestarGerente()
        {

            Gerente g = new Gerente(00011133388, "Daniel", 1500);

            do
            {
                Console.Write("Informe o nome do gerente: ");
                g.nome = Console.ReadLine();
                Console.Write("Informe o salário do gerente: ");
                g.salario = double.Parse(Console.ReadLine());

                //Console.WriteLine("Salário: " + g.salario);
                Console.Write("1 - Aumento fixo \n2 - Aumento variavel \n3 - Sair \nEscolha uma opção: ");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.WriteLine("\nAumentando o salário em 10% ");
                        g.AumentarSalario();
                        Console.WriteLine("Salário atual: " + g.salario.ToString("c2"));
                        break;
                    case 2:
                        Console.Write("\nInforme a porcentagem para o reajuste: ");
                        double pct = double.Parse(Console.ReadLine());
                        Console.WriteLine("\nAumentando o salário em " + pct);
                        g.AumentarSalario(pct);
                        Console.WriteLine("Salário atual: " + g.salario.ToString("c2"));
                        break;
                    case 3:
                        Console.WriteLine("Tecle qualquer tecla para sair...");
                        Console.ReadKey();
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Escolha uma opção válida!!!");
                        break;
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();

            } while (true);
        }
    }

}

