using System;
using System.Collections.Generic;
using System.Text;

namespace KMA.ProgrammingInCSharp2026.CourseProject.DBModels
{    
    public class LecturerDBModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public LecturerPosition Position { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
