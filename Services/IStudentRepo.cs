using SpartaWebApp.DTO_Models;
using SpartaWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartaWebApp.Services
{
    public interface IStudentRepo
    {

        public Task<IEnumerable<Student>> GetStudentsWithProjects();

        public Task<Student> GetSingleStudentWithProjects(int studentId);
    }
}
