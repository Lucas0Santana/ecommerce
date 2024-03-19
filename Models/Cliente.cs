using System.Collections.Generic;

namespace ecommerce.Models
{
    public class Cliente(string cpf)
    {
        private readonly string _cpf = cpf;

        public string CPF 
        { 
            get { return _cpf; }
        }

        public int IdCredicias { get; set; }

        public Credenciais Credenciais { get; set; }
        public ICollection<Endereco> Enderecos { get; set; } = [];
        public ICollection<Pedido>? Pedidos { get; set; }
        public Carrinho? Carrinho { get; set; }
        public ICollection<SolicitacaoDeEstorno>? SolicitacaoDeEstornos { get; set; }
    }
}
