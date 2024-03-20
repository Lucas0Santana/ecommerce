using ecommerce.Models;
using ecommerce.Repository.IRepository;
using ecommerce.Services.IServices;
using Microsoft.EntityFrameworkCore;

namespace ecommerce.Services.Services
{
    public class ProdutoServices(IUnitOfWork unitOfWork) : IProdutoServices
    {
        private readonly IUnitOfWork _IUOFW = unitOfWork;
        public async Task<bool> Atualizar(Produto produto)
        {
            _IUOFW.ProdutoRepository.Atualizar(produto);
            await _IUOFW.Commit();
            return true;
        }

        public async Task<bool> Criar(Produto produto)
        {
            _IUOFW.ProdutoRepository.Adicionar(produto);
            await _IUOFW.Commit();
            return true;
        }

        public async Task<bool> Desativar(int id)
        {
            Produto? produto = await Pesquisar(id);
            if(produto == null)
            {
                return false;
            }

            produto.SetStatus();
            
            _IUOFW.ProdutoRepository.Atualizar(produto);
            await _IUOFW.Commit();
            return true;

        }

        public async Task<List<Produto>> Listar(string cnpj)
        {
            return await _IUOFW.ProdutoRepository.Pesquisar(x => x.Cnpj == cnpj).ToListAsync();
        }

        public async Task<Produto?> Pesquisar(int id)
        {
            return await _IUOFW.ProdutoRepository.Pesquisar(x => x.Id == id).FirstOrDefaultAsync();
        }
    }
}