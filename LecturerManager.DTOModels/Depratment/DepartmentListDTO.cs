using KMA.ProgrammingInCSharp2026.LecturerManager.CommonComponents.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace KMA.ProgrammingInCSharp2026.LecturerManager.DTOModels.Depratment
{
    public class DepartmentListDTO
    {
        public Guid Id { get; }
        public string Name { get; }
        public Faculty Faculty { get; }
        public int LecturersCount { get; set; }

        public DepartmentListDTO(Guid id, string name, Faculty faculty, int lecturersCount)
        {
            Id = id;
            Name = name;
            Faculty = faculty;
            LecturersCount = lecturersCount;
        }
    }
}
