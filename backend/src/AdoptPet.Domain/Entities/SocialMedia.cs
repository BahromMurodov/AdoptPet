using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoptPet.Domain.Entities;

public class SocialMedia
{
    public string Link { get; private set; } = string.Empty!;
    public string Name { get; private set; } = string.Empty!;
}
