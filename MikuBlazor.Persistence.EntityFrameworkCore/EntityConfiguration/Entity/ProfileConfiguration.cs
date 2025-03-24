using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MikuBlazor.Persistence.EntityFrameworkCore.EntityConfiguration.Entity;

public class ProfileConfiguration : EntityConfiguration<Domain.Anime.Entity.Entity>
{
    protected override void ConfigureEntity(EntityTypeBuilder<Domain.Anime.Entity.Entity> builder)
    {
        builder.ToTable(name: "Profile", schema: "App");
    }
}