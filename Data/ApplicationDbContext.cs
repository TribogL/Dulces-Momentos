

using Dulces_Momentos.Models;
using Microsoft.EntityFrameworkCore;

namespace Dulces_Momentos.Data;
public class ApplicationDbContext : DbContext
{
    public DbSet<Role> Roles { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

    }
}
