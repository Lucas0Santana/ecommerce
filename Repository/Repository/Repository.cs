using System.Linq.Expressions;
using ecommerce.Data;
using ecommerce.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using Zdoc.Pagination;

namespace ecommerce.Repository.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected Context _context;

        public Repository(Context context)
        {
            _context = context;
        }

        public void Adicionar(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Apagar(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void Atualizar(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.Set<T>().Update(entity);
        }

        public IQueryable<T> Pesquisar(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().AsNoTracking().Where(predicate);
        }
        public IQueryable<T> Listar()
        {
            return _context.Set<T>().AsNoTracking();
        }

        public async Task<PagedList<T>> ListarPaginasFuncao(QueryStringParameters indicesParametes,
                                                            Expression<Func<T, bool>> predicate,
                                                            Expression<Func<T, string?>> ordem,
                                                            Expression<Func<T, object>>? include = null)
        {
            if (include != null)
            {
                return await PagedList<T>.ToPagedList(
                Pesquisar(predicate).OrderBy(ordem).Include(include), indicesParametes.PageNumber, indicesParametes.PageSize);
            }

            return await PagedList<T>.ToPagedList(
                Pesquisar(predicate).OrderBy(ordem), indicesParametes.PageNumber, indicesParametes.PageSize);
        }
        public async Task<PagedList<T>> ListarPaginas(QueryStringParameters indicesParametes,
                                                        Expression<Func<T, string?>> ordem)
        {
            return await PagedList<T>.ToPagedList(
                Listar().OrderBy(ordem), indicesParametes.PageNumber, indicesParametes.PageSize);
        }

        public async Task<long> Contar(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().AsNoTracking().LongCountAsync(predicate);
        }

        public async Task<bool> Existe(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().AsNoTracking().AnyAsync(predicate);
        }

    }
}