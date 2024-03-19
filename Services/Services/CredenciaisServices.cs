using ecommerce.Repository.IRepository;
using ecommerce.Services.IServices;
using Microsoft.EntityFrameworkCore;

namespace ecommerce.Services
{
    public class CredenciaisServices(IUnitOfWork contexto) : ICredenciaisServices
    {
        private readonly IUnitOfWork _IUOFW = contexto;

        public async Task<bool> AlternarStatus(int id) 
        {  
            Credenciais? cred = await _IUOFW.CredenciaisRepository.Pesquisar(x => x.Id == id).FirstOrDefaultAsync();
            if(cred == null)
            {
                return false;
            }
            
            cred.SetStatus();
            _IUOFW.CredenciaisRepository.Atualizar(cred);
            await _IUOFW.Commit();
            
            return true;
        }

        public async Task<bool> Atualizar(Credenciais credenciais)
        {
            try
            {
                _IUOFW.CredenciaisRepository.Atualizar(credenciais);
                await _IUOFW.Commit();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> Criar(Credenciais credenciais)
        {
            if(await _IUOFW.CredenciaisRepository.Existe(x => x.Email == credenciais.Email))
            {
                return false;
            }
            _IUOFW.CredenciaisRepository.Adicionar(credenciais);
            await _IUOFW.Commit();
            return true;
        }
        
    }
}