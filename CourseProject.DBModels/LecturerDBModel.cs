using KMA.ProgrammingInCSharp2026.CourseProject.CourseProject.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace KMA.ProgrammingInCSharp2026.CourseProject.DBModels
{    
    public class LecturerDBModel
    {
        //Id is read-only to prevent modification after creation
        public Guid Id { get; }
        //Id of the department the lecturer cannot be changed after creation
        public Guid DepartmentGuid { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public LecturerPosition Position { get; set; }
        //DateOfBirth is set during creation and cannot be changed later
        public DateTime DateOfBirth { get; }

        private LecturerDBModel()
        {
        }

        public LecturerDBModel(Guid departmentGuid, string firstName, string lastName, LecturerPosition position, DateTime dateOfBirth)
        {
            Id = Guid.NewGuid();
            DepartmentGuid = departmentGuid;
            FirstName = firstName;
            LastName = lastName;
            Position = position;
            DateOfBirth = dateOfBirth;
        }
    }
}
