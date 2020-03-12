using SpartaWebApp.DTO_Models;
using System;
using System.Collections.Generic;

namespace SpartaWebApp.Models
{
    public partial class CategoryDto
    {
        public CategoryDto()
        {
            Course = new HashSet<CourseDto>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<CourseDto> Course { get; set; }
    }
}
