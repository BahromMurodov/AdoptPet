using AdoptPet.Domain.Entities;
using AdoptPet.Domain.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configurations;

public class PetConfiguration : IEntityTypeConfiguration<Pet>
{
    public void Configure(EntityTypeBuilder<Pet> builder)
    {
        builder.ToTable("pets");

        builder.HasKey(p => p.Id);
        
        builder.Property(p => p.NickName)
            .IsRequired()
            .HasMaxLength(Constants.MAX_LOW_TEXT_LENGTH);
        
        builder.Property(p => p.Type)
            .IsRequired()
            .HasMaxLength(Constants.MAX_LOW_TEXT_LENGTH);

        builder.Property(p => p.Description)
            .IsRequired()
            .HasMaxLength(Constants.MAX_HIGH_TEXT_LENGTH);

        builder.Property(p => p.Breed)
            .IsRequired()
            .HasMaxLength(Constants.MAX_LOW_TEXT_LENGTH);


        builder.Property(p => p.Color)
        .IsRequired() 
        .HasMaxLength(Constants.MAX_LOW_TEXT_LENGTH); 

        builder.Property(p => p.Health)
            .IsRequired()
            .HasMaxLength(Constants.MAX_LOW_TEXT_LENGTH);

        builder.Property(p => p.AddressLocated)
            .IsRequired()
            .HasMaxLength(Constants.MAX_HIGH_TEXT_LENGTH);

        builder.Property(p => p.Weight)
            .IsRequired();

        builder.Property(p => p.Height)
            .IsRequired(); 

        builder.Property(p => p.PhoneNumber)
            .IsRequired()
            .HasMaxLength(Constants.MAX_LOW_TEXT_LENGTH);

        builder.Property(p => p.IsNeutered)
            .IsRequired(); 

        builder.Property(p => p.DateBirth)
            .IsRequired(); 

        builder.Property(p => p.IsVaccinated)
            .IsRequired();

        builder.Property(p => p.StatusHelp)
            .IsRequired();

        builder.HasMany(p => p.PetPhotos)
            .WithOne()
            .HasForeignKey("PetId")
            .IsRequired();

        builder.ComplexProperty(r => r.Requisites);
    }
}
