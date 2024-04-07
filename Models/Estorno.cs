namespace ecommerce.Models
{
    public class Estorno(int id, double valor, string cPFDestinatario, int idSolicitacaoDeEstorno)
    {   
        public int Id { get; private set; } = id;
        public double Valor { get; private set; } = valor;
        public string CPFDestinatario { get; private set; } = cPFDestinatario;
        public int IdSolicitacaoDeEstorno { get; private set; } = idSolicitacaoDeEstorno;
        
        public SolicitacaoDeEstorno? SolicitacaoDeEstorno { get; set;}
    }
}