namespace ecommerce.Models
{
    public class Produto(int id, string nome, double preco, string descricao, bool status, string CNPJ)
    {
        public int Id { get; private set; } = id;
        public string Nome { get; private set; } = nome;
        public double Preco { get; private set; } = preco;
        public string Descricao { get; private set; } = descricao;
        public bool Status { get; private set; } = status;
        public string CNPJ { get; private set; } = CNPJ;


        public void SetStatus()
        {
            Status = !status;
        }

    }
}