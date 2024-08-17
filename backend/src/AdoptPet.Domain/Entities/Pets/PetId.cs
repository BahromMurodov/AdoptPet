namespace AdoptPet.Domain.Entities.Pets;

public record PetId
{
    private PetId(Guid value) 
    {
        Value = value;
    }
    public Guid Value { get; private set; }

    public static PetId NewPetId() => new(Guid.NewGuid());
    public static PetId Empty() => new(Guid.Empty);
}
