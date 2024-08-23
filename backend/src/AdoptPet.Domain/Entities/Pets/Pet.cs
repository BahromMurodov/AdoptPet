using AdoptPet.Domain.Entities.Species;
using AdoptPet.Domain.Enums;
using AdoptPet.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoptPet.Domain.Entities.Pets;

public class Pet : Entity<PetId>
{
    private Pet(PetId id) : base(id)
    {
    }
    public string NickName { get; private set; } = null!;
    public string Type { get; private set; } = null!;
    public string? Description { get; private set; }

    public string Breed { get; private set; } = null!;//порода
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
    public PetPhotoList PhotoList { get; private set; }

    public SpeciesId SpeciesId { get; private set; }
    public Guid BreedId { get; private set; }
    
}
