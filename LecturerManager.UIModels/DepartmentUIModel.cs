using KMA.ProgrammingInCSharp2026.LecturerManager.CommonComponents.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace KMA.ProgrammingInCSharp2026.LecturerManager.UIModels
{
    public class DepartmentUIModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Faculty Faculty { get; set; }
    }
}
