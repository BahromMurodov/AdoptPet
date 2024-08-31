using AdoptPet.Domain.Shared;
using AdoptPet.Domain.Shared.ValueObjects;
using CSharpFunctionalExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoptPet.Domain.VolunteerManagement.ValueObjects;

public record HelpStatus
{
    private static readonly HelpStatus[] _statuses = [NeedsHelp!, LookingForHome!, FoundAHouse!];

    private HelpStatus(string status)
    {
        Status = status;
    }

    public static readonly HelpStatus NeedsHelp = new(nameof(NeedsHelp));
    public static readonly HelpStatus LookingForHome = new(nameof(LookingForHome));
    public static readonly HelpStatus FoundAHouse = new(nameof(FoundAHouse));

    public string Status { get; } = default!;

    public static Result<HelpStatus, Error> Create(string status)
    {
        if (string.IsNullOrWhiteSpace(status) || 
            !_statuses.Any(s=>s.Status.Equals(status)))
            return Errors.General.ValueIsInvalid("HelpStatus");

        return new HelpStatus(status);
    }

}
