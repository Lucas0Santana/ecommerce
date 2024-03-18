using ecommerce.Data;
using ecommerce.Models;
using ecommerce.Repository.IRepository.IModelRepository;

namespace ecommerce.Repository.Repository.ModelRepository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(Context context) : base(context)
        {
        }
    }
}