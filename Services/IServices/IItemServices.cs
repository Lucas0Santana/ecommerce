using ecommerce.Models;

namespace ecommerce.Services.IServices
{
    public interface IItemServices
    {
        Task<bool> Criar(Item item);
        Task<Item?> Pesquisar(int idProduto);
    }
}