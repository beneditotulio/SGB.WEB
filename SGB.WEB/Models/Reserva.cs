namespace SGB.WEB.Models
{
    public class Reserva
    {
        public Livro Livro { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime DataReserva { get; set; }
        public DateTime DataExpiracao { get; set; }
    }

}
