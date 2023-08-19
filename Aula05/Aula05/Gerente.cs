
namespace Aula05
{
    public class Gerente
    {
        // Atributos
        public string nome;
        public long cpf;
        public double salario;

        //Construtor da classe
        public Gerente(long cpf, string nome, double salario)
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

        public void AumentarSalario(double taxa)
        {
            salario = salario + (salario * (taxa / 100));
        }
    }
}
