using System.Linq.Expressions;
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
        Expression<Func<User, User>>? select,
        params UserDataGroups[] dataGroups)
    {
        await using AppDbContext context = await dbContextFactory.CreateDbContextAsync();

        IQueryable<User> query = context.Set<User>()
                                        .AsQueryable();

        query = SetAsTracking(query, asTracking);

        // query = SetDataGroups(query, dataGroups);

        IEnumerable<User> querySelect = SetSelect(query, select);
        
        User? entity = querySelect.FirstOrDefault(x => x.Id == id);
        
        return entity;
    }

    private IQueryable<User> SetDataGroups(
        IQueryable<User> query, 
        UserDataGroups[] dataGroups)
    {
        if (dataGroups.Any(x => x == UserDataGroups.CharacterFavourites))
            query = query.Include(x => x.CharacterFavourites)
                         .ThenInclude(y => y.Character);

        if (dataGroups.Any(x => x == UserDataGroups.AnimeFavourites))
            query = query.Include(x => x.AnimeFavourites)
                         .ThenInclude(y => y.Anime);
        
        if (dataGroups.Any(x => x == UserDataGroups.AnimeRatings))
            query = query.Include(x => x.AnimeRatings)
                         .ThenInclude(y => y.Anime);
        
        return query;
    }
}