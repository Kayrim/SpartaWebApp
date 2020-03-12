using SpartaWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartaWebApp.Services
{
    public interface ICategoryRepo
    {
        public Task<IEnumerable<Category>> GetCategoryWithCourses();

        public Task<Category> GetSingleCategoryWithCourse(int CategoryId);
    }
}
