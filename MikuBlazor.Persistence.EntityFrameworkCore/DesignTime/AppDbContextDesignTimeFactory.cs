using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using MikuBlazor.Persistence.EntityFrameworkCore.Context;

namespace MikuBlazor.Persistence.EntityFrameworkCore.DesignTime;

public class AppDbContextDesignTimeFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        
        // TODO: Move this to args
        optionsBuilder.UseSqlServer("Server=localhost;Database=MikuBlazor;Trusted_Connection=True;Integrated Security=True;TrustServerCertificate=True;")
                      .EnableSensitiveDataLogging()
                      .LogTo(Console.Write);

        return new AppDbContext(optionsBuilder.Options);
    }
}