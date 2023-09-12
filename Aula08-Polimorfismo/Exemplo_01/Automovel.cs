using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_01
{
    class Automovel : Veiculo
    {
        public Automovel(string tipoVeiculo) : base(tipoVeiculo)
        {
        }

        public override void Mover()
        {
            Console.WriteLine("Acelerando o Automóvel");
        }

        public override void Parar()
        {
            Console.WriteLine("Parando o Automóvel");
        }

    }
}
