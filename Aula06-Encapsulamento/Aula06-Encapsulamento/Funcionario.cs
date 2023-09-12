using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06_Encapsulamento
{
    class Funcionario
    {
        private string nome;
        private double salario;

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                if(value.Length >= 3)
                {
                    nome = value;
                }
                else
                {
                    Console.WriteLine("Nome inválido!");
                }
            }
        }

        public double Salario
        {
            get
            {
                return salario;
            }
            set 
            {
                if (value >= 1200)
                {
                    salario = value;
                }
                else
                {
                    Console.WriteLine("Valor do salário é inferior ao minímo!");
                }
            }
        }
        //public double Salario { get => salario; set => salario = value; }
        //public string Nome { get => nome; set => nome = value; }

        //public string Nome { get; set; }
        //public double Salario { get; set; }



        //public string getNome() //Método para leitura = get
        //{
        //    return nome;
        //}
        //public void setNome(string nome) //Método para escrita = set
        //{
        //    this.nome = nome;
        //}

        /*
         public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("Nome inválido!");
                }
                else
                {
                    nome = value;
                }
            }
         */

        /*
        public double Salario
        {
            get
            {
                return salario;
            }
            set
            {
                if (value >= 1045.00)
                {
                    salario = value;
                }
                else
                {
                    Console.WriteLine("Valor do salário é inferior ao minímo!");
                }

            }
        }
        */

    }
}
