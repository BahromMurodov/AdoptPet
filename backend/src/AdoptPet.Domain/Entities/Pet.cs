using AdoptPet.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoptPet.Domain.Entities;

public class Pet
{
    public Guid Id { get; set; }
    public string NickName { get; set; } = null!;
    public PetType Type { get; set; } = null!;
    public string? Description { get; set; }

    public string Breed { get; set; } = null!;//порода
    public string Color { get; set; } = null!;
    public string Health { get; set; } = null!;
    public string AddressLocated { get; set; } = null!;
    public double Weight { get; set; }
    public double Height { get; set; }
    public string PhoneNumber { get; set; } = null!;
    public bool IsNeutered { get; set; }//Кастрирован?
    public DateOnly DateBirth { get; set; }
    public bool IsVaccinated { get; set; }
    public HelpStatus StatusHelp { get; set; }
    public Requisites Requisites { get; set; }
    public DateTime DateCreated { get; set; }
}
