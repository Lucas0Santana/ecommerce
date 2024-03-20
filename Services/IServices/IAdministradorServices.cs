using ecommerce.Models;

namespace ecommerce.Services.IServices
{
    public interface IAdministradorServices
    {
        Task<bool> Criar(Administrador administrador);
        Task<Administrador?> Pesquisar(int id);
    }
}