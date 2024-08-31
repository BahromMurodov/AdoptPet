using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdoptPet.Domain.Shared.ValueObjects;

namespace AdoptPet.Domain.VolunteerManagement.ValueObjects;

public record PetsRequisite
{
    public PetsRequisite()
    {
    }

    public PetsRequisite(IEnumerable<Requisite> requisites)
    {
        Requisites = requisites.ToList();
    }
    public IReadOnlyList<Requisite> Requisites { get; }
}
