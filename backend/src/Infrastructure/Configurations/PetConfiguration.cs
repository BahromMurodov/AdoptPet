﻿using AdoptPet.Domain.Shared;
using AdoptPet.Domain.VolunteerManagement.Entities;
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

        builder.Property(p => p.Id)
            .HasConversion(
                id => id.Value,
                value => PetId.Create(value)
            );

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

        builder.OwnsOne(p => p.PhotoList, ph =>
        {
            ph.ToJson("pet_photos");
            ph.OwnsMany(x => x.Photos, pb =>
            {
                pb.Property(x=>x.Path)
                .IsRequired()
                .HasMaxLength(Constants.MAX_LOW_TEXT_LENGTH);
            });
        });

        builder.ComplexProperty(p => p.SpeciesId,
        sb =>
        {
            sb.Property(s => s.Value)
            .IsRequired()
            .HasColumnName("species_id");
        });
       
        builder.Property(b => b.BreedId)
            .IsRequired();

        builder.ComplexProperty(a => a.Address, ab =>
        {
            ab.Property(a => a.Street)
            .IsRequired()
            .HasMaxLength(Constants.MAX_LOW_TEXT_LENGTH);

            ab.Property(a => a.City)
            .IsRequired()
            .HasMaxLength(Constants.MAX_LOW_TEXT_LENGTH);

            ab.Property(a => a.Country)
            .IsRequired()
            .HasMaxLength(Constants.MAX_LOW_TEXT_LENGTH);

            ab.Property(a => a.ZipCode)
            .IsRequired()
            .HasMaxLength(Constants.MAX_LOW_TEXT_LENGTH);
        });

        builder.OwnsOne(x => x.PetsRequisite, pd =>
        {
            pd.ToJson("pet_requisites");
            pd.OwnsMany(d => d.Requisites, rb =>
            {
                rb.Property(r => r.Name)
                .IsRequired()
                .HasMaxLength(Constants.MAX_LOW_TEXT_LENGTH);

                rb.Property(r => r.Description)
                .IsRequired(false)
                .HasMaxLength(Constants.MAX_HIGH_TEXT_LENGTH);
            });
        });
    }
}
