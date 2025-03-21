using Microsoft.EntityFrameworkCore;

namespace MikuBlazor.Persistence.EntityFrameworkCore.Context;

public class AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) 
    : DbContext(dbContextOptions)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}