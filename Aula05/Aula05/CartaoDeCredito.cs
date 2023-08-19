namespace Aula05
{
    public class CartaoDeCredito
    {
        public int numero;
        public string dataDeValidade;
        public Cliente cliente;

        public CartaoDeCredito(int numero)
        {
            this.numero = numero;
        }
    }
}