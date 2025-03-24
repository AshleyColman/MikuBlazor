using Microsoft.EntityFrameworkCore;
using MikuBlazor.Domain.Anime.DataGroups;
using MikuBlazor.Domain.Anime.Entity;
using MikuBlazor.Interfaces.Repositories;
using MikuBlazor.Persistence.EntityFrameworkCore.Context;

namespace MikuBlazor.Persistence.EntityFrameworkCore.Repositories;

public class UserRepository(IDbContextFactory<AppDbContext> dbContextFactory) 
    : EntityRepository<User>(dbContextFactory), IUserRepository
{
    public async Task<User?> GetByIdAsync(
        Guid id, 
        bool asTracking, 
        params UserDataGroups[] dataGroups)
    {
        await using AppDbContext context = await dbContextFactory.CreateDbContextAsync();

        IQueryable<User> query = context.Set<User>()
                                        .AsQueryable();

        query = SetAsTracking(query, asTracking);

        query = SetDataGroups(query, dataGroups);
        
        User? entity = await query.FirstOrDefaultAsync(x => x.Id == id);

        return entity;
    }

    private IQueryable<User> SetDataGroups(
        IQueryable<User> query, 
        UserDataGroups[] dataGroups)
    {
        if (dataGroups.Any(x => x == UserDataGroups.CharacterFavourites))
            query = query.Include(x => x.CharacterFavourites);

        if (dataGroups.Any(x => x == UserDataGroups.AnimeFavourites))
            query = query.Include(x => x.AnimeFavourites);
        
        if (dataGroups.Any(x => x == UserDataGroups.AnimeRatings))
            query = query.Include(x => x.AnimeRatings);
        
        return query;
    }
}