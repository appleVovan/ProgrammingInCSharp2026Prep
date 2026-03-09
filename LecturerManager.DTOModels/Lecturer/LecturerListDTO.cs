using KMA.ProgrammingInCSharp2026.LecturerManager.CommonComponents.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace KMA.ProgrammingInCSharp2026.LecturerManager.DTOModels.Lecturer
{
    public class LecturerListDTO
    {
        public Guid Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public LecturerPosition Position { get; }
        public LecturerListDTO(Guid id, string firstName, string lastName, LecturerPosition position)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Position = position;
        }
    }
}
