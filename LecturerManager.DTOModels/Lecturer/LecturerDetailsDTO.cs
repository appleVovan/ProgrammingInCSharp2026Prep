using KMA.ProgrammingInCSharp2026.LecturerManager.CommonComponents.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace KMA.ProgrammingInCSharp2026.LecturerManager.DTOModels.Lecturer
{
    public class LecturerDetailsDTO
    {
        public Guid Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public LecturerPosition Position { get; }
        public DateTime DateOfBirth { get; }
        public LecturerDetailsDTO(Guid id, string firstName, string lastName, LecturerPosition position, DateTime dateOfBirth)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Position = position;
            DateOfBirth = dateOfBirth;
        }
    }
}
