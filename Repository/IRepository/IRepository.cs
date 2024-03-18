using System.Linq.Expressions;
using Zdoc.Pagination;

namespace ecommerce.Repository.IRepository
{
    public interface IRepository<T>
    {
        IQueryable<T> Listar();
        IQueryable<T> Pesquisar(Expression<Func<T, bool>> predicate);
        Task<PagedList<T>> ListarPaginasFuncao(QueryStringParameters indicesParametes,
                                                Expression<Func<T, bool>> predicate,
                                                Expression<Func<T, string?>> ordem,
                                                Expression<Func<T, object>>? include = null);
        Task<PagedList<T>> ListarPaginas(QueryStringParameters indicesParametes,
                                                Expression<Func<T, string?>> ordem);

        Task<long> Contar(Expression<Func<T, bool>> predicate);
        Task<bool> Existe(Expression<Func<T, bool>> predicate);

        void Adicionar(T entity);
        void Atualizar(T entity);
        void Apagar(T entity);

    }
}