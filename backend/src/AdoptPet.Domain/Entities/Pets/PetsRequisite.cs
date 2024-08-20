using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdoptPet.Domain.Entities.CommonModels;

namespace AdoptPet.Domain.Entities.Pets;

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
