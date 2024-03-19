using ecommerce.Repository.IRepository.IModelRepository;

namespace ecommerce.Repository.IRepository
{
    public interface IUnitOfWork
    {
        Task Commit();

        IClienteRepository ClienteRepository { get; }
        IEnderecoRepository EnderecoRepository { get; }
        ICredenciaisRepository CredenciaisRepository { get; }
    }
}