using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo[] veiculos = new Veiculo[2];
            veiculos[0] = new Automovel("Ferrari");
            veiculos[1] = new Aeronave("Boeing 737");


            MovimentarVeiculo(new Automovel("Yaris"));
            MovimentarVeiculo(new Aeronave("Air Buss 197"));


            Console.ReadKey();
        }

        public static void MovimentarVeiculo(Veiculo veiculo)
        {
            Console.WriteLine(veiculo.Tipo);
            veiculo.Mover();
            veiculo.Parar();
        }
    }
}
