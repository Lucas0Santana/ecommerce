using ecommerce.Models;
using ecommerce.Repository.IRepository;
using ecommerce.Services.IServices;
using Microsoft.EntityFrameworkCore;

namespace ecommerce.Services.Services
{
    public class LoginServices(IUnitOfWork unitOfWork) : ILoginServices
    {
        private readonly IUnitOfWork _IUOFW = unitOfWork;

        public async Task<string> Login(string email, string senha)
        {
            Credenciais? credenciais = await _IUOFW.CredenciaisRepository.Pesquisar(x => x.Email == email && x.Senha == senha).FirstOrDefaultAsync();
            if(credenciais == null)
            {
                return "erro";
            }            

            Varejista? varejista = await _IUOFW.VarejistaRepository.Pesquisar(x => x.IdCredenciais == credenciais.Id).FirstOrDefaultAsync();
                
            if(varejista == null)
            {
                Cliente? cliente = await _IUOFW.ClienteRepository.Pesquisar(x => x.IdCredenciais == credenciais.Id).FirstOrDefaultAsync();
                
                if(cliente != null)
                {
                    return TokenService.GenerateToken(credenciais, cliente.CPF);
                }
            }
            else
            {
                return TokenService.GenerateToken(credenciais, varejista.CNPJ);
            }
            return "erro";
        }        
    }
}