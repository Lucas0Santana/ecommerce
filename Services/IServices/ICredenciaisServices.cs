namespace ecommerce.Services.IServices
{
    public interface ICredenciaisServices
    {
        Task<bool> AlternarStatus(int id);
        Task<bool> Criar(Credenciais credenciais);
        Task<bool> Atualizar(Credenciais credenciais);
    }
}