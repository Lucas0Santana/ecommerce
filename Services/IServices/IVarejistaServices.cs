using ecommerce.Models;

namespace ecommerce.Services.IServices
{
    public interface IVarejistaServices
    {
        Task<bool> Criar(Varejista varejista);
        Task<Varejista?> Pesquisar(string cnpj);
    }
}