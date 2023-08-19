using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05
{
    class Funcionario
    {
        // Encapsulamento
        private double salario;

        public double Salario { get; set; }

        // Métodos para acesso
        public double LerSalario
        {
            get
            {
                return Salario;
            }
        }

        public double GravarSalario
        {
            set
            {
                Salario = value;
            }
        }

 
        //public double Salario { get; set; }

        //public double Salario { get => salario; set => salario = value; }


        // Propriedade


        //public double Salario {get; set;}

        //public double LerSalario
        //{
        //    get
        //    {
        //        return salario;
        //    }

        //}
        //public double GravarSalario
        //{
        //    set
        //    {
        //        salario = value;
        //    }
        //}


        //public double Salario
        //{
        //    get
        //    {
        //        return salario;
        //    }
        //    set
        //    {
        //        salario = value;
        //    }
        //}

        public void AumentarSalario(double aumento)
        {
            // Lógica para aumentar o salário
        }
    }
}
