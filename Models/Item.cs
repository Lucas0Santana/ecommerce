namespace ecommerce.Models
{
    public class Item(int id, int qtde, int idProduto)
    {
        public int Id { get; private set; } = id;
        public int Qtde { get; private set; } = qtde;
        public int IdProduto { get; private set; } = idProduto;

        public Produto Produto { get; set;}
    }
}