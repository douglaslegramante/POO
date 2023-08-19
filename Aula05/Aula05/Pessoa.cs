using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05
{
    public class Pessoa
    {
        public string nome;
        public string rg;
        public int cpf;


        public Pessoa(string rg)
        {
            this.rg = rg;
        }

        public Pessoa(int cpf)
        {
            this.cpf = cpf;
        }

        public Pessoa (string nome, int cpf) :this(cpf)
        {
            this.nome = nome;
        }

        // Chamando o primeiro construtor
        //Pessoa p1 = new Pessoa(" 123456 X");

        // Chamando o segundo construtor
        //Pessoa p2 = new Pessoa(123456789);

        //Pessoa p3 = new Pessoa("12345-01");

    }
}
