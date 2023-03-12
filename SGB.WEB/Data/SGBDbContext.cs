using Microsoft.EntityFrameworkCore;
using SGB.WEB.Models;

namespace SGB.WEB.Data
{
    public class SGBDbContext : DbContext
    {
        DbSet<Usuario> Usuarios { get; set; }
        DbSet<Emprestimo> Emprestimos { get; set; }  
        DbSet<Livro> Livros { get; set; }   
        DbSet<Multa> Multas { get; set; }
        DbSet<Reserva>  Reservas { get; set; }
    }
}
