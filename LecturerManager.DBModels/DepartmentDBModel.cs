using System;
using System.Collections.Generic;
using System.Text;

namespace KMA.ProgrammingInCSharp2026.LecturerManager.DBModels
{
    public enum Faculty
    {
        FacultyOfInformatics,
        FacultyOfEconomics,
        FacultyOfLaw,
        FacultyOfNaturalSciences
    }

    public class DepartmentDBModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Faculty Faculty { get; set; }
    }
}
