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
    public class VarejistaServices(IUnitOfWork unitOfWork) : IVarejistaServices
    {
        private readonly IUnitOfWork _IUOFW = unitOfWork;

        public async Task<bool> Criar(Varejista varejista)
        {
            if(await _IUOFW.VarejistaRepository.Existe(x => x.CNPJ == varejista.CNPJ)) 
            {
                return false;
            }

            _IUOFW.VarejistaRepository.Adicionar(varejista);
            await _IUOFW.Commit();
            return true;
        }

        public async Task<Varejista?> Pesquisar(string cnpj)
        {
            return await _IUOFW.VarejistaRepository.Pesquisar(x => x.CNPJ == cnpj).FirstOrDefaultAsync();
        }
    }
}