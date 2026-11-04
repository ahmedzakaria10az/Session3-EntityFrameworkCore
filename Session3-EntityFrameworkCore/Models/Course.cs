using System;
using System.Collections.Generic;
using System.Text;
using Session3_EntityFrameworkCore.Enums;

namespace Session3_EntityFrameworkCore.Models
{
    internal class Course
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;  
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public CourseLevel Level { get; set; }
        public bool IsPublished { get; set; }
        public DateTime? PublishedDate { get; set; }



        //Relationship with Instructor 
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; } = null!;


        //Relationship with Category 
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;


        //Relationship with Enrollment
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }
}
