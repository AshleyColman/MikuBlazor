using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MikuBlazor.Domain.Anime.Entity;

namespace MikuBlazor.Persistence.EntityFrameworkCore.EntityConfiguration.Entity;

public sealed class StudioConfiguration : EntityConfiguration<Studio>
{
    protected override void ConfigureEntity(EntityTypeBuilder<Studio> builder)
    {
        builder.ToTable(name: "Studios", schema: "App");
        
        builder.Property(x => x.Name)
               .HasMaxLength(50);
    }
}