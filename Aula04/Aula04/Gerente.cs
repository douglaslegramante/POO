using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04
{
    public class Gerente
    {
        // Atributos
        public string nome;
        public long cpf;
        public decimal salario;

        //Construtor da classe
        public Gerente (long cpf, string nome, decimal salario)
        {
            this.cpf = cpf;
            this.nome = nome;
            this.salario = salario;
        }
        
        // Métodos
        public void AumentarSalario()
        {
            AumentarSalario(10);
        }

        public void AumentarSalario(decimal taxa)
        {
            salario = salario + (salario * (taxa/100)); 
        }
    }
}
