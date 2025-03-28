using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MikuBlazor.Domain.Anime.Entity;

namespace MikuBlazor.Persistence.EntityFrameworkCore.EntityConfiguration.Entity;

public sealed class GenderConfiguration : BaseEntityConfiguration<Gender>
{
    protected override void ConfigureEntity(EntityTypeBuilder<Gender> builder)
    {
        builder.ToTable(name: "Genders", schema: "App");
        
        builder.Property(x => x.Name)
            .HasMaxLength(25);
    }
}