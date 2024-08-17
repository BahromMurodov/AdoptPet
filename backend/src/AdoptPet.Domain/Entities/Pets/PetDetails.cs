using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdoptPet.Domain.Entities.CommonModels;

namespace AdoptPet.Domain.Entities.Pets;

public sealed class PetDetails
{
    public List<Requisite> Requisites { get; private set; }
}
