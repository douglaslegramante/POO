using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07_Heranca
{
    class Gerente : Funcionario
    {
        public string Usuario { get; set; }
        public string Senha { get; set; }

        public override double CalculaBonificacao()
        {
            return Salario * 0.15;
        }

        public override void MostrarDados()
        {
            Console.WriteLine("\n\t\t---Dados Gerente---");
            base.MostrarDados();                   
            Console.WriteLine("Usuário : " + Usuario);
            Console.WriteLine("Senha : " + Senha);
        }

        /*
        public override string ToString()
        {
            return "\n\t\t---Dados do Gerente---"
            + "\nNome : " + Nome
            + "\nSalário : " + Salario
            + "\nUsuário : " + Usuario
            + "\nSenha : " + Senha
            + "\nBonificação : " + CalculaBonificacao();
        }
        */
    }
}
