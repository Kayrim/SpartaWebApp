using System;
using System.Collections.Generic;

namespace SpartaWebApp.Models
{
    public partial class Course
    {
        public Course()
        {
            Student = new HashSet<Student>();
            TrainerCourses = new HashSet<TrainerCourses>();
        }

        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int? CatgeoryId { get; set; }
        public string LengthOfCourse { get; set; }
        public string CourseDescription { get; set; }

        public virtual Category Catgeory { get; set; }
        public virtual ICollection<Student> Student { get; set; }
        public virtual ICollection<TrainerCourses> TrainerCourses { get; set; }
    }
}
