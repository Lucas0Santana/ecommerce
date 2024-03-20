using ecommerce.Models;

namespace ecommerce.Services.IServices
{
    public interface IPedidoServices
    {
        public Task<bool> Criar(Pedido pedido);
        public Task<Pedido?> Pesquisar(int id);        
    }
}