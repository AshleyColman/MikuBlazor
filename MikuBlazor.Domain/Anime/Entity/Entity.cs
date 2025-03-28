namespace MikuBlazor.Domain.Anime.Entity;

public abstract class Entity
{
    public Entity()
    {
        if (Id == Guid.Empty)
            Id = Guid.NewGuid();
    }

    public Guid Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime? UpdatedOn { get; set; }
    public Guid UpdatedBy { get; set; }
    public bool IsDeleted { get; set; }
    public Guid? DeletedBy { get; set; }
}