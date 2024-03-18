using ecommerce.Data;
using ecommerce.Models;
using ecommerce.Repository.IRepository.IModelRepository;

namespace ecommerce.Repository.Repository.ModelRepository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(Context context) : base(context)
        {
        }
    }
}