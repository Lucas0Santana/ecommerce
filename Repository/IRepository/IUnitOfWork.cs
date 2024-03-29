using ecommerce.Repository.IRepository.IModelRepository;

namespace ecommerce.Repository.IRepository
{
    public interface IUnitOfWork
    {
        Task Commit();

        IClienteRepository ClienteRepository { get; }
        IEnderecoRepository EnderecoRepository { get; }
        ICredenciaisRepository CredenciaisRepository { get; }
        IVarejistaRepository VarejistaRepository { get; }
        IAdministradorRepository AdministradorRepository { get; }
        IProdutoRepository ProdutoRepository { get; }
        IItemRepository ItemRepository { get; }
        IPedidoRepository PedidoRepository { get; }
    }
}