namespace AdoptPet.Domain.Entities.Volunteers;

public record VolunteerId
{
    private VolunteerId(Guid value) 
    {
        Value = value;
    }
    public Guid Value { get; set; }

    public static VolunteerId NewPetId() => new(Guid.NewGuid());
    public static VolunteerId Empty() => new(Guid.Empty);
}
