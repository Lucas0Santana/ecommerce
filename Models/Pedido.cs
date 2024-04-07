namespace ecommerce.Models
{
    public class Pedido(int id, double valor, DateOnly data, double frete, char status, string CNPJ, string CPF, int idTransacao)
    {

        public int Id {get; private set;} = id;
        public double Valor {get; private set;} = valor;   
        public DateOnly Data {get; private set;} = data;
        public double Frete {get; private set;} = frete;
        public char Status {get; private set;} = status;     
        public string CNPJ {get; private set;} = CNPJ;
        public string CPF {get; private set;} = CPF;
        public int IdTransacao {get; private set;} = idTransacao;


        public Cliente? Cliente { get; set; }
        public Varejista? Varejista { get; set; }
        public Transacao? Transacao { get; set; }
    }
}