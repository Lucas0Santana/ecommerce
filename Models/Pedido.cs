namespace ecommerce.Models
{
    public class Pedido(int id, double valor, DateOnly data, double frete, char status, string cnpj, string cpf, int idTransacao)
    {
        private readonly int _id = id;
        private readonly double _valor = valor;   
        private readonly DateOnly _data = data;
        private readonly double _frete = frete;
        private readonly char _status = status;
        private readonly string _cnpj = cnpj;
        private readonly string _cpf = cpf;
        private readonly int _idTransacao;


        public int Id => _id;
        public double Valor => _valor;   
        public DateOnly Data => _data;
        public double Frete => _frete;
        public char Status => _status;
        public string CNPJ => _cnpj;
        public string CPF => _cpf;
        public int IdTransacao => _idTransacao;


        public Cliente? Cliente { get; set; }
        public Varejista? Varejista { get; set; }
        public Transacao? Transacao { get; set; }
    }
}