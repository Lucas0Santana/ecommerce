using System.Collections.Generic;

namespace ecommerce.Models
{
    public class Cliente(string cpf, int idCrediciais)
    {
        private readonly string _cpf = cpf;

        public string CPF => _cpf;

        private readonly int _idCrediciais = idCrediciais;
        public int IdCredicias => _idCrediciais;

        public Credenciais? Credenciais { get; set; }
        public ICollection<Endereco> Enderecos { get; set; } = [];
        public ICollection<Pedido>? Pedidos { get; set; }
        public Carrinho? Carrinho { get; set; }
        public ICollection<SolicitacaoDeEstorno>? SolicitacaoDeEstornos { get; set; }
    }
}
