using AdoptPet.Domain.Entities.Pets;
using AdoptPet.Domain.Entities.Species;
using AdoptPet.Domain.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configurations;

public class SpeciesConfiguration : IEntityTypeConfiguration<Species>
{
    public void Configure(EntityTypeBuilder<Species> builder)
    {
        builder.ToTable("species");
        builder.HasKey(s => s.Id);

        builder.Property(s => s.Name)
            .IsRequired()
            .HasMaxLength(Constants.MAX_LOW_TEXT_LENGTH);

        builder.HasMany(s=>s.Breeds)
            .WithOne()
            .HasForeignKey("species_id")
            .IsRequired()
            .OnDelete(DeleteBehavior.NoAction);
    }
}
