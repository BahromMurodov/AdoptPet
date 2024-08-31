using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdoptPet.Domain.Shared;
using AdoptPet.Domain.VolunteerManagement.Entities;
using AdoptPet.Domain.VolunteerManagement.IDs;
using AdoptPet.Domain.VolunteerManagement.ValueObjects;

namespace AdoptPet.Domain.VolunteerManagement.AggregateRoot;

public class Volunteer : Entity<VolunteerId>
{
    private Volunteer(VolunteerId id) : base(id)
    {
    }
    public string FullName { get; private set; } = string.Empty!;
    public string Description { get; private set; } = string.Empty!;
    public int Experience { get; private set; }
    public int NumberPetFindHome { get; private set; }
    public int NumberPetSearchHome { get; private set; }
    public int NumberPetHealing { get; private set; }
    public string Phone { get; private set; } = string.Empty!;
    public VolunteersRequisite VolunteersRequisite { get; private set; }
    public VolunteersSocialMedia VolunteersSocialMedia { get; private set; }

    public List<Pet> Pets { get; private set; } = null!;
}
