using AdoptPet.Domain.Entities.CommonModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoptPet.Domain.Entities.Volunteers;

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
