namespace AdoptPet.Domain.Entities.Species;

public record SpeciesId
{
    private SpeciesId(Guid value)
    {
        Value = value;
    }

    public Guid Value { get; }
    public static SpeciesId NewSpeciesId() => Guid.NewGuid();

    public static SpeciesId Empty() => Guid.Empty;

    public static SpeciesId Create(Guid id) => new(id);

    public static implicit operator SpeciesId(Guid id) => new(id);

    public static implicit operator Guid(SpeciesId SpeciesId)
    {
        ArgumentNullException.ThrowIfNull(SpeciesId);
        ArgumentNullException.ThrowIfNull(SpeciesId.Value);
        return SpeciesId.Value;
    }
}