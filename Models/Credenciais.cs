using System.ComponentModel.DataAnnotations;

namespace ecommerce.Models
{
    public class Credenciais
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Status { get; set; }        
    
        public Credenciais(int id, string nome, string email, string senha, bool status) 
        {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            this.Status = status;
   
        }

        public int GetId()
        {
            return Id;
        }
        public string GetEmail()
        {
            return Email;
        }
    }
}
