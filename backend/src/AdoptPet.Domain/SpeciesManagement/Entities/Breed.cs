using AdoptPet.Domain.Shared;
using AdoptPet.Domain.SpeciesManagement.IDs;

namespace AdoptPet.Domain.SpeciesManagement.Entities;

public class Breed : Entity<BreedId>
{
    private Breed(BreedId id) : base(id)
    {
    }
    public string Name { get; private set; } = string.Empty!;
    public string Description { get; private set; } = string.Empty!;
}