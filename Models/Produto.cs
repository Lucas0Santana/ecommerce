namespace ecommerce.Models
{
    public class Produto
    {
        private readonly int _id;
        private readonly string _nome;
        private readonly double _preco;
        private readonly string _descricao;
        private bool _status;
        private readonly string _cnpj;

        public int Id => _id;
        public string Nome => _nome;
        public double Preco => _preco;
        public string Descricao => _descricao;
        public bool Status => _status;
        public string Cnpj => _cnpj;


        public Produto(int id, string nome, double preco, string descricao, bool status)
        {
            _id = id;
            _nome = nome;
            _preco = preco;
            _descricao = descricao;
            _status = status;
        }

        public void SetStatus()
        {
            _status = !_status;
        }

    }
}