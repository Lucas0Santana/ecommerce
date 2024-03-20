using ecommerce.Data;
using ecommerce.Repository.IRepository;
using ecommerce.Repository.IRepository.IModelRepository;
using ecommerce.Repository.Repository.ModelRepository;

namespace ecommerce.Repository.Repository.ModelsRepository
{
    public class UnitOfWork(Context contexto) : IUnitOfWork
    {
        public Context _context = contexto;

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }
        public void Dispose()
        {
            _context.Dispose();
        }

        private ClienteRepository? _clienteRepo;
        public IClienteRepository ClienteRepository => _clienteRepo ??= new ClienteRepository(_context);
        
        private EnderecoRepository? _EnderecoRepo;
        public IEnderecoRepository EnderecoRepository => _EnderecoRepo ??= new EnderecoRepository(_context);

        private CredenciaisRepository? _CredenciaisRepo;
        public ICredenciaisRepository CredenciaisRepository => _CredenciaisRepo ??= new CredenciaisRepository(_context);
        
        private VarejistaRepository? _VarejistaRepo;
        public IVarejistaRepository VarejistaRepository => _VarejistaRepo ??= new VarejistaRepository(_context);

        private AdministradorRepository? _AdministradorRepo;
        public IAdministradorRepository AdministradorRepository => _AdministradorRepo ??= new AdministradorRepository(_context);
        
        private ProdutoRepository? _ProdutoRepo;
        public IProdutoRepository ProdutoRepository => _ProdutoRepo ??= new ProdutoRepository(_context);
        
        private ItemRepository? _ItemRepo;
        public IItemRepository ItemRepository => _ItemRepo ??= new ItemRepository(_context);
        
        private PedidoRepository? _PedidoRepo;
        public IPedidoRepository PedidoRepository => _PedidoRepo ??= new PedidoRepository(_context);

    }
}