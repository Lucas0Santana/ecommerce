namespace ecommerce.Models
{
    public class Endereco(int id, string rua, int numero, string complemento, string bairro, string cidade, string estado, string CEP)
    {
        public int Id { get; private set; } = id;
        public string Rua { get; private set; } = rua;
        public int Numero { get; private set; } = numero;
        public string Complemento { get; private set; } = complemento;
        public string Bairro { get; private set; } = bairro;
        public string Cidade { get; private set; } = cidade;
        public string Estado { get; private set; } = estado;
        public string CEP { get; private set; } = CEP;
    }
}