using Microsoft.EntityFrameworkCore;
using TSD2491_oblig1_ferhat_oystein.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

    public DbSet<Bruker> Brukere { get; set; }
}
