using AdoptPet.Domain.Shared;
using AdoptPet.Domain.SpeciesManagement.Entities;
using AdoptPet.Domain.SpeciesManagement.IDs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoptPet.Domain.SpeciesManagement.AggregateRoot;

public class Species : Entity<SpeciesId>
{
    private readonly List<Breed> _breeds = [];
    private Species(SpeciesId id) : base(id)
    {
    }
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public IReadOnlyList<Breed> Breeds => _breeds;

    public void AddBreed(Breed breed)
    {
        _breeds.Add(breed);
    }
}
