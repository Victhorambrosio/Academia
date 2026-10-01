using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Academia;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Profissional> Profissionais { get; set; }
    public DbSet<Plano> Planos { get; set; }
    public DbSet<Matricula> Matriculas { get; set; }
    public DbSet<AvaliacaoFisica> AvaliacoesFisicas { get; set; }
    public DbSet<Aula> Aulas { get; set; }

}
