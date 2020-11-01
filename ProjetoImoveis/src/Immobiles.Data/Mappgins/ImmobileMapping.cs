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
            builder.HasKey(i => i.ImmobileId);
            builder.Property(i => i.EType);
            builder.HasOne(a => a.Address)
                   .WithOne(ai => ai.Immobiles)
                   .HasForeignKey<Immobile>(ai => ai.AddressId);
        }
    }
}
