using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoptPet.Domain.VolunteerManagement.ValueObjects;

public record VolunteersSocialMedia
{
    private VolunteersSocialMedia()
    {
    }
    public VolunteersSocialMedia(IEnumerable<SocialMedia> socialMedias)
    {
        SocialMedias = socialMedias.ToList();
    }
    public IReadOnlyList<SocialMedia> SocialMedias { get; }
}
