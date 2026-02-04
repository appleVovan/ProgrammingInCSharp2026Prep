using System;
using System.Collections.Generic;
using System.Text;

namespace KMA.ProgrammingInCSharp2026.LecturerManager.DBModels
{
    public enum LecturerPosition
    {
        Assistant,
        Lecturer,
        SeniorLecturer,
        AssociateProfessor,
        Professor,
    }
    public class LecturerDBModel
    {
        public Guid Id { get; set; }
        public Guid DepartmentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public LecturerPosition Position { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
