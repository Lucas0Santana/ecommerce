using ecommerce.Data;
using ecommerce.Repository.IRepository;

namespace ecommerce.Repository.Repository.ModelsRepository
{
    public class UnitOfWork : IUnitOfWork
    {
        public Context _context;
        public UnitOfWork(Context contexto)
        {
            _context = contexto;
        }

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }
        public void Dispose()
        {
            _context.Dispose();
        }

    }
}