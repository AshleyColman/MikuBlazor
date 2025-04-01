using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using MikuBlazor.Domain.Anime.DataGroups;
using MikuBlazor.Domain.Anime.Entity;
using MikuBlazor.Interfaces.Repositories;
using MikuBlazor.Persistence.EntityFrameworkCore.Context;

namespace MikuBlazor.Persistence.EntityFrameworkCore.Repositories;

public class CharacterRepository(IDbContextFactory<AppDbContext> dbContextFactory) 
    : EntityRepository<Character>(dbContextFactory), ICharacterRepository
{
    public async Task<Character?> GetByIdAsync(
        Guid id, 
        bool asTracking,
        Expression<Func<Character, Character>>? select,
        CharacterDataGroups[] dataGroups)
    {
        await using AppDbContext context = await dbContextFactory.CreateDbContextAsync();

        IQueryable<Character> query = context.Set<Character>();

        query = SetAsTracking(query, asTracking);

        query = SetDataGroups(query, dataGroups);

        IEnumerable<Character> querySelect = SetSelect(query, select);
        
        return querySelect.FirstOrDefault(x => x.Id == id);
    }
    
    private IQueryable<Character> SetDataGroups(
        IQueryable<Character> query, 
        CharacterDataGroups[] dataGroups)
    {
        if (dataGroups.Any(x => x == CharacterDataGroups.Anime))
            query = query.Include(x => x.Animes);

        if (dataGroups.Any(x => x == CharacterDataGroups.Gender))
            query = query.Include(x => x.Gender);
        
        return query;
    }
}