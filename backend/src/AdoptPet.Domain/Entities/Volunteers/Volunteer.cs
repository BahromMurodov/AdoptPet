using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdoptPet.Domain.Entities.CommonModels;
using AdoptPet.Domain.Entities.Pets;

namespace AdoptPet.Domain.Entities.Volunteers;

public class Volunteer
{
    public Guid Id { get; private set; }
    public string FullName { get; private set; } = string.Empty!;
    public string Description { get; private set; } = string.Empty!;
    public int Experience { get; private set; }
    public int NumberPetFindHome { get; private set; }
    public int NumberPetSearchHome { get; private set; }
    public int NumberPetHealing { get; private set; }
    public string Phone { get; private set; } = string.Empty!;
    public VolunteerDetails Details { get; private set; }
    public List<Pet> Pets { get; private set; } = null!;

    private Volunteer()
    {
    }
}
