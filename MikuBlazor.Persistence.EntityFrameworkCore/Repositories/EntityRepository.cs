using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using MikuBlazor.Domain.Anime.Entity;
using MikuBlazor.Interfaces.Repositories;
using MikuBlazor.Persistence.EntityFrameworkCore.Context;

namespace MikuBlazor.Persistence.EntityFrameworkCore.Repositories;

public abstract class EntityRepository<T>(IDbContextFactory<AppDbContext> dbContextFactory)
    : IReadRepository<T>, ICreateRepository<T>, IDeleteRepository<T> 
        where T : Entity
{
    public async Task<IList<T>> GetAllAsync(Expression<Func<T, T>>? select, bool asTracking)
    {
        await using AppDbContext context = await dbContextFactory.CreateDbContextAsync();

        IQueryable<T> query = context.Set<T>()
                                     .AsQueryable();

        query = SetAsTracking(query, asTracking);

        IEnumerable<T> querySelect = SetSelect(query, select);
        
        return querySelect.ToList();
    }
    
    public async Task<T?> GetByIdAsync(Guid id, bool asTracking)
    {
        await using AppDbContext context = await dbContextFactory.CreateDbContextAsync();

        IQueryable<T> query = context.Set<T>()
                                     .AsQueryable();

        query = SetAsTracking(query, asTracking);

        T? entity = await query.FirstOrDefaultAsync(x => x.Id == id);

        return entity;
    }
    
    public async Task AddAsync(T entity)
    {
        await using AppDbContext context = await dbContextFactory.CreateDbContextAsync();

        context.Set<T>()
               .Add(entity);

        await context.SaveChangesAsync();
    }
    
    public async Task DeleteAsync(T entity)
    {
        await using AppDbContext context = await dbContextFactory.CreateDbContextAsync();

        context.Set<T>()
               .Remove(entity);

        await context.SaveChangesAsync();
    }

    protected IQueryable<T> SetAsTracking(IQueryable<T> query, bool asTracking)
    {
        query = asTracking
            ? query.AsTracking()
            : query.AsNoTracking();

        return query;
    }

    protected IEnumerable<T> SetSelect(IQueryable<T> query, Expression<Func<T, T>>? select)
    {
        return select is null 
            ? query 
            : query.Select(select);
    }
}