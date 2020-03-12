using AutoMapper;
using SpartaWebApp.DTO_Models;
using SpartaWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SpartaWebApp.Profiles
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap<Project, ProjectsDto>();

        }
    }
}
