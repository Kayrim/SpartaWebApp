﻿using System;
using System.Collections.Generic;

namespace SpartaWebApp.Models
{
    public partial class Category
    {
        public Category()
        {
            Course = new HashSet<Course>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Course> Course { get; set; }
    }
}
