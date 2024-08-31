using AdoptPet.Domain.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoptPet.Domain.VolunteerManagement.ValueObjects;

public record VolunteersRequisite
{
    private VolunteersRequisite()
    {
    }

    public VolunteersRequisite(IEnumerable<Requisite> requisites)
    {
        Requisites = requisites.ToList();
    }
    public IReadOnlyList<Requisite> Requisites { get; }
}
