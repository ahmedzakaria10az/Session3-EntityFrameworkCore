using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session3_EntityFrameworkCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Session3_EntityFrameworkCore.Configurations
{
    internal class EnrollmentConfiguration : IEntityTypeConfiguration<Enrollment>

    {
        public void Configure(EntityTypeBuilder<Enrollment> builder)
        {
            builder.HasKey(e => new {e.StudentId,e.CourseId});

            builder.Property(e => e.EnrollmentDate)
                   .IsRequired();

            builder.Property(e => e.ProgressPercentage)
                   .HasPrecision(5,2)
                   .IsRequired();

            builder.Property(e => e.Status)
                   .HasMaxLength(20)
                   .IsRequired();

            builder.Property(e => e.FinalGrade)
                   .HasPrecision(5,2);



            // Student One-to-Many Enrollment
            builder.HasOne(e => e.Student)
                   .WithMany(s => s.Enrollments)
                   .HasForeignKey(e => e.StudentId)
                   .OnDelete(DeleteBehavior.Cascade);

            // Course One-to-Many Enrollment
            builder.HasOne(e => e.Course)
                   .WithMany(c => c.Enrollments)
                   .HasForeignKey(e => e.CourseId)
                   .OnDelete(DeleteBehavior.Cascade);



            // Business Rule: Progress 0 - 100
            builder.ToTable(t => t.HasCheckConstraint(
                    "EnrollmentProgress","ProgressPercentage >= 0 AND ProgressPercentage <= 100"));

            // Final Grade when Completed
            builder.ToTable(t => t.HasCheckConstraint(
                    "EnrollmentFinalGrade","FinalGrade IS NULL OR Status = 'Completed'"));
        }
    }
}
