using SpartaWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartaWebApp.DTO_Models
{
    public class StudentsWithProjectsDto
    {
        public StudentsWithProjectsDto()
        {
            Project = new HashSet<ProjectsDto>();
        }

        public int StudentId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int? CourseID { get; set; }
        public string Photo { get; set; }
        public string Bio { get; set; }
        public string University { get; set; }
        public virtual ICollection<ProjectsDto> Project { get; set; }
    }
}
