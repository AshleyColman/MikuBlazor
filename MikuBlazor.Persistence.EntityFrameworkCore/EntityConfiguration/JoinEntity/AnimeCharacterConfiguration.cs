using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MikuBlazor.Domain.Anime.JoinEntity;
using MikuBlazor.Persistence.EntityFrameworkCore.EntityConfiguration.Entity;

namespace MikuBlazor.Persistence.EntityFrameworkCore.EntityConfiguration.JoinEntity;

public sealed class AnimeCharactersConfiguration : BaseEntityConfiguration<AnimeCharacters>
{
    protected override void ConfigureEntity(EntityTypeBuilder<AnimeCharacters> builder)
    {
        builder.ToTable(name: "AnimeCharacters", schema: "App");
    }
}