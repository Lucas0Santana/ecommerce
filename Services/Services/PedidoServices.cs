using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ecommerce.Models;
using ecommerce.Repository.IRepository;
using ecommerce.Services.IServices;
using Microsoft.EntityFrameworkCore;

namespace ecommerce.Services.Services
{
    public class PedidoServices(IUnitOfWork unitOfWork) : IPedidoServices
    {
        private readonly IUnitOfWork _IUOFW = unitOfWork;
        public async Task<bool> Criar(Pedido pedido)
        {
            _IUOFW.PedidoRepository.Adicionar(pedido);
            await _IUOFW.Commit();
            return true;
        }

        public async Task<Pedido?> Pesquisar(int id)
        {
            return await _IUOFW.PedidoRepository.Pesquisar(x => x.Id == id).FirstOrDefaultAsync();
        }
    }
}