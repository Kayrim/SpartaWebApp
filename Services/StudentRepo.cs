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
        private readonly IMapper _mapper;

        public StudentRepo(SpartaDBContext context, IMapper mapper)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public async Task <Student> GetSingleStudentWithProjects(int studentID)
        {
            return await _context.Student.Include(p => p.Project).Where(p => p.StudentId == studentID).FirstOrDefaultAsync();
        }

        public IEnumerable<Student> GetStudentsWithProjects()
        {
            throw new NotImplementedException();
        }
    }
}
