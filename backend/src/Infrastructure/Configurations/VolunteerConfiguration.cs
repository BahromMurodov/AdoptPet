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

public class VolunteerConfiguration : IEntityTypeConfiguration<Volunteer>
{
    public void Configure(EntityTypeBuilder<Volunteer> builder)
    {
        builder.ToTable("volunteer");

        builder.HasKey(v => v.Id);

        builder.Property(v => v.FullName)
            .IsRequired()
            .HasMaxLength(Constants.MAX_LOW_TEXT_LENGTH);

        builder.Property(v => v.Description)
            .IsRequired()
            .HasMaxLength(Constants.MAX_HIGH_TEXT_LENGTH);

        builder.Property(v => v.Experience)
            .IsRequired();

        builder.Property(v => v.NumberPetFindHome)
            .IsRequired();

        builder.Property(v => v.NumberPetSearchHome)
            .IsRequired();

        builder.Property(v => v.NumberPetHealing)
            .IsRequired();

        builder.Property(v => v.Phone)
            .IsRequired()
            .HasMaxLength(Constants.MAX_HIGH_PHONE_LENGTH);

        builder.HasMany(v => v.Pets)
            .WithOne() 
            .HasForeignKey("VolunteerId") 
            .OnDelete(DeleteBehavior.Cascade);
    }
}
