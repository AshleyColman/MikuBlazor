using System.Linq.Expressions;
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
        Expression<Func<Anime, Anime>>? select,
        params AnimeDataGroups[] dataGroups)
    {
        await using AppDbContext context = await dbContextFactory.CreateDbContextAsync();

        IQueryable<Anime> query = context.Set<Anime>()
            .AsQueryable();

        query = SetAsTracking(query, asTracking);

        query = SetDataGroups(query, dataGroups);
        
        IEnumerable<Anime> querySelect = SetSelect(query, select);

        Anime? entity = querySelect.FirstOrDefault(x => x.Id == id);

        return entity;
    }

    private IQueryable<Anime> SetDataGroups(
        IQueryable<Anime> query, 
        AnimeDataGroups[] dataGroups)
    {
        if (dataGroups.Any(x => x == AnimeDataGroups.Characters))
            query = query.Include(x => x.Characters);
        
        if (dataGroups.Any(x => x == AnimeDataGroups.Type))
            query = query.Include(x => x.Type);
        
        if (dataGroups.Any(x => x == AnimeDataGroups.Status))
            query = query.Include(x => x.Status);
        
        if (dataGroups.Any(x => x == AnimeDataGroups.Producer))
            query = query.Include(x => x.Producers);
        
        if (dataGroups.Any(x => x == AnimeDataGroups.Studio))
            query = query.Include(x => x.Studios);
        
        if (dataGroups.Any(x => x == AnimeDataGroups.Season))
            query = query.Include(x => x.Season);
        
        if (dataGroups.Any(x => x == AnimeDataGroups.Genres))
            query = query.Include(x => x.Genres);
        
        if (dataGroups.Any(x => x == AnimeDataGroups.ViewerRating))
            query = query.Include(x => x.ViewerRating);
        
        if (dataGroups.Any(x => x == AnimeDataGroups.Episodes))
            query = query.Include(x => x.Episodes);
        
        if (dataGroups.Any(x => x == AnimeDataGroups.Tags))
            query = query.Include(x => x.Tags);
        
        if (dataGroups.Any(x => x == AnimeDataGroups.Genres))
            query = query.Include(x => x.Genres);

        return query;
    }
    
}