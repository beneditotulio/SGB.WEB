namespace SGB.WEB.Models
{
    public class Multa
    {
        public Usuario Usuario { get; set; }
        public decimal ValorMulta { get; set; }
        public DateTime DataAplicacao { get; set; }
        public DateTime? DataPagamento { get; set; }
    }

}
