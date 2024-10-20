﻿namespace Core.Persistence.Repositories;

public class Entity<TId> :IEntityTimestamps
{
    public TId Id { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime? UpdateDate { get; set; }
    public DateTime? DeletedDate { get; set; }

    public Entity()
    {
        Id = default;
    }
    public Entity(TId id)
    {
        Id = id;
    }
}
