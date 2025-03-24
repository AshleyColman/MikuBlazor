using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MikuBlazor.Domain.Anime.DataGroups;
using MikuBlazor.Domain.Anime.Entity;
using MikuBlazor.Interfaces.Repositories;
using MikuBlazor.Persistence.EntityFrameworkCore.Context;

namespace MikuBlazor.Persistence.EntityFrameworkCore.Repositories;

public class AnimeRepository(IDbContextFactory<AppDbContext> dbContextFactory) 
    : EntityRepository<Anime>(dbContextFactory), IAnimeRepository
{
    public async Task<Anime?> GetByIdAsync(
        Guid id, 
        bool asTracking, 
        params AnimeDataGroups[] dataGroups)
    {
        await using AppDbContext context = await dbContextFactory.CreateDbContextAsync();

        IQueryable<Anime> query = context.Set<Anime>()
            .AsQueryable();

        query = SetAsTracking(query, asTracking);

        query = SetDataGroups(query, dataGroups);
        
        Anime? entity = await query.FirstOrDefaultAsync(x => x.Id == id);

        return entity;
    }

    private IQueryable<Anime> SetDataGroups(
        IQueryable<Anime> query, 
        AnimeDataGroups[] dataGroups)
    {
        if (dataGroups.Any(x => x == AnimeDataGroups.Characters))
            query = query.Include(x => x.Characters);

        return query;
    }
    
}