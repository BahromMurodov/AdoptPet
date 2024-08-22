using AdoptPet.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoptPet.Domain.Entities.Species;

public class Species : Entity<SpeciesId> 
{
    private readonly List<Breed> _breeds = [];
    private Species(SpeciesId id) : base(id)
    {
    }
    public Guid Id { get; set; }
    public string Name { get; set; }
    public IReadOnlyList<Breed> Breeds => _breeds;

    public void AddBreeds(Breed breed)
    {
        _breeds.Add(breed);
    }
}
