using AdoptPet.Domain.Entities.CommonModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoptPet.Domain.Entities.Volunteers;

public sealed class VolunteerDetails
{
    public List<Requisite> Requisites { get; private set; }
    public List<SocialMedia> SocialMedias { get; private set; }
}
