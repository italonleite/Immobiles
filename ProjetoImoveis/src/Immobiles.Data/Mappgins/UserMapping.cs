using Immobiles.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Immobiles.Data.Mappgins
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Login).HasColumnType("varchar(9)");
            builder.Property(u => u.Email);
            builder.Property(u => u.Password);
            builder.HasMany(a => a.Announcements)
                           .WithOne(ua => ua.User)
                           .HasForeignKey(au => au.UserId);
        }
    }
}
