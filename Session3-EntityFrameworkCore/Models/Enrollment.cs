using System;
using System.Collections.Generic;
using System.Text;
using Session3_EntityFrameworkCore.Enums;


namespace Session3_EntityFrameworkCore.Models
{
    internal class Enrollment
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public decimal ProgressPercentage { get; set; }
        public EnrollmentStatus Status { get; set; }
        public decimal? FinalGrade { get; set; }



        public Student Student { get; set; }

        public Course Course { get; set; }
    }
}
