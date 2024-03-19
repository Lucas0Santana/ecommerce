using ecommerce.Models;

namespace ecommerce.Services.IServices
{
    public interface IClienteServices
    {
        Task<bool> Criar(Cliente cliente);
        Task<Cliente?> Pesquisar(string cpf);
        Task<bool> AlternarStatus(string cpf);
    }
}