using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoptPet.Domain.Entities;

public class PetType
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
}
