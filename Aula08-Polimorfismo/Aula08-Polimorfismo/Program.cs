using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08_Polimorfismo
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
            g.Codigo = 4290;
            g.Nome = " Rafael Cosentino ";
            g.Salario = 2000;
            g.Usuario = " rafael . cosentino ";
            g.Senha = " 12345 ";

            Telefonista t = new Telefonista();
            t.Nome = " Carolina Mello ";
            t.Salario = 1000;
            t.EstacaoDeTrabalho = 13;

            Secretaria s = new Secretaria();
            s.Nome = " Tatiane Andrade ";
            s.Salario = 1500;
            s.Ramal = 198;

            Console.WriteLine(" GERENTE ");
            g.RegistraEntrada();
            Console.WriteLine(" Nome : " + g.Nome);
            Console.WriteLine(" Salário : " + g.Salario);
            Console.WriteLine(" Usuário : " + g.Usuario);
            Console.WriteLine(" Senha : " + g.Senha);
            Console.WriteLine(" Bonificação : " + g.CalculaBonificacao());
            g.RegistraSaida();

            Console.WriteLine(" TELEFONISTA ");
            t.RegistraEntrada();
            Console.WriteLine(" Nome : " + t.Nome);
            Console.WriteLine(" Salário : " + t.Salario);
            Console.WriteLine(" Estacao de trabalho : " + t.EstacaoDeTrabalho);
            Console.WriteLine(" Bonificação : " + t.CalculaBonificacao());
            t.RegistraSaida();

            Console.WriteLine(" SECRETARIA ");
            Console.WriteLine(" Nome : " + s.Nome);
            Console.WriteLine(" Salário : " + s.Salario);
            Console.WriteLine(" Ramal : " + s.Ramal);
            Console.WriteLine(" Bonificação : " + s.CalculaBonificacao());

            

        }
    }
}
