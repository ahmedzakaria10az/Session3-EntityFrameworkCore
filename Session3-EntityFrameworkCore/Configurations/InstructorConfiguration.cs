using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session3_EntityFrameworkCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Session3_EntityFrameworkCore.Configurations
{
    internal class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(i => i.FullName)
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(i => i.Email)
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(i => i.Bio)
                   .HasMaxLength(500);

            builder.Property(i => i.JoinedDate)
                   .IsRequired();
        }
    }
}
