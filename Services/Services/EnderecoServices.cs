using ecommerce.Models;
using ecommerce.Repository.IRepository;
using ecommerce.Services.IServices;
using Microsoft.EntityFrameworkCore;

namespace ecommerce.Services.Services
{
    public class EnderecoServices(IUnitOfWork contexto) : IEnderecoServices
    {
        private readonly IUnitOfWork _IUOFW = contexto;
        public async Task<bool> Atualizar(Endereco endereco)
        {
            _IUOFW.EnderecoRepository.Atualizar(endereco);
            await _IUOFW.Commit();
            return true;
        }

        public async Task<bool> Criar(Endereco endereco)
        {
            _IUOFW.EnderecoRepository.Adicionar(endereco);
            await _IUOFW.Commit();
            return true;
        }

        public Task<bool> Desativar(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Endereco?> Pesquisar(int id)
        {
            return await _IUOFW.EnderecoRepository.Pesquisar(x => x.Id == id).FirstOrDefaultAsync();
        }
    }
}