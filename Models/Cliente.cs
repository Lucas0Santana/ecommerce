using ecommerce.Models;

public class Cliente
{
    public Cliente()
    {
    }

    public Cliente(string cpf, int idCredenciais)
    {
        this.CPF = cpf;
        this.IdCredenciais = idCredenciais;
    }

    public string CPF { get; private set; }
    public int IdCredenciais { get; private set; }

    public Credenciais? Credenciais { get; set; }
    public ICollection<Endereco> Enderecos { get; set; } = new List<Endereco>();
    public ICollection<Pedido>? Pedidos { get; set; }
    public Carrinho? Carrinho { get; set; }
    public ICollection<SolicitacaoDeEstorno>? SolicitacaoDeEstornos { get; set; }
}