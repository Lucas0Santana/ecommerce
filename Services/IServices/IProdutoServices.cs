using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ecommerce.Models;

namespace ecommerce.Services.IServices
{
    public interface IProdutoServices
    {
        Task<bool> Criar(Produto produto);
        Task<bool> Atualizar(Produto produto);
        Task<Produto?> Pesquisar(int id);
        Task<bool> Desativar(int id);
        Task<List<Produto>> Listar(string cnpj);
        Task<List<Produto>> ListarPorNome(string nome);
        Task<List<Produto>> ListagemAleatoria();
        
    }
}