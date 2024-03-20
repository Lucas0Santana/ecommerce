namespace ecommerce.Models
{
    public class Item
    {
        private readonly int _id;
        public int Id => _id;
        
        private readonly int _qtde;
        public int Qtde => _qtde;

        private readonly int _idProduto;
        public int IdProduto => _idProduto;
        private readonly Produto? Produto;

        public Item(int id, int qtde, int idProduto, Produto produto)
        {
            _id = id;
            _qtde = qtde;
            _idProduto = idProduto;
            Produto = produto;
        }        

    }
}