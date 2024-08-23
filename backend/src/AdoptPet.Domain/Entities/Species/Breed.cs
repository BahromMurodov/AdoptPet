using AdoptPet.Domain.Shared;

namespace AdoptPet.Domain.Entities.Species;

public class Breed : Entity<BreedId>
{
    private Breed(BreedId id) : base(id)
    {
    }
    public string Name { get; private set; } = string.Empty!;
    public string Description { get; private set; } = string.Empty!;
}