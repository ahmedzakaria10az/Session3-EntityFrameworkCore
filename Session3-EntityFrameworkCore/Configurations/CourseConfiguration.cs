using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session3_EntityFrameworkCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Session3_EntityFrameworkCore.Configurations
{
    internal class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Title)
                   .HasMaxLength(200)
                   .IsRequired();

            builder.Property(c => c.Description)
                   .HasMaxLength(500);

            builder.Property(c => c.Price)
                   .HasPrecision(10,2)
                   .IsRequired();

            builder.Property(c => c.Level)
                   .HasMaxLength(20)
                   .IsRequired();

            builder.Property(c => c.IsPublished)
                   .IsRequired();

            builder.Property(c => c.PublishedDate)
                    .IsRequired();



            builder.HasOne(c => c.Instructor)
                   .WithMany(i => i.Courses)
                   .HasForeignKey(c => c.InstructorId)
                   .OnDelete(DeleteBehavior.Restrict);



            builder.HasOne(c => c.Category)
                   .WithMany(c => c.Courses)
                   .HasForeignKey(c => c.CategoryId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
