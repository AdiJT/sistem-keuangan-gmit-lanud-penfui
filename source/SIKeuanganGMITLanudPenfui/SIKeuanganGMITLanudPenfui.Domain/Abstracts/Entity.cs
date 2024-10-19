namespace SIKeuanganGMITLanudPenfui.Domain.Abstracts;

public abstract class Entity : IEquatable<Entity>
{
    public int Id { get; set; }

    public override bool Equals(object? obj) => obj is not null && obj is Entity entity && Equals(entity);

    public override int GetHashCode() => Id.GetHashCode();

    public bool Equals(Entity? other) => other is not null && other.GetType() == GetType() && other.Id == Id;

    public static bool operator==(Entity? left, Entity? right) => left is not null && left.Equals(right);

    public static bool operator !=(Entity? left, Entity? right) => !(left == right);
}
