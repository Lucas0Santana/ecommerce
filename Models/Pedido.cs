namespace ecommerce.Models
{
    public class Pedido
    {
        private int Id { get; set; }
        private double Valor { get; set; }   
        private DateOnly Data { get; set; }
        private double Frente { get; set; }
        private char Status { get; set; }
        


    }
}