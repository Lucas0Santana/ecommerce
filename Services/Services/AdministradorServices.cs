using ecommerce.Models;
using ecommerce.Repository.IRepository;
using ecommerce.Services.IServices;
using Microsoft.EntityFrameworkCore;

namespace ecommerce.Services.Services
{
    public class AdministradorServices(IUnitOfWork unitOfWork) : IAdministradorServices
    {
        private readonly IUnitOfWork _IUOFW = unitOfWork;

        public async Task<bool> Criar(Administrador administrador)
        {
            _IUOFW.AdministradorRepository.Adicionar(administrador);
            await _IUOFW.Commit();
            return true;
        }

        public async Task<Administrador?> Pesquisar(int id)
        {
            return await _IUOFW.AdministradorRepository.Pesquisar(x => x.Id == id).FirstOrDefaultAsync();
        }
    }
}