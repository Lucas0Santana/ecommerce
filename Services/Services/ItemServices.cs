using ecommerce.Models;
using ecommerce.Repository.IRepository;
using ecommerce.Services.IServices;
using Microsoft.EntityFrameworkCore;

namespace ecommerce.Services.Services
{
    public class ItemServices(IUnitOfWork unitOfWork) : IItemServices
    {
        private readonly IUnitOfWork _IUOFW = unitOfWork;
        public async Task<bool> Criar(Item item)
        {
            if(await _IUOFW.ItemRepository.Existe(x => x.IdProduto == item.IdProduto))
            {
                return false;
            }
            _IUOFW.ItemRepository.Adicionar(item);
            await _IUOFW.Commit();
            return true;
        }

        public async Task<Item?> Pesquisar(int idProduto)
        {
            return await _IUOFW.ItemRepository.Pesquisar(x => x.Id == idProduto).FirstOrDefaultAsync();
        }
    }
}