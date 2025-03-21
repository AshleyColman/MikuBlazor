using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using MikuBlazor.Domain.Anime.Entity;
using MikuBlazor.Interfaces.Repositories;
using MikuBlazor.Persistence.EntityFrameworkCore.Context;

namespace MikuBlazor.Persistence.EntityFrameworkCore.Repositories;

public abstract class EntityRepository<T>(DbContextFactory<AppDbContext> dbContextFactory)
    : IReadRepository<T>, ICreateRepository<T>, IDeleteRepository<T> 
        where T : Entity
{
    public async Task<IList<T>> GetAllAsync(bool asTracking)
    {
        AppDbContext context = await dbContextFactory.CreateDbContextAsync();

        IQueryable<T> query = context.Set<T>()
                                     .AsQueryable();

        query = SetAsTracking(query, asTracking);

        IList<T> entities = await query.ToListAsync();

        await context.DisposeAsync();

        return entities;
    }
    
    public async Task<T?> GetByIdAsync(Guid id, bool asTracking)
    {
        AppDbContext context = await dbContextFactory.CreateDbContextAsync();

        IQueryable<T> query = context.Set<T>()
                                     .AsQueryable();

        query = SetAsTracking(query, asTracking);

        T? entity = await query.FirstOrDefaultAsync(x => x.Id == id);
        
        await context.DisposeAsync();

        return entity;
    }
    
    public async Task AddAsync(T entity)
    {
        AppDbContext context = await dbContextFactory.CreateDbContextAsync();

        context.Set<T>()
               .Add(entity);

        await context.SaveChangesAsync();
        await context.DisposeAsync();
    }
    
    public async Task DeleteAsync(T entity)
    {
        AppDbContext context = await dbContextFactory.CreateDbContextAsync();

        context.Set<T>()
               .Remove(entity);

        await context.SaveChangesAsync();
        await context.DisposeAsync();
    }

    protected IQueryable<T> SetAsTracking(IQueryable<T> query, bool asTracking)
    {
        query = asTracking
            ? query.AsTracking()
            : query.AsNoTracking();

        return query;
    }
}