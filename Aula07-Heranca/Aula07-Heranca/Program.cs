using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            TestarHeranca();

            Console.ReadKey();
        }

        static void TestarHeranca()
        {
            Gerente g = new Gerente();
            g.Nome = "Rafael Cosentino";
            g.Salario = 2000;
            g.Usuario = "rafae.cosentino";
            g.Senha = "12345";
            g.MostrarDados();

            Telefonista t = new Telefonista();
            t.Nome = " Carolina Mello ";
            t.Salario = 1000;
            t.EstacaoDeTrabalho = 13;
            t.MostrarDados();
            
            Secretaria s = new Secretaria();
            s.Nome = " Tatiane Andrade ";
            s.Salario = 1500;
            s.Ramal = 198;
            s.MostrarDados();
            
            /*
            Console.WriteLine(" GERENTE ");
            Console.WriteLine(" Nome : " + g.Nome);
            Console.WriteLine(" Salário : " + g.Salario);
            Console.WriteLine(" Usuário : " + g.Usuario);
            Console.WriteLine(" Senha : " + g.Senha);
            Console.WriteLine(" Bonificação : " + g.CalculaBonificacao());

            Console.WriteLine(" \nTELEFONISTA ");
            Console.WriteLine(" Nome : " + t.Nome);
            Console.WriteLine(" Salário : " + t.Salario);
            Console.WriteLine(" Estacao de trabalho : " + t.EstacaoDeTrabalho);
            Console.WriteLine(" Bonificação : " + t.CalculaBonificacao());

            Console.WriteLine(" \nSECRETARIA ");
            Console.WriteLine(" Nome : " + s.Nome);
            Console.WriteLine(" Salário : " + s.Salario);
            Console.WriteLine(" Ramal : " + s.Ramal);
            Console.WriteLine(" Bonificação : " + s.CalculaBonificacao());
            */
        }
    }
    /*
    class Funcionarios
    {
        public double Salario { get; set; }

        public virtual void AumentarSalario()
        {
            Salario = Salario + (Salario * 0.10);
        }
    }
    class Gerentes : Funcionarios
    {
        public override void AumentarSalario()
        {
            Salario = Salario + (Salario * 0.25);
        }

    }
    class Vendedores : Funcionarios
    {
        public override void AumentarSalario()
        {
            Salario = Salario + (Salario * 0.15);
        }
    }
    class Atendentes : Funcionarios
    {
        public override void AumentarSalario()
        {
            Salario = Salario + (Salario * 0.10);
        }
    }
    */

    /*
    public class Pai
    {
        public string Nome = "Arnaldo";
        public int Idade = 35;
    }

    public class Filha : Pai
    {
        public new string Nome = "Jaqueline";
        public new int Idade = 10;

        public void MostrarValores()
        {
            Console.WriteLine("Nome Filha: " + Nome);
            Console.WriteLine("Nome Pai: " + base.Nome);
            Console.WriteLine("Idade Filha: " + Idade);
            Console.WriteLine("Idade Pai: " + base.Idade);
        }
    }
    */

    class Quadrilatero
    {
        public string Nome { get; set; }


        public Quadrilatero(string nome)
        {
            Nome = nome;
        }
    }

    class Retangulo : Quadrilatero
    {
        public double Altura { get; set; }
        public double Largura { get; set; }

        public Retangulo(double altura, double largura) :base("Retângulo")
        {            
            Altura = altura;
            Largura = largura;
        }

        public double CalcularArea()
        {
            return Altura * Largura;
        }

        public double CalcularPerimetro()
        {
            return Largura * 2 + Altura * 2;
        }


    }
}
