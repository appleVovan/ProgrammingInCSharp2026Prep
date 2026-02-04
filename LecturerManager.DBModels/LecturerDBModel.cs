using KMA.ProgrammingInCSharp2026.LecturerManager.CommonComponents.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace KMA.ProgrammingInCSharp2026.LecturerManager.DBModels
{
    public class LecturerDBModel
    {
        //Id is generated only once during the creation of the object and cannot be changed later. 
        public Guid Id { get; }
        //DepartmentId is set only once during the creation of the object and cannot be changed later. 
        public Guid DepartmentId { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public LecturerPosition Position { get; set; }
        //DateOfBirth is set only once during the creation of the object and cannot be changed later. 
        public DateTime DateOfBirth { get; }
    }
}
