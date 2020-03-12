using Microsoft.EntityFrameworkCore;
using SpartaWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartaWebApp.Services
{
    public class CategoryRepo : ICategoryRepo
    {
        private readonly SpartaDBContext _context;

        public CategoryRepo(SpartaDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task<IEnumerable<Category>> GetCategoryWithCourses()
        {
            return await _context.Category.Include(c => c.Course).ToListAsync();
        }

        public async Task <Category> GetSingleCategoryWithCourse(int CategoryId)
        {
            return await _context.Category.Include(c=>c.Course).Where(c => c.CategoryId == CategoryId).FirstOrDefaultAsync();
        }
    }
}
