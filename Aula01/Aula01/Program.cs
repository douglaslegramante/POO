using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            // intancia uma nova Conta - cria um novo objeto do tipo Conta
            new Conta();

            // intancia uma nova Conta e guarda a referencia do objeto na variavel contaMaria
            Conta contaMaria = new Conta();

            //Manipulando os atributos da contaMaria
            contaMaria.numero = 10225;
            contaMaria.saldo = 500;
            contaMaria.limite = 100;

            //Imprimindo os atributos da contaMaria
            Console.WriteLine("Numero da conta: " + contaMaria.numero);
            Console.WriteLine("Saldo: R$" + contaMaria.saldo);
            Console.WriteLine("Limite: R$" + contaMaria.limite);

            Console.ReadKey();
        }
    }
}
