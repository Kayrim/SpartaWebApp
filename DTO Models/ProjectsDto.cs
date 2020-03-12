using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartaWebApp.DTO_Models
{
    public class ProjectsDto
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public int? StudentId { get; set; }
        public string ProjectDescription { get; set; }

    }
}
