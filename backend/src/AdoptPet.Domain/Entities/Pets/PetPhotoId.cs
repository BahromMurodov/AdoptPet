using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoptPet.Domain.Entities.Pets;

public record PetPhotoId
{
    private PetPhotoId(Guid value)
    {
        Value = value;
    }
    public Guid Value { get; private set; }
    public static PetPhotoId NewPetId() => new(Guid.NewGuid());
    public static PetPhotoId Empty() => new(Guid.Empty);
}
