using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_01
{
    class Aeronave : Veiculo
    {
        public Aeronave(string tipoVeiculo) : base(tipoVeiculo)
        {
        }

        public override void Mover()
        {
            Console.WriteLine("Decolando a Aeronave");
        }

        public override void Parar()
        {
            Console.WriteLine("Aterrisando a Aeronave");
        }
    }
}
