namespace ecommerce.Repository.IRepository
{
    public interface IUnitOfWork
    {
        Task Commit();
    }
}