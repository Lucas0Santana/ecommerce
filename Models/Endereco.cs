namespace ecommerce.Models
{
    public class Endereco
    {
        private int Id { get; set; }
        private string Rua { get; set; }
        private int Numero { get; set; }
        private string Complemento { get; set; }
        private string Bairro { get; set; }
        private string Cidade { get; set; }
        private string Estado { get; set; }
        private string CEP { get; set; }
        private Cliente Cliente { get; set; }

        public Endereco(int id, string rua, int numero, string complemento, string bairro, string cidade, string estado, string cep)
        {
            Id = id;
            Rua = rua;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            CEP = cep;
        }

        // Propriedades públicas para acessar os campos privados
        public int GetId() 
        {
            return Id;
        }

    }
}
