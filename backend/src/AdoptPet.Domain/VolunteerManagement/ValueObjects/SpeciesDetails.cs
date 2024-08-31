using AdoptPet.Domain.SpeciesManagement.IDs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AdoptPet.Domain.VolunteerManagement.ValueObjects;

public record SpeciesDetails
{
    private SpeciesDetails(SpeciesId speciesId, Guid breedId)
    {
    }

    public SpeciesId SpeciesId { get; }
    public Guid BreedId { get; set; }

    public static SpeciesDetails Create(SpeciesId speciesId, Guid breedId)
    {
        return new SpeciesDetails(speciesId, breedId);
    }
}
