using System.Linq.Expressions;
using ecommerce.Data;
using ecommerce.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

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

        public IQueryable<T> ListarOn(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().AsNoTracking().Where(predicate);
        }
        public IQueryable<T> Listar()
        {
            return _context.Set<T>().AsNoTracking();
        }

        public async Task<T> Pesquisar(Expression<Func<T, bool>> predicate)
        {
            var retorno = await _context.Set<T>().AsNoTracking().FirstOrDefaultAsync(predicate!);

            return retorno!;

        }

        // public async Task<PagedList<T>> ListarPaginasFuncao(QueryStringParameters indicesParametes,
        //                                                     Expression<Func<T, bool>> predicate,
        //                                                     Expression<Func<T, string?>> ordem,
        //                                                     Expression<Func<T, object>>? include = null)
        // {
        //     if (include != null)
        //     {
        //         return await PagedList<T>.ToPagedList(
        //         ListarOn(predicate).OrderBy(ordem).Include(include), indicesParametes.PageNumber, indicesParametes.PageSize);
        //     }

        //     return await PagedList<T>.ToPagedList(
        //         ListarOn(predicate).OrderBy(ordem), indicesParametes.PageNumber, indicesParametes.PageSize);
        // }
        // public async Task<PagedList<T>> ListarPaginas(QueryStringParameters indicesParametes,
        //                                                 Expression<Func<T, string?>> ordem)
        // {
        //     return await PagedList<T>.ToPagedList(
        //         Listar().OrderBy(ordem), indicesParametes.PageNumber, indicesParametes.PageSize);
        // }

        public async Task<long> Contar(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().AsNoTracking().LongCountAsync(predicate);
        }

    }
}