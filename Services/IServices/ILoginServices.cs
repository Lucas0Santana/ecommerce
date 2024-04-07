namespace ecommerce.Services.IServices
{
    public interface ILoginServices
    {
        Task<string> Login(string email, string senha);        
    }
}