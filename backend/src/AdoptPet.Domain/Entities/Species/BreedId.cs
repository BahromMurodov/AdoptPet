namespace AdoptPet.Domain.Entities.Species;

public record BreedId
{
    public BreedId(Guid? value)
    {
        Value = value;
    }

    public Guid? Value { get; }
    public static BreedId NewBreedId() => Guid.NewGuid();

    public static BreedId Empty() => Guid.Empty;

    public static BreedId Create(Guid? id) => new(id);

    public static implicit operator BreedId(Guid? id) => new(id);

    public static implicit operator Guid(BreedId BreedId)
    {
        ArgumentNullException.ThrowIfNull(BreedId);
        ArgumentNullException.ThrowIfNull(BreedId.Value);
        return BreedId.Value.Value;
    }
}
