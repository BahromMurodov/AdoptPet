using AdoptPet.Domain.Shared;
using AdoptPet.Domain.VolunteerManagement.IDs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoptPet.Domain.VolunteerManagement.Entities;

public record PetPhoto
{
    private PetPhoto(string path, bool isMain)
    {
        Path = path;
        IsMain = isMain;
    }

    public string Path { get; private set; } = string.Empty!;
    public bool IsMain { get; private set; }
    
}
