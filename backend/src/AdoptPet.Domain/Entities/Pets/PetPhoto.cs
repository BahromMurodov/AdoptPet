using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoptPet.Domain.Entities.Pets;

public class PetPhoto
{
    public Guid Id { get; private set; }
    public string Path { get; private set; } = string.Empty!;
    public bool IsMain { get; private set; }
    private PetPhoto()
    { }
}
