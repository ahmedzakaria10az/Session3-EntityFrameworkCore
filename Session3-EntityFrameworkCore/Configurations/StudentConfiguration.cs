using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session3_EntityFrameworkCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Session3_EntityFrameworkCore.Configurations
{
    internal class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.FullName)
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(s => s.Email)
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(s => s.DateOfBirth)
                   .IsRequired();
        }
    }
}
