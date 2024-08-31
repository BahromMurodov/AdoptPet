using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AdoptPet.Domain.Shared.ValueObjects;

public record Address
{
    public const int MAX_LENGTH = 100;
    private Address()
    {
    }
    private Address(string street,
                    string city,
                    string country,
                    string zipCode)
    {
        Street = street;
        City = city;
        Country = country;
        ZipCode = zipCode;
    }
    public string Street { get; }
    public string City { get; }
    public string Country { get; }
    public string ZipCode { get; }
}
