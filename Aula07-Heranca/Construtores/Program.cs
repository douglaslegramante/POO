using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores
{
    class Program
    {
        public class Forma
        {
            public const double PI = Math.PI; //campo constante
            protected double x, y;

            //public Forma()
            //{

            //}
            public Forma(double x, double y)
            {
                this.x = x;
                this.y = y;
            }

            public virtual double Area()
            {
                return x * y;
            }
        }

        public class Circulo : Forma
        {
            public Circulo(double r) : base(r, 0)
            {

            }

            public override double Area()
            {
                return PI * x * x;
            }
        }

        class Esfera : Forma
        {
            public Esfera(double r) : base(r, 0)
            {
            }

            public override double Area()
            {
                return 4 * PI * x * x;
            }
        }

        class Cilindro : Forma
        {
            public Cilindro(double r, double h) : base(r, h)
            {
            }

            public override double Area()
            {
                return 2 * PI * x * x + 2 * PI * x * y;
            }
        }

        static void Main()
        {
            double r = 3.0, h = 5.0;

            Forma circulo = new Circulo(r);
            Forma esfera = new Esfera(r);
            Forma cilindro = new Cilindro(r, h);
            
            //Resultados no Console:
            Console.WriteLine("Área do Circulo   = {0:F2}", circulo.Area());
            Console.WriteLine("Área do Esfera   = {0:F2}", esfera.Area());
            Console.WriteLine("Área do Cilindro = {0:F2}", cilindro.Area());

            Console.ReadKey();
        }
    }
}
/*
    Saída:
    Área do Circulo   = 28.27
    Área da Esfera   = 113.10
    Área do Cilindro = 150.80
*/
