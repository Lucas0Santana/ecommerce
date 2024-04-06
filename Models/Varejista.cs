namespace ecommerce.Models
{
    public class Varejista(string cnpj, int idEndereco, int idCredenciais)
    {
        private readonly string _cnpj = cnpj;
        private readonly int _idEndereco = idEndereco; 
        private readonly int _idCredenciais = idCredenciais;


        public string CNPJ => _cnpj; 
        public int IdEndereco => _idEndereco;
        public int IdCredenciais => _idCredenciais;

        public Credenciais? Credenciais { get; set; }
        public Endereco? Endereco { get; set; }
    }
}