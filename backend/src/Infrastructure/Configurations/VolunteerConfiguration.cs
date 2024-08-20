﻿using AdoptPet.Domain.Entities.Volunteers;
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

        builder.OwnsOne(b => b.VolunteersRequisite, rb =>
        {
            rb.ToJson();
            rb.OwnsMany(r => r.Requisites, x =>
            {
                x.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(Constants.MAX_LOW_TEXT_LENGTH);

                x.Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(Constants.MAX_HIGH_TEXT_LENGTH);
            });
        });

        builder.OwnsOne(b => b.VolunteersSocialMedia, rb =>
        {
            rb.ToJson();
            rb.OwnsMany(r => r.SocialMedias, x =>
            {
                x.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(Constants.MAX_LOW_TEXT_LENGTH);

                x.Property(x => x.Link)
                .IsRequired()
                .HasMaxLength(Constants.MAX_MEDIUM_TEXT_LENGTH);
            });
        });

        //builder.OwnsOne(x => x.Details, vd =>
        //{
        //    vd.ToJson();
        //    vd.OwnsMany(d => d.Requisites, r =>
        //    {
        //        r.Property(x => x.Name)
        //        .IsRequired()
        //        .HasMaxLength(Constants.MAX_LOW_TEXT_LENGTH);

        //        r.Property(x => x.Description)
        //        .IsRequired()
        //        .HasMaxLength(Constants.MAX_HIGH_TEXT_LENGTH);

        //    });
        //    vd.OwnsMany(d => d.SocialMedias, r =>
        //    {

        //        r.Property(x => x.Name)
        //        .IsRequired()
        //        .HasMaxLength(Constants.MAX_LOW_TEXT_LENGTH);

        //        r.Property(x => x.Link)
        //        .IsRequired()
        //        .HasMaxLength(Constants.MAX_MEDIUM_TEXT_LENGTH);
        //    });

        //});
    }
}
