using Immobiles.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Immobiles.Data.Mappgins
{
    public class AddressMapping : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Addresses");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Cep).HasColumnType("varchar(9)");
            builder.Property(a => a.Neighborhood).HasColumnType("varchar(200)");
            builder.Property(a => a.StreetAddress).HasColumnType("varchar(100)");
            builder.Property(a => a.City).HasColumnType("varchar(50)");
            builder.Property(a => a.State).HasColumnType("varchar(2)");
            builder.HasOne(a => a.Immobile)
                   .WithOne(ai => ai.Address)
                   .HasForeignKey<Address>(ai => ai.ImmobileId);


        }
    }
}
