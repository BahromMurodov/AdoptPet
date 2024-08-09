using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoptPet.Domain.Entities;

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
    public List<SocialMedia> SocialMedias { get; private set; } = null!;
    public List<Requisite> Requisites { get; private set; } = null!;
    public List<Pet> Pets { get; private set; } = null!;

    private Volunteer()
    {
    }
}
