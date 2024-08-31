using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoptPet.Domain.VolunteerManagement.IDs;

public record PetPhotoId
{
    private PetPhotoId(Guid value)
    {
        Value = value;
    }
    public Guid Value { get; }
    public static PetPhotoId NewPetId() => new(Guid.NewGuid());
    public static PetPhotoId Empty() => new(Guid.Empty);
}
