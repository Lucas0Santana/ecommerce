using ecommerce.Models;

namespace ecommerce.Services.IServices
{
    public interface IEnderecoServices
    {
        Task<bool> Criar(Endereco endereco);
        Task<Endereco?> Pesquisar(int id);
        Task<bool> Atualizar(Endereco endereco);
        Task<bool> Desativar(int id);
    }
}