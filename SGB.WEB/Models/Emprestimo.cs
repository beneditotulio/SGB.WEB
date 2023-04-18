namespace SGB.WEB.Models
{
    public class Emprestimo
    {
        
        [Key]
        public Livro Livro { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucaoPrevista { get; set; }
        public DateTime? DataDevolucaoEfetiva { get; set; }
        public bool Devolvido { get; set; }
    }

}
