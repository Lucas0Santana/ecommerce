namespace ecommerce.Models
{
    public class Administrador
    {
        private readonly int _id;
        public int Id => _id;

        private readonly int _idCredenciais;
        public int IdCredenciais => _idCredenciais;

        ICollection<SolicitacaoDeEstorno>? SolicitacaoDeEstornos {get; set;}

        public Administrador(int id)
        {
            _id = id;
        }
    }
}