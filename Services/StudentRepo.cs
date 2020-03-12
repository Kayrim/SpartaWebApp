using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SpartaWebApp.DTO_Models;
using SpartaWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartaWebApp.Services
{
    public class StudentRepo : IStudentRepo
    {
        private readonly SpartaDBContext _context;

        public StudentRepo(SpartaDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task<Student> GetSingleStudentWithProjects(int studentID)
        {
            return await _context.Student.Include(p => p.Project).Where(p => p.StudentId == studentID).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Student>> GetStudentsWithProjects()
        {
            return await _context.Student.Include(p => p.Project).ToListAsync();
        }
    }
}
