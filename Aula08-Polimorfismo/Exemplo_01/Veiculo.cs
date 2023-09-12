using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_01
{
    class Veiculo
    {
        public string Tipo { get; set; } //encapsulamento

        public Veiculo(string tipoVeiculo) //construtor
        {
            Tipo = tipoVeiculo;
        }

        public virtual void Mover() //método
        {
            Console.WriteLine("Acelerando...");
        }

        public virtual void Parar()
        {
            Console.WriteLine("Parando...");
        }
    }
}
