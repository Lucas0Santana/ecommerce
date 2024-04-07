namespace ecommerce.Models
{
    public class SolicitacaoDeEstorno(int id, int CPF, int idTransacao, int idAdministrador)
    {

        public int Id {get; private set;} = id;

        public int CPF {get; private set;} = CPF;
        public Cliente? Cliente { get; set; }

        public int IdTransacao {get; private set;} = idTransacao;
        public Transacao? Transacao { get; set; }

        public int IdAdministrador {get; private set;} = idAdministrador;
        public Administrador? Administrador { get; set; }

    }
}