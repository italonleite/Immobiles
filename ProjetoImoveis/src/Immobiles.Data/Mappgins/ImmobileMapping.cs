using Immobiles.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Immobiles.Data.Mappgins
{
    class ImmobileMapping : IEntityTypeConfiguration<Immobile>
    {
        public void Configure(EntityTypeBuilder<Immobile> builder)
        {
            builder.ToTable("Imobiles");
            builder.HasKey(i => i.Id);
            builder.Property(i => i.EType);
            builder.HasOne(i => i.Address)
                   .WithOne(ia => ia.Immobile)
                   .HasForeignKey<Immobile>(ia => ia.AddressId);
        }
       
    }
}
