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
    }
}