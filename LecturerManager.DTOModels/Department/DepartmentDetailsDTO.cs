using KMA.ProgrammingInCSharp2026.LecturerManager.CommonComponents.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace KMA.ProgrammingInCSharp2026.LecturerManager.DTOModels.Department
{
    public class DepartmentDetailsDTO
    {
        public Guid Id { get; }
        public string Name { get; }
        public Faculty Faculty { get; }
        public string Email { get; }

        public DepartmentDetailsDTO(Guid id, string name, Faculty faculty, string email)
        {
            Id = id;
            Name = name;
            Faculty = faculty;
            Email = email;
        }
    }
}
