using KMA.ProgrammingInCSharp2026.LecturerManager.CommonComponents.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace KMA.ProgrammingInCSharp2026.LecturerManager.DBModels
{
    public class LecturerDBModel
    {
        public Guid Id { get; set; }
        public Guid DepartmentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public LecturerPosition Position { get; set; }
        public DateTime DateOfBirth { get; set; }

        public LecturerDBModel()
        {
            
        }
        public LecturerDBModel(Guid departmentId, string firstName, string lastName, LecturerPosition position, DateTime dateOfBirth) : this(Guid.NewGuid(), departmentId, firstName, lastName, position, dateOfBirth)
        {            
        }
        public LecturerDBModel(Guid id, Guid departmentId, string firstName, string lastName, LecturerPosition position, DateTime dateOfBirth)
        {
            Id = id;
            DepartmentId = departmentId;
            FirstName = firstName;
            LastName = lastName;
            Position = position;
            DateOfBirth = dateOfBirth;
        }
    }
}
