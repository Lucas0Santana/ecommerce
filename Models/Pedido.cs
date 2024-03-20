namespace ecommerce.Models
{
    public class Pedido
    {
        private readonly int _id;
        private readonly double _valor;   
        private readonly DateOnly _data;
        private readonly double _frete;
        private readonly char _status;
        private readonly string _cnpj;
        private readonly string _cpf;
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
        
        public Pedido(int id, double valor, DateOnly data, double frete, char status)
        {
            _id = id;
            _valor = valor;
            _data = data;
            _frete = frete;
            _status = status;
        }

    }
}