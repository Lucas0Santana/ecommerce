namespace ecommerce.Models
{
    public class SolicitacaoDeEstorno(int id, int cpf, int idTransacao, int idAdministrador)
    {

        private readonly int _id = id;
        public int Id => _id;

        private readonly int _cpf = cpf;
        public int CPF => _cpf;
        public Cliente? Cliente { get; set; }

        private readonly int _idTransacao = idTransacao;
        public int IdTransacao => _idTransacao;
        public Transacao? Transacao { get; set; }

        private readonly int _idAdministrador = idAdministrador;
        public int IdAdministrador => _idAdministrador;
        public Administrador? Administrador { get; set; }

    }
}