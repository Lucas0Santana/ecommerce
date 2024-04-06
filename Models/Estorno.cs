namespace ecommerce.Models
{
    public class Estorno(int id, double valor, string cpfDestinatario, int idSolicitacaoDeEstorno)
    {   
        private readonly int _id = id;
        public int Id => _id;

        private readonly double _valor = valor;
        public double Valor => _valor;

        private readonly string _cpfDestinatario = cpfDestinatario;
        public string CPFDestinatario => _cpfDestinatario;

        private readonly int _idSolicitacaoDeEstorno = idSolicitacaoDeEstorno;
        public int IdSolicitacaoDeEstorno => _idSolicitacaoDeEstorno;
        public SolicitacaoDeEstorno? SolicitacaoDeEstorno { get; set;}
    }
}