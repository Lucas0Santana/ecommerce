namespace ecommerce.Models
{
    public class Varejista
    {
        private readonly string _cnpj;
        private readonly int _idEndereco; 
        private readonly int _idCredenciais;


        public string CNPJ => _cnpj; 
        public int IdEndereco => _idEndereco;
        public int IdCredenciais => _idCredenciais;

        public Credenciais? Credenciais { get; set; }
        public Endereco? Endereco { get; set; }

        public Varejista(string cnpj, int idEndereco, int idCredenciais)
        {
            _cnpj = cnpj;
            _idEndereco = idEndereco;
            _idCredenciais = idCredenciais;
        }
        
    }
}