using System;
using System.Collections.Generic;

namespace SpartaWebApp.Models
{
    public partial class Student
    {
        public Student()
        {
            Project = new HashSet<Project>();
        }

        public int StudentId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int? CourseId { get; set; }
        public string Photo { get; set; }
        public string Bio { get; set; }
        public string University { get; set; }

        public virtual Course Course { get; set; }
        public virtual ICollection<Project> Project { get; set; }
    }
}
