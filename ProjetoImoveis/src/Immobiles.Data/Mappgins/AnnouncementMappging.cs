using Immobiles.Domain;
using Immobiles.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Immobiles.Data.Mappgins
{
    public class AnnouncementMapping : IEntityTypeConfiguration<Announcement>
    {
        public void Configure(EntityTypeBuilder<Announcement> builder)
        {
            builder.ToTable("Announcements");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Bathroom);
            builder.Property(a => a.Bedroom);
            builder.Property(a => a.CondominiumValue).HasColumnType("decimal(5,3)");
            builder.Property(a => a.Description);
            builder.Property(a => a.Suite);
            builder.Property(a => a.Iptu).HasColumnType("decimal(5,3)");
            builder.Property(a => a.Value).HasColumnType("decimal(5,3)");
            builder.Property(a => a.Vacancy);
            builder.Property(a => a.Walk);
            builder.Property(a => a.UsefulArea).HasColumnType("decimal(5,3)");
            builder.HasOne(u => u.User)
                   .WithMany(au => au.Announcements)
                   .HasForeignKey(au => au.Id);
        }
    }
}
