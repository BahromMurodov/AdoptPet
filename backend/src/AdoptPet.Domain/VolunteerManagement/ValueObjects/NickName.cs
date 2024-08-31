using AdoptPet.Domain.Shared;
using CSharpFunctionalExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoptPet.Domain.VolunteerManagement.ValueObjects;

public record NickName
{
    public const int MAX_LENGTH = 100;
    public const int MIN_LENGTH = 3;

    public string Value { get; }

    private NickName(string value)
    {
        Value = value;
    }

    public static Result<NickName, Error> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value)
            || value.Length > MAX_LENGTH
            || value.Length < MIN_LENGTH
            || IsValidNickName(value) == false)
        {
            return Errors.General.ValueIsInvalid("Title");
        }
            

        return new NickName(value);
    }
    private static bool IsValidNickName(string value)
    {
        // Example of a simple validation: only letters, spaces, and hyphens are allowed
        foreach (char c in value)
        {
            if (!char.IsLetter(c) && c != ' ' && c != '-')
                return false;
        }
        return true;
    }

}
