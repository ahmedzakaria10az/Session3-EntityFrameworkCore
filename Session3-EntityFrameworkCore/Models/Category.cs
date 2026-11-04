using System;
using System.Collections.Generic;
using System.Text;

namespace Session3_EntityFrameworkCore.Models
{
    internal class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }




        public int? ParentCategoryId { get; set; }

        // Parent Navigation Property
        public Category? ParentCategory { get; set; }

        // Children Navigation Property
        public ICollection<Category> SubCategories { get; set; } = new List<Category>();



        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
