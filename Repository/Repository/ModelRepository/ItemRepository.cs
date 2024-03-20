using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ecommerce.Data;
using ecommerce.Models;
using ecommerce.Repository.IRepository.IModelRepository;

namespace ecommerce.Repository.Repository.ModelRepository
{
    public class ItemRepository : Repository<Item>, IItemRepository
    {
        public ItemRepository(Context context) : base(context)
        {
        }
    }
}