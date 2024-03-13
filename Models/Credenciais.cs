using System.ComponentModel.DataAnnotations;

namespace ecommerce.Models
{
    public class Credenciais
    {
        private int Id { get; set; }
        private string Nome { get; set; }
        [EmailAddress]
        private string Email { get; set; }
        private string Senha { get; set; }
        private bool Status { get; set; }        
    }
}