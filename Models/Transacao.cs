namespace ecommerce.Models
{
    public class Transacao(int id, double valor)
    {
        private readonly int _id = id;
        public int Id => _id;

        private readonly double _valor = valor;
        public double Valor => _valor;
    }
}