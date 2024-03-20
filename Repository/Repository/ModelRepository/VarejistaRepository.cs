using ecommerce.Data;
using ecommerce.Models;
using ecommerce.Repository.IRepository.IModelRepository;

namespace ecommerce.Repository.Repository.ModelRepository
{
    public class VarejistaRepository : Repository<Varejista>, IVarejistaRepository
    {
        public VarejistaRepository(Context context) : base(context)
        {
        }
    }
}