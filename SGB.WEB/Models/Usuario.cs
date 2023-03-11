namespace SGB.WEB.Models
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public int NumeroCarteira { get; set; }
        public List<Emprestimo> HistoricoEmprestimos { get; set; }
        public List<Multa> MultasEmAberto { get; set; }
    }

}
