using KMA.ProgrammingInCSharp2026.LecturerManager.CommonComponents.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace KMA.ProgrammingInCSharp2026.LecturerManager.UIModels
{
    public class LecturerUIModel
    {
        public Guid Id { get; set; }
        public Guid DepartmentGuid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public LecturerPosition Position { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
