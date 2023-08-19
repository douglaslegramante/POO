using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComplementares
{
    class Program
    {
        static void Main(string[] args)
        {

            TestarAluno();
            TestarFuncionario();

            Console.ReadKey();
        }

        static void TestarAluno()
        {
            // Testa classe Aluno
            Aluno aluno1 = new Aluno();
            aluno1.nome = "Felipe Melo";
            aluno1.rg = 123432;
            aluno1.dataDeNascimento = "06/06/1996";

            Aluno aluno2 = new Aluno();
            aluno2.nome = "Ana Paula";
            aluno2.rg = 546432;
            aluno2.dataDeNascimento = "21/02/1990";

            Console.WriteLine("Dados do primeiro aluno");
            Console.WriteLine("Nome: " + aluno1.nome);
            Console.WriteLine("RG: " + aluno1.rg);
            Console.WriteLine("Data de Nascimento: " + aluno1.dataDeNascimento);

            Console.WriteLine(" ----------------------------------------");

            Console.WriteLine("Dados do segundo aluno");
            Console.WriteLine("Nome: " + aluno2.nome);
            Console.WriteLine("RG: " + aluno2.rg);
            Console.WriteLine("Data de Nascimento: " + aluno2.dataDeNascimento);

            Console.WriteLine();
        }

        static void TestarFuncionario()
        {
            // Testa classe Funcionario
            Funcionario funcionario1 = new Funcionario();
            funcionario1.nome = "Felipe Melo";
            funcionario1.salario = 1850;

            Funcionario funcionario2 = new Funcionario();
            funcionario2.nome = "Ana Paula";
            funcionario2.salario = 1620;

            Console.WriteLine("Dados do primeiro funcionario");
            Console.WriteLine("Nome: " + funcionario1.nome);
            Console.WriteLine("Salário: " + funcionario1.salario);

            Console.WriteLine(" ----------------------------------------");

            Console.WriteLine("Dados do segundo funcionario");
            Console.WriteLine("Nome: " + funcionario2.nome);
            Console.WriteLine("Salário: " + funcionario2.salario);

            Console.WriteLine();
        }
    }
}
