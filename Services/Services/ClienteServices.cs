using ecommerce.Models;
using ecommerce.Repository.IRepository;
using ecommerce.Services.IServices;
using Microsoft.EntityFrameworkCore;

namespace ecommerce.Services.Services
{
    public class ClienteServices(IUnitOfWork contexto) : IClienteServices
    {
        private readonly IUnitOfWork _IUOFW = contexto;

        public async Task<bool> AlternarStatus(string cpf)
        {
            Cliente? clienteExistente = await _IUOFW.ClienteRepository.Pesquisar(x => x.CPF == cpf).FirstOrDefaultAsync(); 
            if(clienteExistente == null) { return false; }
            return true;
        }

        public async Task<bool> Criar(Cliente cliente)
        {
            try
            {
                _IUOFW.ClienteRepository.Adicionar(cliente);
                await _IUOFW.Commit();                
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<Cliente?> Pesquisar(string cpf)
        {
            Cliente? cliente = await _IUOFW.ClienteRepository.Pesquisar(x => x.CPF == cpf).FirstOrDefaultAsync();
            if(cliente == null) { return cliente; }

            return null;
        }
    }
}