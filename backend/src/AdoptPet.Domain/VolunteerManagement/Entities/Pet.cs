using AdoptPet.Domain.Shared;
using AdoptPet.Domain.Shared.ValueObjects;
using AdoptPet.Domain.SpeciesManagement.IDs;
using AdoptPet.Domain.VolunteerManagement.IDs;
using AdoptPet.Domain.VolunteerManagement.ValueObjects;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoptPet.Domain.VolunteerManagement.Entities;

public class Pet : Entity<PetId>
{
    private Pet(PetId id) : base(id)
    {
    }
    public NickName NickName { get; private set; } = null!;
    public string Type { get; private set; } = null!;
    public string? Description { get; private set; }

    public SpeciesDetails SpeciesAndBreed { get; private set; } = null!;//порода и вид
    public string Color { get; private set; } = null!;
    public string Health { get; private set; } = null!;
    public Address Address { get; private set; } = null!;
    public double Weight { get; private set; }
    public double Height { get; private set; }
    public string PhoneNumber { get; private set; } = null!;
    public bool IsNeutered { get; private set; }//Кастрирован?
    public DateOnly DateBirth { get; private set; }
    public bool IsVaccinated { get; private set; }
    public HelpStatus StatusHelp { get; private set; }

    public DateTime DateCreated { get; private set; }

    public PetsRequisite PetsRequisite { get; private set; }
    public List<PetPhoto> PetPhotos { get; private set; }

    public SpeciesId SpeciesId { get; private set; }
    public Guid BreedId { get; private set; }
    
}
