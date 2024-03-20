using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ecommerce.Data;
using ecommerce.Models;
using ecommerce.Repository.IRepository.IModelRepository;

namespace ecommerce.Repository.Repository.ModelRepository
{
    public class AdministradorRepository : Repository<Administrador>, IAdministradorRepository
    {
        public AdministradorRepository(Context context) : base(context)
        {
        }
    }
}