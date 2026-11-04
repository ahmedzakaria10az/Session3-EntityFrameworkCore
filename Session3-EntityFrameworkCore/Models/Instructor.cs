using System;
using System.Collections.Generic;
using System.Text;

namespace Session3_EntityFrameworkCore.Models
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Bio { get; set; }
        public DateTime JoinedDate { get; set; }

        //Relationship with Course
        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
