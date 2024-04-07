namespace ecommerce.Models
{
    public class Varejista(string CNPJ, int idEndereco, int idCredenciais)
    {
        public string CNPJ  { get; private set; } = CNPJ;
        public int IdEndereco  { get; private set; } = idEndereco;
        public int IdCredenciais  { get; private set; } = idCredenciais;

        public Credenciais? Credenciais { get; set; }
        public Endereco? Endereco { get; set; }
    }
}