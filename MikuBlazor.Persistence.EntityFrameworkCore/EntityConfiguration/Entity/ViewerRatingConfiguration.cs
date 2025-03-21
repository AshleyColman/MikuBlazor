using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MikuBlazor.Domain.Anime.Entity;

namespace MikuBlazor.Persistence.EntityFrameworkCore.EntityConfiguration.Entity;

public sealed class ViewerRatingConfiguration : EntityConfiguration<ViewerRating>
{
    protected override void ConfigureEntity(EntityTypeBuilder<ViewerRating> builder)
    {
        builder.ToTable(name: "ViewerRatings", schema: "App");
    }
}