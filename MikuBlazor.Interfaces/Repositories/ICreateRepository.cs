using MikuBlazor.Domain.Anime.Entity;

namespace MikuBlazor.Interfaces.Repositories;

public interface ICreateRepository<T> where T : Entity
{
    Task AddAsync(T entity);
}