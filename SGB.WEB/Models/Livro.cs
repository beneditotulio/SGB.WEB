namespace SGB.WEB.Models
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public string ISBN { get; set; }
        public int NumeroExemplaresDisponiveis { get; set; }
        public List<Reserva> Reservas { get; set; }
        public List<Emprestimo> Emprestimos { get; set; }
    }

}
