using Microsoft.EntityFrameworkCore.Internal;
using MikuBlazor.Domain.Anime.Entity;
using MikuBlazor.Interfaces.Repositories;
using MikuBlazor.Persistence.EntityFrameworkCore.Context;

namespace MikuBlazor.Persistence.EntityFrameworkCore.Repositories;

public class AnimeRepository(DbContextFactory<AppDbContext> dbContextFactory) 
    : EntityRepository<Anime>(dbContextFactory), IAnimeRepository
{
    
}