using System.Text.Json.Serialization;
using ecommerce.Models;

public class Cliente(string CPF, int idCredenciais)
{
    public string CPF { get; private set; } = CPF;
    public int IdCredenciais { get; private set; } = idCredenciais;

    [JsonIgnore]
    public Credenciais? Credenciais { get; set; }
    [JsonIgnore]
    public ICollection<Endereco> Enderecos { get; set; } = new List<Endereco>();
    [JsonIgnore]
    public ICollection<Pedido>? Pedidos { get; set; }
    [JsonIgnore]
    public Carrinho? Carrinho { get; set; }
    [JsonIgnore]
    public ICollection<SolicitacaoDeEstorno>? SolicitacaoDeEstornos { get; set; }
}