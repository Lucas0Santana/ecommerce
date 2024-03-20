namespace ecommerce.Models
{
    public class Endereco
    {
        private readonly int  _id;
        private readonly string  _rua;
        private readonly int  _numero;
        private readonly string  _complemento;
        private readonly string  _bairro;
        private readonly string  _cidade;
        private readonly string  _estado;
        private readonly string  _cep;
        // private readonly Cliente  _cliente;

        public int Id => _id;
        public string Rua => _rua;
        public int Numero => _numero;
        public string Complemento => _complemento;
        public string Bairro => _bairro;
        public string Cidade => _cidade;
        public string Estado => _estado;
        public string CEP => _cep;
        // public Cliente Cliente => _cliente;

        public Endereco(int id, string rua, int numero, string complemento, string bairro, string cidade, string estado, string cep)
        {
            _id = id;
            _rua = rua;
            _numero = numero;
            _complemento = complemento;
            _bairro = bairro;
            _cidade = cidade;
            _estado = estado;
            _cep = cep;
        }

    }
}
