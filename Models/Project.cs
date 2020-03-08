using System;
using System.Collections.Generic;

namespace SpartaWebApp.Models
{
    public partial class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public int? StudentId { get; set; }
        public string ProjectDescription { get; set; }

        public virtual Student Student { get; set; }
    }
}
